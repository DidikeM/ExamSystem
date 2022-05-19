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
using ExamSystem.Entities.Concrete;

namespace ExamSystem.WebFormsUI.Forms.ExaminerForms
{
    public partial class FrmExaminerMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmExaminerMain(User user)
        {
            InitializeComponent();
        }

        private void FrmExaminerMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barBtnSectionAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseChild();
            FrmExaminerSectionAdd frmExaminerSectionAdd = new FrmExaminerSectionAdd();
            frmExaminerSectionAdd.MdiParent = this;
            frmExaminerSectionAdd.Show();
        }

        private void barBtnQuestionAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseChild();
            FrmExaminerQuestionAdd frmExaminerQuestionAdd = new FrmExaminerQuestionAdd();
            frmExaminerQuestionAdd.MdiParent = this;
            frmExaminerQuestionAdd.Show();
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