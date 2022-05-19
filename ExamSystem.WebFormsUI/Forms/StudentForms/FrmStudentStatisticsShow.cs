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
    public partial class FrmStudentStatisticsShow : DevExpress.XtraEditors.XtraForm
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

        public FrmStudentStatisticsShow(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void FrmStudentStatisticsShow_Load(object sender, EventArgs e)
        {
            _studentStatisticsList = _studentStatisticsService.GetByStudentId(_student.ID);//konu istatistiklerini Databaseden çeker
            foreach (var studentStatistics in _studentStatisticsList)//çekilen istatisliklerin olduğu konuları listeler
            {
                Section section = _sectionService.GetById(studentStatistics.SectionID);

                if (!(_sections.Any(p => p.ID == section.ID)))
                {
                    _sections.Add(section);
                }
            }

            foreach (var section in _sections)//konuların olduğu üniteleri listeler
            {
                Unit unit = _unitService.GetById(section.UnitID);
                if (!(_units.Any(p => p.ID == unit.ID)))
                {
                    _units.Add(unit);
                }
            }

            foreach (var unit in _units)//ünitelerin olduğu dersleri listeler
            {
                Lecture lecture = _lectureService.GetById(unit.LectureID);
                if (!(_lectures.Any(p => p.ID == lecture.ID)))
                {
                    _lectures.Add(lecture);
                }
            }

            string str = "";
            foreach (var lecture in _lectures)// analız stringini oluşturur
            {
                str += lecture.Name + " Dersinden;\n";
                foreach (var unit in _units)
                {
                    if (unit.LectureID == lecture.ID)
                    {
                        str += "\t" + unit.Name + " Ünitesinden;\n";
                        foreach (var section in _sections)
                        {
                            if (section.UnitID == unit.ID)
                            {
                                StudentStatistics studentStatistics = _studentStatisticsList.First(p => p.SectionID == section.ID);
                                str += "\t\t" + section.Name + " Konusundan: ";
                                int t = studentStatistics.TrueCount;
                                int f = studentStatistics.FalseCount;
                                str += t  + " Doğrunuz " + f + " Yanlışınız var %" + ((100 * t)/(t+f)) + " başarılısınız;" + "\n";
                            }
                        }
                    }
                }
            }
            rtbStatistics.Text = str;
        }

        private void btnSave_Click(object sender, EventArgs e)//raporu  bilgisayara kaydeder
        {
            sfdSaveStatistics.ShowDialog();
            rtbStatistics.SaveFile(sfdSaveStatistics.FileName+".rtf");
            MessageBox.Show("Rapor başarıyla kaydedildi.");
        }
    }
}