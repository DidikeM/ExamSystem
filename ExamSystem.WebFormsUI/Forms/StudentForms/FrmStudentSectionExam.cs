using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.WebFormsUI.Forms.StudentForms
{
    public partial class FrmStudentSectionExam : DevExpress.XtraEditors.XtraForm
    {
        private IQuestionService _questionService = InstanceFactory.GetInstance<IQuestionService>();

        private FrmQuestionView _frmQuestionView;
        private List<Question> _questions;
        private List<Question> _examQuestions = new List<Question>();
        private Section _section;
        private int _questionCounter = 0;
        private int _true = 0;
        private int _false = 0;

        public FrmStudentSectionExam(Section section)
        {
            _section = section;
            InitializeComponent();
        }

        private void FrmStudentSectionExam_Load(object sender, EventArgs e)
        {
            _questions = _questionService.GetBySectionId(_section.ID);
            GetRandomQuestions(5);
            OpenQuestion();
        }

        private void GetRandomQuestions(int count) //Seçilen eksik konudan count kadar soruyu sınava ekler
        {

            if (_questions.Count < count)
            {
                count = _questions.Count;
            }
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(0, _questions.Count - 1);
                _examQuestions.Add(_questions[x]);
                _questions.RemoveAt(x);
            }
        }

        private void OpenQuestion() //sıradaki soruyu ekrana getirir
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

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (_frmQuestionView.SelectedChoice == null)
            {
                MessageBox.Show("Lütfen bir şık işaretleyiniz");
                return;
            }

            if (_frmQuestionView.SelectedChoice.ID == _examQuestions[_questionCounter - 1].CorrectAnswer)
            {
                _true++;// işaretlenen şık doğruysa doğru sayısını arttırır
            }
            else
            {
                _false++;// işaretlenen şık yanlışsa yanlış sayısını arttırır
            }

            if (_questionCounter < _examQuestions.Count)//sınav bitmemişse sıradaki soruyu açar
            {
                OpenQuestion();
            }
            else//sınav bitmişse formu kapatır
            {
                CloseQuestion();
                this.Close();
                MessageBox.Show(_true + " doğrunuz, " + _false + " tane yanlışınız var.");
            }
        }
    }
}