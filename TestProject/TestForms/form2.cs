using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;

namespace TestProject.TestForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            _lectureService = InstanceFactory.GetInstance<ILectureService>();
            InitializeComponent();
        }

        private ILectureService _lectureService;
        private void richEditControl1_PopupMenuShowing(object sender, DevExpress.XtraRichEdit.PopupMenuShowingEventArgs e)
        {
            e.Menu.RemoveMenuItem(RichEditCommandId.CreateHyperlink);
            e.Menu.RemoveMenuItem(RichEditCommandId.CreateBookmark);
            e.Menu.RemoveMenuItem(RichEditCommandId.NewCommentContentMenu);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            richEditControl1.SaveDocument("..\\..\\Questions\\1.rtf", DocumentFormat.Rtf);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("..\\..\\Questions\\1.rtf");
            richTextBox1.BackColor = Color.Red;
            richTextBox1.Enabled = false;
            richTextBox1.BackColor = Color.Red;
            //richEditControl1.LoadDocument();
            //richEditControl1.Enabled = false;
            //richEditControl1.BackColor = Color.Transparent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _lectureService.GetAll();
        }

        private void richTextBox1_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XtraForm1 xtraForm1 = new XtraForm1();
            xtraForm1.ShowDialog();
        }
    }
}
