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

namespace TestProject.TestForms
{
    public partial class UcQuestionView : DevExpress.XtraEditors.XtraUserControl
    {
        private IQuestionService _questionService = InstanceFactory.GetInstance<IQuestionService>();
        private IChoiceService _choiceService = InstanceFactory.GetInstance<IChoiceService>();
        private ISectionService _sectionService = InstanceFactory.GetInstance<ISectionService>();
        private IUnitService _unitService = InstanceFactory.GetInstance<IUnitService>();
        private ILectureService _lectureService = InstanceFactory.GetInstance<ILectureService>();
        private Question _question;
        public UcQuestionView()
        {
            InitializeComponent();
        }

        private void UcQuestionView_Load(object sender, EventArgs e)
        {
            LoadQuestion();
            LoadTitle();
        }

        private void LoadTitle()
        {
            Section section = _sectionService.GetById(_question.SectionID);
            lblSectionNumberValue.Text = section.Number.ToString();
            lblSectionNameValue.Text = section.Name;
            Unit unit = _unitService.GetById(section.UnitID);
            lblUnitNumberValue.Text = unit.Number.ToString();
            lblUnitNameValue.Text = unit.Name;
            Lecture lecture = _lectureService.GetById(unit.LectureID);
            lblgradeNumberValue.Text = lecture.GradeNumber.ToString();
            lblLectureNameValue.Text = lecture.Name;

        }

        private void LoadQuestion()
        {
            _question = _questionService.GetById(3);
            recQuestion.LoadDocument(_question.FilePath);
        }

        private void tbMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ckeChoice3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckeChoice4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckeChoice1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckeChoice2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
