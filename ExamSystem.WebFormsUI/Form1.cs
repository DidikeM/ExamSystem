using System;
using System.Windows.Forms;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.Concrete;
using ExamSystem.DataAccess.Concrete.EntityFramework;

namespace ExamSystem.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _lectureService = new LectureManager(new EfLectureDal());
            InitializeComponent();
        }

        private ILectureService _lectureService;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _lectureService.GetAll();
        }
    }
}
