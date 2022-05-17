using System;
using System.Windows.Forms;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;
using ExamSystem.Entities.Concrete;
using ExamSystem.WebFormsUI.Forms;
using ExamSystem.WebFormsUI.Forms.ExaminerForms;

namespace ExamSystem.WebFormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmExaminerQuestionAdd());
            Application.Run(new FrmQuestionView(6));
        }

    }
}
