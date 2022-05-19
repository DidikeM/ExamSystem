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
    public partial class FrmStudentSectionSelect : DevExpress.XtraEditors.XtraForm
    {
        private IStudentStatisticsService _studentStatisticsService = InstanceFactory.GetInstance<IStudentStatisticsService>();
        private ISectionService _sectionService = InstanceFactory.GetInstance<ISectionService>();
        private IUnitService _unitService = InstanceFactory.GetInstance<IUnitService>();
        private ILectureService _lectureService = InstanceFactory.GetInstance<ILectureService>();

        private Student _student;
        private List<StudentStatistics> _studentStatisticsList;
        private List<Section> _sections = new List<Section>();
        private List<Unit> _units = new List<Unit>();
        private List<Lecture> _lectures = new List<Lecture>();

        public FrmStudentSectionSelect(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void FrmStudentSectionExam_Load(object sender, EventArgs e)
        {
            GetSection();
            LoadLecture();
        }

        private void GetSection()
        {
            _studentStatisticsList = _studentStatisticsService.GetByStudentId(_student.ID);
            foreach (var studentStatistics in _studentStatisticsList)
            {
                if (!(studentStatistics.TrueCount / studentStatistics.FalseCount > 1))
                {
                    Section section = _sectionService.GetById(studentStatistics.SectionID);
                    if (!(_sections.Any(p => p.ID == section.ID)))
                    {
                        _sections.Add(section);
                    }
                }
            }

            foreach (var section in _sections)
            {
                Unit unit = _unitService.GetById(section.UnitID);
                if (!(_units.Any(p => p.ID == unit.ID)))
                {
                    _units.Add(unit);
                }
            }

            foreach (var unit in _units)
            {
                Lecture lecture = _lectureService.GetById(unit.LectureID);
                if (!(_lectures.Any(p => p.ID == lecture.ID)))
                {
                    _lectures.Add(lecture);
                }
            }
        }

        private void lueLecture_Properties_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (lueLecture.GetSelectedDataRow() != null)
            {
                LoadUnit();
            }
        }

        private void lueUnit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (lueUnit.GetSelectedDataRow() != null)
            {
                LoadSection();
            }
        }

        private void LoadLecture()
        {
            lueLecture.Properties.DataSource = _lectures;
        }

        private void LoadUnit()
        {
            lueUnit.Properties.DataSource = _units.Where(p => p.LectureID == ((Lecture)lueLecture.GetSelectedDataRow()).ID);
        }

        private void LoadSection()
        {
            lueSection.Properties.DataSource = _sections.Where(p => p.UnitID == ((Unit)lueUnit.GetSelectedDataRow()).ID);
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            if (lueSection.GetSelectedDataRow() != null)
            {
                FrmStudentSectionExam frmStudentSectionExam = new FrmStudentSectionExam(((Section)lueSection.GetSelectedDataRow()));
                MdiParent.Hide();
                frmStudentSectionExam.ShowDialog();
                MdiParent.Show();
            }
        }
    }
}