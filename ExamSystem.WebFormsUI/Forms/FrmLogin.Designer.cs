
namespace ExamSystem.WebFormsUI.Forms
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlRegister = new DevExpress.XtraEditors.PanelControl();
            this.btnShowLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lueRegisterUserType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.txtRegisterEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblRegisterEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtRegisterSurname = new DevExpress.XtraEditors.TextEdit();
            this.lblregisterSurname = new DevExpress.XtraEditors.LabelControl();
            this.txtRegisterName = new DevExpress.XtraEditors.TextEdit();
            this.lblRegisterName = new DevExpress.XtraEditors.LabelControl();
            this.lblRegisterUserType = new DevExpress.XtraEditors.LabelControl();
            this.txtRegisterPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblRegisterPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtRegisterUsername = new DevExpress.XtraEditors.TextEdit();
            this.lblRegisterUsername = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoginUsername = new DevExpress.XtraEditors.LabelControl();
            this.txtLoginUsername = new DevExpress.XtraEditors.TextEdit();
            this.lblLoginPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtLoginPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowRegister = new DevExpress.XtraEditors.SimpleButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlLogin = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRegister)).BeginInit();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueRegisterUserType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btnShowLogin);
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Controls.Add(this.lueRegisterUserType);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.txtRegisterEmail);
            this.pnlRegister.Controls.Add(this.lblRegisterEmail);
            this.pnlRegister.Controls.Add(this.txtRegisterSurname);
            this.pnlRegister.Controls.Add(this.lblregisterSurname);
            this.pnlRegister.Controls.Add(this.txtRegisterName);
            this.pnlRegister.Controls.Add(this.lblRegisterName);
            this.pnlRegister.Controls.Add(this.lblRegisterUserType);
            this.pnlRegister.Controls.Add(this.txtRegisterPassword);
            this.pnlRegister.Controls.Add(this.lblRegisterPassword);
            this.pnlRegister.Controls.Add(this.txtRegisterUsername);
            this.pnlRegister.Controls.Add(this.lblRegisterUsername);
            this.pnlRegister.Location = new System.Drawing.Point(30, 35);
            this.pnlRegister.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlRegister.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(300, 400);
            this.pnlRegister.TabIndex = 1;
            this.pnlRegister.Visible = false;
            // 
            // btnShowLogin
            // 
            this.btnShowLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnShowLogin.Appearance.Options.UseBackColor = true;
            this.btnShowLogin.Location = new System.Drawing.Point(133, 332);
            this.btnShowLogin.Name = "btnShowLogin";
            this.btnShowLogin.Size = new System.Drawing.Size(120, 23);
            this.btnShowLogin.TabIndex = 15;
            this.btnShowLogin.Text = "Giriş Yap";
            this.btnShowLogin.Click += new System.EventHandler(this.btnShowLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblRegister.Location = new System.Drawing.Point(100, 15);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(86, 23);
            this.lblRegister.TabIndex = 14;
            this.lblRegister.Text = "Kayıt Ol";
            // 
            // lueRegisterUserType
            // 
            this.lueRegisterUserType.Location = new System.Drawing.Point(133, 63);
            this.lueRegisterUserType.Name = "lueRegisterUserType";
            this.lueRegisterUserType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRegisterUserType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kullanıcı tipi")});
            this.lueRegisterUserType.Properties.DisplayMember = "Name";
            this.lueRegisterUserType.Properties.DropDownRows = 2;
            this.lueRegisterUserType.Properties.NullText = "Lütfen Seçiniz";
            this.lueRegisterUserType.Properties.ValueMember = "ID";
            this.lueRegisterUserType.Size = new System.Drawing.Size(120, 22);
            this.lueRegisterUserType.TabIndex = 13;
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.Location = new System.Drawing.Point(133, 275);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 23);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Kayıt ol";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Location = new System.Drawing.Point(133, 220);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(120, 22);
            this.txtRegisterEmail.TabIndex = 11;
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.Location = new System.Drawing.Point(45, 224);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(24, 13);
            this.lblRegisterEmail.TabIndex = 10;
            this.lblRegisterEmail.Text = "Email";
            // 
            // txtRegisterSurname
            // 
            this.txtRegisterSurname.Location = new System.Drawing.Point(133, 192);
            this.txtRegisterSurname.Name = "txtRegisterSurname";
            this.txtRegisterSurname.Size = new System.Drawing.Size(120, 22);
            this.txtRegisterSurname.TabIndex = 9;
            // 
            // lblregisterSurname
            // 
            this.lblregisterSurname.Location = new System.Drawing.Point(45, 196);
            this.lblregisterSurname.Name = "lblregisterSurname";
            this.lblregisterSurname.Size = new System.Drawing.Size(35, 13);
            this.lblregisterSurname.TabIndex = 8;
            this.lblregisterSurname.Text = "Soyisim";
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.Location = new System.Drawing.Point(133, 164);
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(120, 22);
            this.txtRegisterName.TabIndex = 7;
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.Location = new System.Drawing.Point(45, 168);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(19, 13);
            this.lblRegisterName.TabIndex = 6;
            this.lblRegisterName.Text = "İsim";
            // 
            // lblRegisterUserType
            // 
            this.lblRegisterUserType.Location = new System.Drawing.Point(45, 72);
            this.lblRegisterUserType.Name = "lblRegisterUserType";
            this.lblRegisterUserType.Size = new System.Drawing.Size(60, 13);
            this.lblRegisterUserType.TabIndex = 4;
            this.lblRegisterUserType.Text = "Kullanıcı Tipi:";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(133, 130);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(120, 22);
            this.txtRegisterPassword.TabIndex = 3;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.Location = new System.Drawing.Point(45, 134);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(22, 13);
            this.lblRegisterPassword.TabIndex = 2;
            this.lblRegisterPassword.Text = "Şifre";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(133, 100);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(120, 22);
            this.txtRegisterUsername.TabIndex = 1;
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.Location = new System.Drawing.Point(45, 104);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(59, 13);
            this.lblRegisterUsername.TabIndex = 0;
            this.lblRegisterUsername.Text = "Kullanıcı Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.Location = new System.Drawing.Point(45, 87);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(59, 13);
            this.lblLoginUsername.TabIndex = 0;
            this.lblLoginUsername.Text = "Kullanıcı Adı:";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(133, 78);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(120, 22);
            this.txtLoginUsername.TabIndex = 1;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.Location = new System.Drawing.Point(45, 123);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(22, 13);
            this.lblLoginPassword.TabIndex = 2;
            this.lblLoginPassword.Text = "Şifre";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(133, 118);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(120, 22);
            this.txtLoginPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(81)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.Location = new System.Drawing.Point(133, 172);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnShowRegister
            // 
            this.btnShowRegister.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnShowRegister.Appearance.Options.UseBackColor = true;
            this.btnShowRegister.Location = new System.Drawing.Point(133, 236);
            this.btnShowRegister.Name = "btnShowRegister";
            this.btnShowRegister.Size = new System.Drawing.Size(120, 23);
            this.btnShowRegister.TabIndex = 4;
            this.btnShowRegister.Text = "Hesap Yarat";
            this.btnShowRegister.Click += new System.EventHandler(this.btnShowRegister_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(100, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(96, 23);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Giriş Yap";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.btnShowRegister);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.lblLoginPassword);
            this.pnlLogin.Controls.Add(this.txtLoginUsername);
            this.pnlLogin.Controls.Add(this.lblLoginUsername);
            this.pnlLogin.Location = new System.Drawing.Point(30, 35);
            this.pnlLogin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(300, 400);
            this.pnlLogin.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 468);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlRegister)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueRegisterUserType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnlRegister;
        private DevExpress.XtraEditors.TextEdit txtRegisterEmail;
        private DevExpress.XtraEditors.LabelControl lblRegisterEmail;
        private DevExpress.XtraEditors.TextEdit txtRegisterSurname;
        private DevExpress.XtraEditors.LabelControl lblregisterSurname;
        private DevExpress.XtraEditors.TextEdit txtRegisterName;
        private DevExpress.XtraEditors.LabelControl lblRegisterName;
        private DevExpress.XtraEditors.LabelControl lblRegisterUserType;
        private DevExpress.XtraEditors.TextEdit txtRegisterPassword;
        private DevExpress.XtraEditors.LabelControl lblRegisterPassword;
        private DevExpress.XtraEditors.TextEdit txtRegisterUsername;
        private DevExpress.XtraEditors.LabelControl lblRegisterUsername;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.LookUpEdit lueRegisterUserType;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnShowLogin;
        private DevExpress.XtraEditors.LabelControl lblLoginUsername;
        private DevExpress.XtraEditors.TextEdit txtLoginUsername;
        private DevExpress.XtraEditors.LabelControl lblLoginPassword;
        private DevExpress.XtraEditors.TextEdit txtLoginPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnShowRegister;
        private System.Windows.Forms.Label lblLogin;
        private DevExpress.XtraEditors.PanelControl pnlLogin;
    }
}