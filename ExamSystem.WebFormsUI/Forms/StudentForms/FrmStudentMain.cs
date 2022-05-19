using DevExpress.XtraBars;
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
    public partial class FrmStudentMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
        private Student _student;
        public FrmStudentMain(User user)
        {
            _student = _studentService.GetByUserId(user.ID);
            InitializeComponent();
        }

        private void FrmStudentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barBtnExamStart_ItemClick(object sender, ItemClickEventArgs e)//Buttona tıklandığında bu formu gizler gerekli formu açar
        {
            FrmStudentExam frmStudentExam = new FrmStudentExam(_student);
            this.Hide();
            frmStudentExam.ShowDialog();
            this.Show();
        }

        private void barBtnChangeTimeInterval_ItemClick(object sender, ItemClickEventArgs e)//Buttona tıklandığında gerekli formu çocuk form olarak açar
        {
            CloseChild();
            FrmStudentTimeIntervalChange frmStudentTimeIntervalChange = new FrmStudentTimeIntervalChange(_student);
            frmStudentTimeIntervalChange.MdiParent = this;
            frmStudentTimeIntervalChange.Show();
        }

        private void barBtnShowStatistics_ItemClick(object sender, ItemClickEventArgs e)//Buttona tıklandığında gerekli formu çocuk form olarak açar
        {
            CloseChild();
            FrmStudentStatisticsShow frmStudentStatisticsShow = new FrmStudentStatisticsShow(_student);
            frmStudentStatisticsShow.MdiParent = this;
            frmStudentStatisticsShow.Show();
        }

        private void barBtnSectionExam_ItemClick(object sender, ItemClickEventArgs e)//Buttona tıklandığında gerekli formu çocuk form olarak açar
        {
            CloseChild();
            FrmStudentSectionSelect frmStudentSectionExam = new FrmStudentSectionSelect(_student);
            frmStudentSectionExam.MdiParent= this;
            frmStudentSectionExam.Show();
        }

        private void CloseChild()
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
        }
    }
}