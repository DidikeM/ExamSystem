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
    public partial class FrmStudentTimeIntervalChange : DevExpress.XtraEditors.XtraForm
    {
        private Student _student;
        private TimeInterval _timeInterval;
        private ITimeIntervalService _timeIntervalService = InstanceFactory.GetInstance<ITimeIntervalService>();
        public FrmStudentTimeIntervalChange(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void FrmStudentTimeIntervalChange_Load(object sender, EventArgs e)//öğrencinin zaman aralıklarını ekrana yükler
        {
            _timeInterval = _timeIntervalService.GetById(_student.TimeIntervalID);
            txtInterval1.Text = _timeInterval.Interval1.ToString();
            txtInterval2.Text = _timeInterval.Interval2.ToString();
            txtInterval3.Text = _timeInterval.Interval3.ToString();
            txtInterval4.Text = _timeInterval.Interval4.ToString();
            txtInterval5.Text = _timeInterval.Interval5.ToString();
            txtInterval6.Text = _timeInterval.Interval6.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)//öğrencinin yazdığı zaman aralığını sisteme kaydeder
        {
            _timeInterval.Interval1 = Convert.ToInt32(txtInterval1.Text);
            _timeInterval.Interval2 = Convert.ToInt32(txtInterval2.Text);
            _timeInterval.Interval3 = Convert.ToInt32(txtInterval3.Text);
            _timeInterval.Interval4 = Convert.ToInt32(txtInterval4.Text);
            _timeInterval.Interval5 = Convert.ToInt32(txtInterval5.Text);
            _timeInterval.Interval6 = Convert.ToInt32(txtInterval6.Text);
            if (_timeInterval.ID == 1)
            {
                _timeIntervalService.Add(_timeInterval);
            }
            else
            {
                _timeIntervalService.Update(_timeInterval);
            }
            MessageBox.Show("Zaman aralıkları başarıyla değiştirildi.");
            this.Close();
        }
    }
}