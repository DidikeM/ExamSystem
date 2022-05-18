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

        private FrmQuestionView _frmQuestionView;
        private readonly Student _student;
        private readonly List<StudentStatus> _studentStatusList;
        private readonly List<Question> _examQuestions = new List<Question>();
        private int _questionCounter = 0;

        public FrmStudentExam(Student student)
        {
            _student = student;
            _studentStatusList = _studentStatusService.GetByStudentId(student.ID);
            InitializeComponent();
        }

        private TimeSpan _examTimeSpan;

        private void FrmStudentExam_Load(object sender, EventArgs e)
        {

            GetSigmaQuestions();
            GetRandomQuestions(10);
            //_examQuestions = _questionService.GetAll();
            OpenQuestion();
            TimerStart();
        }

        private void GetRandomQuestions(int count)
        {
            List<int> questionIds = _questionService.GetAllIds();
            //_questionIds = _questionIds.Where(p => !(_examQuestions.Any(q => q.ID == p))).ToList();
            questionIds = questionIds.Where(p => !(_studentStatusList.Any(q => q.QuestionID == p && q.Status != 0))).ToList();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(0, questionIds.Count - 1);
                _examQuestions.Add(_questionService.GetById(questionIds[x]));
                questionIds.RemoveAt(x);
            }
        }

        private void GetSigmaQuestions()
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
                if (studentStatus.Status > 0&&(DateTime.Today - studentStatus.FirstTime) >= TimeSpan.FromDays(Convert.ToDouble(intervals[studentStatus.Status - 1])))
                {
                    _examQuestions.Add(_questionService.GetById(studentStatus.QuestionID));
                }
            }
        }

        private void OpenQuestion()
        {
            CloseQuestion();
            _frmQuestionView = new FrmQuestionView(_examQuestions[_questionCounter++]);
            _frmQuestionView.MdiParent = this;
            _frmQuestionView.Show();
            lblQuestionNumber.Text = "Soru: " + _questionCounter + "/" + _examQuestions.Count;
        }

        private void CloseQuestion()
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
        }

        private void TimerStart()
        {
            _examTimeSpan = new TimeSpan(0, _examQuestions.Count, 0);
            timerExam.Start();
        }

        private void timerExam_Tick(object sender, EventArgs e)
        {
            _examTimeSpan -= TimeSpan.FromSeconds(1);
            lblCounter.Text = _examTimeSpan.ToString();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (_frmQuestionView.SelectedChoice== null)
            {
                MessageBox.Show("Lütfen bir şık işaretleyiniz");
                return;
            }
            StudentStatus studentStatus = _studentStatusService.GetByStudentIdAndQuestionId(_student.ID, _examQuestions[_questionCounter - 1].ID);
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

            if (_frmQuestionView.SelectedChoice.ID == _examQuestions[_questionCounter - 1].CorrectAnswer)
            {
                if (studentStatus.Status == 0)
                {
                    studentStatus.FirstTime = DateTime.Today;
                }
                studentStatus.Status++;
            }
            else
            {
                studentStatus.Status = 0;
            }
            _studentStatusService.Update(studentStatus);

            if (_questionCounter < _examQuestions.Count)
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