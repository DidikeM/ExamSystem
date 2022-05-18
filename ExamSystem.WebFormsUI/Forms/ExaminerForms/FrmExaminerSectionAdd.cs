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

namespace ExamSystem.WebFormsUI.Forms.ExaminerForms
{
    public partial class FrmExaminerSectionAdd : DevExpress.XtraEditors.XtraForm
    {
        private ILectureService _lectureService = InstanceFactory.GetInstance<ILectureService>();
        private IUnitService _unitService = InstanceFactory.GetInstance<IUnitService>();
        private ISectionService _sectionService = InstanceFactory.GetInstance<ISectionService>();
        public FrmExaminerSectionAdd()
        {
            InitializeComponent();
        }

        private void FrmExaminerSectionAdd_Load(object sender, EventArgs e)
        {
            LoadLecture();
        }

        private void lueLecture_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                LoadUnit();
            }
        }

        private void lueUnit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal)
            {
                LoadSection();
            }
        }

        private void LoadSection()
        {
            lueSection.Properties.DataSource = _sectionService.GetByUnitId(((Unit)lueUnit.GetSelectedDataRow()).ID);
        }

        private void LoadLecture()
        {
            lueLecture.Properties.DataSource = _lectureService.GetAll();
        }

        private void LoadUnit()
        {
            lueUnit.Properties.DataSource = _unitService.GetByLectureId(((Lecture)lueLecture.GetSelectedDataRow()).ID);
        }

        private void btnLectureAdd_Click(object sender, EventArgs e)
        {
            if (txtEditGradeNumber.Text == "" || txtEditLectureName.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!");
            }
            else
            {

                _lectureService.Add(new Lecture()
                {
                    GradeNumber = Convert.ToInt32(txtEditGradeNumber.Text),
                    Name = txtEditLectureName.Text
                });
                LoadLecture();
                ClearValues();
            }
        }

        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            if (lueLecture.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Lütfen önce ders seçiniz!");
            }
            else
            {
                if (txtEditUnitName.Text == "" || txtEditUnitNumber.Text == "")
                {
                    MessageBox.Show("Lütfen ilgili alanları doldurunuz");
                }
                else
                {
                    _unitService.Add(new Unit()
                    {
                        LectureID = ((Lecture)lueLecture.GetSelectedDataRow()).ID,
                        Name = txtEditUnitName.Text,
                        Number = Convert.ToInt32(txtEditUnitNumber.Text)
                    });
                    LoadUnit();
                    ClearValues();
                }
            }
        }

        private void btnSectionAdd_Click(object sender, EventArgs e)
        {
            if (lueUnit.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Lütfen önce ünite seçiniz!");
            }
            else
            {
                if (txtEditSectionName.Text == "" || txtEditSectionNumber.Text == "")
                {
                    MessageBox.Show("Lütfen ilgili alanları doldurunuz");
                }
                else
                {
                    _sectionService.Add(new Section()
                    {
                        UnitID = ((Unit)lueUnit.GetSelectedDataRow()).ID,
                        Name = txtEditSectionName.Text,
                        Number = Convert.ToInt32(txtEditSectionNumber.Text)
                    });
                    LoadSection();
                    ClearValues();
                }
            }
        }

        private void ClearValues()
        {
            txtEditLectureName.Text = "";
            txtEditUnitNumber.Text = "";
            txtEditUnitName.Text = "";
            txtEditSectionNumber.Text = "";
            txtEditSectionName.Text = "";
        }
    }
}