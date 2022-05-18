using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.WebFormsUI.Forms.ExaminerForms
{
    public partial class FrmExaminerQuestionAdd : DevExpress.XtraEditors.XtraForm
    {
        private ILectureService _lectureService = InstanceFactory.GetInstance<ILectureService>();
        private IUnitService _unitService = InstanceFactory.GetInstance<IUnitService>();
        private ISectionService _sectionService = InstanceFactory.GetInstance<ISectionService>();
        private IChoiceFormatService _choiceFormatService = InstanceFactory.GetInstance<IChoiceFormatService>();
        private IQuestionService _questionService = InstanceFactory.GetInstance<IQuestionService>();
        private IChoiceService _choiceService = InstanceFactory.GetInstance<IChoiceService>();
        private int _ChoiceFlag = -1;

        public FrmExaminerQuestionAdd()
        {
            InitializeComponent();
        }

        private void rtbQuestion_PopupMenuShowing(object sender, DevExpress.XtraRichEdit.PopupMenuShowingEventArgs e)
        {
            e.Menu.RemoveMenuItem(RichEditCommandId.CreateHyperlink);
            e.Menu.RemoveMenuItem(RichEditCommandId.CreateBookmark);
            e.Menu.RemoveMenuItem(RichEditCommandId.NewCommentContentMenu);
        }

        private void FrmExaminerQuestionAdd_Load(object sender, EventArgs e)
        {
            lueLecture.Properties.DataSource = _lectureService.GetAll();
            lueChoiceFormat.Properties.DataSource = _choiceFormatService.GetAll();
        }

        private void lueLecture_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                lueUnit.Properties.DataSource = _unitService.GetByLectureId(((Lecture)lueLecture.GetSelectedDataRow()).ID);
            }
        }

        private void lueUnit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                lueSection.Properties.DataSource = _sectionService.GetByUnitId(((Unit)lueUnit.GetSelectedDataRow()).ID);
            }
        }

        private void lueChoiceFormat_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                if (((ChoiceFormat)lueChoiceFormat.GetSelectedDataRow()).ID == 2)
                {
                    tbpChoices.Columns[1].Width = 0;
                    tbpChoices.Columns[2].Width = 50;
                }
                else
                {
                    tbpChoices.Columns[1].Width = 50;
                    tbpChoices.Columns[2].Width = 0;
                }
            }
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (lueSection.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Lütfen sorunun ekleneceği konuyu seçiniz!");
                return;
            }

            if (lueChoiceFormat.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Lütfen Şık tipini seçiniz!");
                return;
            }

            if ((((ChoiceFormat)lueChoiceFormat.GetSelectedDataRow()).ID == 2) && (imgChoiceA.Image == null || imgChoiceB.Image == null || imgChoiceC.Image == null || imgChoiceD.Image == null))
            {
                MessageBox.Show("Lütfen bütün resimleri ekleyiniz!");
                return;
            }

            if ((((ChoiceFormat)lueChoiceFormat.GetSelectedDataRow()).ID != 2) && (txtChoiceA.Text == " " || txtChoiceB.Text == " " || txtChoiceC.Text == " " || txtChoiceD.Text == " "))
            {
                MessageBox.Show("Lütfen bütün şıkları doldurunuz!");
                return;
            }

            if (_ChoiceFlag == -1)
            {
                MessageBox.Show("Lütfen cevabı işaretleyiniz!");
                return;
            }

            SaveQuestionDatabase();
            ClearTextes();
        }

        private void ClearTextes()
        {
            _ChoiceFlag = -1;
            ClearChoicesColor();
            txtChoiceA.Text = " ";
            txtChoiceB.Text = " ";
            txtChoiceC.Text = " ";
            txtChoiceD.Text = " ";
            imgChoiceA.Image = null;
            imgChoiceB.Image = null;
            imgChoiceB.Image = null;
            imgChoiceB.Image = null;
            rtbQuestion.Text = "";
        }

        private void SaveQuestionDatabase()
        {
            Question question = new Question()
            {
                ChoiceCount = 4,
                ChoiceFormatID = ((ChoiceFormat)lueChoiceFormat.GetSelectedDataRow()).ID,
                SectionID = ((Section)lueSection.GetSelectedDataRow()).ID,
                TableText = " ",
                CorrectAnswer = 1
            };
            _questionService.Add(question);
            rtbQuestion.SaveDocument(Environment.ExpandEnvironmentVariables("%userprofile%\\ExamSystem\\Questions\\" + question.ID + ".rtf"), DocumentFormat.Rtf);
            question.FilePath = "%userprofile%\\ExamSystem\\Questions\\" + question.ID + ".rtf";

            List<Choice> choices = new List<Choice>()
            {
                new Choice()
                {
                    QuestionID = question.ID,
                    Text = txtChoiceA.Text
                },
                new Choice()
                {
                    QuestionID = question.ID,
                    Text = txtChoiceB.Text
                },
                new Choice()
                {
                    QuestionID = question.ID,
                    Text = txtChoiceC.Text
                },
                new Choice()
                {
                    QuestionID = question.ID,
                    Text = txtChoiceD.Text
                }
            };

            foreach (var choice in choices)
            {
                _choiceService.Add(choice);
            }

            if (((ChoiceFormat)lueChoiceFormat.GetSelectedDataRow()).ID == 2)
            {
                imgChoiceA.Image.Save(Environment.ExpandEnvironmentVariables("%userprofile%\\ExamSystem\\Choices\\" + choices[0].ID + ".jpg"), ImageFormat.Jpeg);
                imgChoiceB.Image.Save(Environment.ExpandEnvironmentVariables("%userprofile%\\ExamSystem\\Choices\\" + choices[1].ID + ".jpg"), ImageFormat.Jpeg);
                imgChoiceC.Image.Save(Environment.ExpandEnvironmentVariables("%userprofile%\\ExamSystem\\Choices\\" + choices[2].ID + ".jpg"), ImageFormat.Jpeg);
                imgChoiceD.Image.Save(Environment.ExpandEnvironmentVariables("%userprofile%\\ExamSystem\\Choices\\" + choices[3].ID + ".jpg"), ImageFormat.Jpeg);

                for (int i = 0; i < 4; i++)
                {
                    choices[i].Text = "%userprofile%\\ExamSystem\\Choices\\" + choices[i].ID + ".jpg";
                    _choiceService.Update(choices[i]);
                }
            }
            else
            {
                choices[0].Text = txtChoiceA.Text;
                choices[1].Text = txtChoiceB.Text;
                choices[2].Text = txtChoiceC.Text;
                choices[3].Text = txtChoiceD.Text;
                for (int i = 0; i < 4; i++)
                {
                    _choiceService.Update(choices[i]);
                }
            }
            question.CorrectAnswer = choices[_ChoiceFlag].ID;
            _questionService.Update(question);
        }

        private void lblChoiceA_Click(object sender, EventArgs e)
        {
            ClearChoicesColor();
            lblChoiceA.BackColor = Color.Aquamarine;
            _ChoiceFlag = 0;
        }

        private void lblChoiceB_Click(object sender, EventArgs e)
        {
            ClearChoicesColor();
            lblChoiceB.BackColor = Color.Aquamarine;
            _ChoiceFlag = 1;
        }

        private void lblChoiceC_Click(object sender, EventArgs e)
        {
            ClearChoicesColor();
            lblChoiceC.BackColor = Color.Aquamarine;
            _ChoiceFlag = 2;
        }

        private void lblChoiceD_Click(object sender, EventArgs e)
        {
            ClearChoicesColor();
            lblChoiceD.BackColor = Color.Aquamarine;
            _ChoiceFlag = 3;
        }

        private void ClearChoicesColor()
        {
            lblChoiceA.BackColor = Color.Transparent;
            lblChoiceB.BackColor = Color.Transparent;
            lblChoiceC.BackColor = Color.Transparent;
            lblChoiceD.BackColor = Color.Transparent;
        }
    }
}