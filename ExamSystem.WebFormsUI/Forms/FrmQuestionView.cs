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
using ExamSystem.Entities.Concrete;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;

namespace ExamSystem.WebFormsUI.Forms
{
    public partial class FrmQuestionView : DevExpress.XtraEditors.XtraForm
    {

        private ISectionService _sectionService = InstanceFactory.GetInstance<ISectionService>();
        private IUnitService _unitService = InstanceFactory.GetInstance<IUnitService>();
        private ILectureService _lectureService = InstanceFactory.GetInstance<ILectureService>();
        private IChoiceService _choiceService = InstanceFactory.GetInstance<IChoiceService>();
        private IQuestionService _questionService = InstanceFactory.GetInstance<IQuestionService>();

        private int _flagChoice = -1;
        private Question _question;
        private List<Choice> _choices;

        public Choice SelectedChoice { get; private set; }

        public FrmQuestionView(Question question /*int questionId*/)
        {
            _question = question;
            _choices = _choiceService.GetByQuestionId(_question.ID);
            InitializeComponent();
        }

        private void FrmQuestionView_Load(object sender, EventArgs e)
        {
            LoadQuestion();
            LoadTitle();
            LoadChoices();
        }

        private void LoadQuestion()//gelen sorunun metnini ekrana açar
        {
            rtbQuestion.LoadDocument(Environment.ExpandEnvironmentVariables(_question.FilePath));
        }

        private void LoadTitle()// gelen sorunun başlığını oluşturur
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

        private void LoadChoices()// şıkları türüne göre ekrana yazar
        {
            if (_question.ChoiceFormatID == 1 || _question.ChoiceFormatID == 3)
            {
                lblChoiceA.Text += _choices[0].Text;
                lblChoiceB.Text += _choices[1].Text;
                lblChoiceC.Text += _choices[2].Text;
                lblChoiceD.Text += _choices[3].Text;
            }
            else if (_question.ChoiceFormatID == 2)
            {
                picChoiceA.Image = Image.FromFile(Environment.ExpandEnvironmentVariables(_choices[0].Text));
                picChoiceB.Image = Image.FromFile(Environment.ExpandEnvironmentVariables(_choices[1].Text));
                picChoiceC.Image = Image.FromFile(Environment.ExpandEnvironmentVariables(_choices[2].Text));
                picChoiceD.Image = Image.FromFile(Environment.ExpandEnvironmentVariables(_choices[3].Text));
            }
        }

        private void ChoiceA_Click(object sender, EventArgs e)//a şıkkını seçer
        {
            ClearChoicesColor();
            lblChoiceA.BackColor = Color.Aquamarine;
            _flagChoice = 0;
            SelectedChoice = _choices[_flagChoice];
        }

        private void ChoiceB_Click(object sender, EventArgs e)//b şıkkını seçer
        {
            ClearChoicesColor();
            lblChoiceB.BackColor = Color.Aquamarine;
            _flagChoice = 1;
            SelectedChoice = _choices[_flagChoice];
        }

        private void ChoiceC_Click(object sender, EventArgs e)//c şıkkını seçer
        {
            ClearChoicesColor();
            lblChoiceC.BackColor = Color.Aquamarine;
            _flagChoice = 2;
            SelectedChoice = _choices[_flagChoice];
        }

        private void ChoiceD_Click(object sender, EventArgs e)//d şıkkını seçer
        {
            ClearChoicesColor();
            lblChoiceD.BackColor = Color.Aquamarine;
            _flagChoice = 3;
            SelectedChoice = _choices[_flagChoice];
        }

        private void ClearChoicesColor()// şıkları temizler
        {
            lblChoiceA.BackColor = Color.Transparent;
            lblChoiceB.BackColor = Color.Transparent;
            lblChoiceC.BackColor = Color.Transparent;
            lblChoiceD.BackColor = Color.Transparent;
        }
    }
}