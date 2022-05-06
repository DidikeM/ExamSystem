using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.Concrete;
using ExamSystem.DataAccess.Concrete.EntityFramework;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _lectureService = new LectureManager(new EfLectureDal());
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
            richEditControl1.SaveDocument("1.rtf", DocumentFormat.Rtf);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            richEditControl1.LoadDocument("1.rtf", DocumentFormat.Rtf);
            richEditControl1.Enabled = false;
            richEditControl1.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _lectureService.GetAll();
        }
    }
}
