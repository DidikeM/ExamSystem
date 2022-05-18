using System;
using System.Windows.Forms;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;
using ExamSystem.Entities.Concrete;
using ExamSystem.WebFormsUI.Forms;
using ExamSystem.WebFormsUI.Forms.ExaminerForms;
using ExamSystem.WebFormsUI.Forms.StudentForms;

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
            //Application.Run(new FrmQuestionView(6));
            //Application.Run(new FrmExaminerSectionAdd());
            //Application.Run((new FrmStudentExam()));
        }

    }
}
