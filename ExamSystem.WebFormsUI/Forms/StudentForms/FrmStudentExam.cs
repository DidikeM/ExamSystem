using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.WebFormsUI.Forms.StudentForms
{
    public partial class FrmStudentExam : DevExpress.XtraEditors.XtraForm
    {
        private readonly IQuestionService _questionService = InstanceFactory.GetInstance<IQuestionService>();
        private readonly IStudentStatusService _studentStatusService = InstanceFactory.GetInstance<IStudentStatusService>();
        private readonly ITimeIntervalService _timeIntervalService = InstanceFactory.GetInstance<ITimeIntervalService>();
        private readonly IStudentStatisticsService _studentStatisticsService = InstanceFactory.GetInstance<IStudentStatisticsService>();

        private FrmQuestionView _frmQuestionView;
        private readonly Student _student;
        private readonly List<StudentStatus> _studentStatusList;
        private readonly List<Question> _examQuestions = new List<Question>();
        private int _questionCounter = 0;
        private TimeSpan _examTimeSpan;

        public FrmStudentExam(Student student)
        {
            _student = student;
            _studentStatusList = _studentStatusService.GetByStudentId(student.ID); //Öğrencinin daha önceki çözdüğü soruların durumlarını database den çeker
            InitializeComponent();
        }

        private void FrmStudentExam_Load(object sender, EventArgs e)
        {

            GetSigmaQuestions();
            GetRandomQuestions(10);
            //_examQuestions = _questionService.GetAll();
            OpenQuestion();
            TimerStart();
        }

        private void GetRandomQuestions(int count)// sınav sorularına count kadar soru ekler
        {
            List<int> questionIds = _questionService.GetAllIds();//sistemdeki soruların idlerini getirir
            //_questionIds = _questionIds.Where(p => !(_examQuestions.Any(q => q.ID == p))).ToList();
            //daha önce doğru olarak çözülen soruları tüm havuzdan çıkartır
            questionIds = questionIds.Where(p => !(_studentStatusList.Any(q => q.QuestionID == p && q.Status != 0))).ToList();
            Random random = new Random();
            for (int i = 0; i < count; i++)//çözülmemiş veya yanlış çözülmüş soru havuzundan rastgele soruları sınav sorularına ekler
            {
                int x = random.Next(0, questionIds.Count - 1);
                _examQuestions.Add(_questionService.GetById(questionIds[x]));
                questionIds.RemoveAt(x);
            }
        }

        private void GetSigmaQuestions()// 6 sigma prensibinin gereksinimi olan; daha önce doğru çözülmüş ve zamanı gelmiş soruları sınav sorularına ekler
        {
            TimeInterval timeInterval = _timeIntervalService.GetById(_student.TimeIntervalID);
            List<int> intervals = new List<int>()
            {
                timeInterval.Interval1,
                timeInterval.Interval2,
                timeInterval.Interval3,
                timeInterval.Interval4,
                timeInterval.Interval5,
                timeInterval.Interval6,
            };
            foreach (var studentStatus in _studentStatusList)
            {
                if (studentStatus.Status > 0 && (DateTime.Today - studentStatus.FirstTime) >= TimeSpan.FromDays(Convert.ToDouble(intervals[studentStatus.Status - 1])))
                {
                    _examQuestions.Add(_questionService.GetById(studentStatus.QuestionID));
                }
            }
        }

        private void OpenQuestion()//sınav sorularındaki sıradaki soruyu ekrana getirir
        {
            CloseQuestion();
            _frmQuestionView = new FrmQuestionView(_examQuestions[_questionCounter++]);
            _frmQuestionView.MdiParent = this;
            _frmQuestionView.Show();
            lblQuestionNumber.Text = "Soru: " + _questionCounter + "/" + _examQuestions.Count;
        }

        private void CloseQuestion()// çocuk formları kapatır
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
        }

        private void TimerStart()// timer ı başlatır
        {
            _examTimeSpan = new TimeSpan(0, _examQuestions.Count, 0);
            timerExam.Start();
        }

        private void timerExam_Tick(object sender, EventArgs e)//kalan süreyi ekrana yazar
        {
            _examTimeSpan -= TimeSpan.FromSeconds(1);
            lblCounter.Text = _examTimeSpan.ToString();
            if (_examTimeSpan.TotalSeconds < 0)
            {
                this.Close();
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)//işaretlenen şıkka göre gerekli database işlemleri yapar ve sıradaki soruyu getirir veya formu kapatır
        {
            if (_frmQuestionView.SelectedChoice == null)
            {
                MessageBox.Show("Lütfen bir şık işaretleyiniz");
                return;
            }

            StudentStatus studentStatus = _studentStatusService.GetByStudentIdAndQuestionId(_student.ID, _examQuestions[_questionCounter - 1].ID);
            //6 sigma için gerekli veriyi database den çeker. yoksa yeni nesne oluşturur
            if (studentStatus == null)
            {
                studentStatus = new StudentStatus()
                {
                    QuestionID = _examQuestions[_questionCounter - 1].ID,
                    FirstTime = DateTime.Today,
                    Status = 0,
                    StudentID = _student.ID
                };
                _studentStatusService.Add(studentStatus);
            }

            StudentStatistics studentStatistics = _studentStatisticsService.GetByStudentIdAndSectionId(_student.ID, _examQuestions[_questionCounter - 1].SectionID);
            //analiz için gerekli veriyi database den çeker. yoksa yeni nesne oluşturur
            if (studentStatistics == null)
            {
                studentStatistics = new StudentStatistics()
                {
                    StudentID = _student.ID,
                    SectionID = _examQuestions[_questionCounter - 1].SectionID,
                    TrueCount = 0,
                    FalseCount = 0
                };
                _studentStatisticsService.Add(studentStatistics);
            }

            if (_frmQuestionView.SelectedChoice.ID == _examQuestions[_questionCounter - 1].CorrectAnswer)
            {
                if (studentStatus.Status == 0)
                {
                    studentStatus.FirstTime = DateTime.Today;
                }
                studentStatus.Status++;
                studentStatistics.TrueCount++;
            }
            else
            {
                studentStatus.Status = 0;
                studentStatistics.FalseCount++;
            }
            _studentStatusService.Update(studentStatus);
            _studentStatisticsService.Update(studentStatistics);

            if (_questionCounter < _examQuestions.Count)// sorular bittiyse sınav ekranını kapatır bitmediyse sıradaki soruyu getirir
            {
                OpenQuestion();
            }
            else
            {
                CloseQuestion();
                this.Close();
            }
        }
    }
}