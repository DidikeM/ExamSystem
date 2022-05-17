using System;
using System.Windows.Forms;
using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.WebFormsUI.Forms
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private IUserService _userService = InstanceFactory.GetInstance<IUserService>();
        private IUserTypeService _userTypeService = InstanceFactory.GetInstance<IUserTypeService>();
        private IExaminerService _examinerService = InstanceFactory.GetInstance<IExaminerService>();
        private IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadUserTypes();
        }

        private void btnShowRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlLogin.Visible = false;
        }

        private void btnShowLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlRegister.Visible = false;
        }

        private void LoadUserTypes()
        {
            lueRegisterUserType.Properties.DataSource = _userTypeService.GetNotAdminType();
            lueRegisterUserType.Properties.DisplayMember = "Name";
            lueRegisterUserType.Properties.ValueMember = "ID";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterSurname.Text == "" || txtRegisterUsername.Text == "" || txtRegisterEmail.Text == "" || txtRegisterName.Text == "" || txtRegisterPassword.Text == "" || lueRegisterUserType.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Lütfen Bütün Alanları doldurunuz.");
            }
            else
            {
                User user = new User()
                {
                    EMail = txtRegisterEmail.Text,
                    Name = txtRegisterName.Text,
                    Surname = txtRegisterSurname.Text,
                    Password = txtRegisterPassword.Text,
                    Username = txtRegisterUsername.Text,
                    UserTypeID = ((UserType)lueRegisterUserType.GetSelectedDataRow()).ID
                };
                if (_userService.CheckUserRegister(user))
                {
                    _userService.Add(user);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz E-Mail veya kullanıcı adı zaten kullanılmaktadır.");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtLoginUsername.Text == "" || txtLoginPassword.Text == "")
            {
                MessageBox.Show("Lütfen Bütün Alanları doldurunuz.");
            }
            else
            {
                User user = _userService.GetByUsernamePassword(new User() { Username = txtLoginUsername.Text, Password = txtLoginPassword.Text });
                if (user == null)
                {
                    MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz!");
                }
                else
                {
                    switch (user.UserTypeID)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                    }
                }
            }
        }
    }
}