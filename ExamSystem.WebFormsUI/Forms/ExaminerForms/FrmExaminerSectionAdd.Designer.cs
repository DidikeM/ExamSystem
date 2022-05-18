
namespace ExamSystem.WebFormsUI.Forms.ExaminerForms
{
    partial class FrmExaminerSectionAdd
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
            this.tbpMain = new DevExpress.Utils.Layout.TablePanel();
            this.tbpLecture = new DevExpress.Utils.Layout.TablePanel();
            this.tbpLectureAdd = new DevExpress.Utils.Layout.TablePanel();
            this.lblLecture = new DevExpress.XtraEditors.LabelControl();
            this.lueLecture = new DevExpress.XtraEditors.LookUpEdit();
            this.lblEditGradeNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblEditLectureName = new DevExpress.XtraEditors.LabelControl();
            this.txtEditGradeNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtEditLectureName = new DevExpress.XtraEditors.TextEdit();
            this.btnLectureAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tbpUnit = new DevExpress.Utils.Layout.TablePanel();
            this.lueUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.tbpUnitAdd = new DevExpress.Utils.Layout.TablePanel();
            this.btnUnitAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtEditUnitName = new DevExpress.XtraEditors.TextEdit();
            this.txtEditUnitNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblEditUnitName = new DevExpress.XtraEditors.LabelControl();
            this.lblEditUnitNumber = new DevExpress.XtraEditors.LabelControl();
            this.tbpSection = new DevExpress.Utils.Layout.TablePanel();
            this.lueSection = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSection = new DevExpress.XtraEditors.LabelControl();
            this.tbpSectionAdd = new DevExpress.Utils.Layout.TablePanel();
            this.btnSectionAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtEditSectionName = new DevExpress.XtraEditors.TextEdit();
            this.txtEditSectionNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblEditSectionName = new DevExpress.XtraEditors.LabelControl();
            this.lblEditSectionNumber = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).BeginInit();
            this.tbpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpLecture)).BeginInit();
            this.tbpLecture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpLectureAdd)).BeginInit();
            this.tbpLectureAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueLecture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditGradeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditLectureName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpUnit)).BeginInit();
            this.tbpUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpUnitAdd)).BeginInit();
            this.tbpUnitAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUnitNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpSection)).BeginInit();
            this.tbpSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpSectionAdd)).BeginInit();
            this.tbpSectionAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSectionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSectionNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpMain.Appearance.Options.UseBackColor = true;
            this.tbpMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Controls.Add(this.tbpSection);
            this.tbpMain.Controls.Add(this.tbpUnit);
            this.tbpMain.Controls.Add(this.tbpLecture);
            this.tbpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMain.Location = new System.Drawing.Point(0, 0);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tbpMain.Size = new System.Drawing.Size(1229, 622);
            this.tbpMain.TabIndex = 0;
            // 
            // tbpLecture
            // 
            this.tbpMain.SetColumn(this.tbpLecture, 0);
            this.tbpLecture.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpLecture.Controls.Add(this.lueLecture);
            this.tbpLecture.Controls.Add(this.lblLecture);
            this.tbpLecture.Controls.Add(this.tbpLectureAdd);
            this.tbpLecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpLecture.Location = new System.Drawing.Point(3, 3);
            this.tbpLecture.Name = "tbpLecture";
            this.tbpMain.SetRow(this.tbpLecture, 0);
            this.tbpLecture.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tbpLecture.Size = new System.Drawing.Size(404, 201);
            this.tbpLecture.TabIndex = 0;
            // 
            // tbpLectureAdd
            // 
            this.tbpLecture.SetColumn(this.tbpLectureAdd, 0);
            this.tbpLectureAdd.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpLectureAdd.Controls.Add(this.btnLectureAdd);
            this.tbpLectureAdd.Controls.Add(this.txtEditLectureName);
            this.tbpLectureAdd.Controls.Add(this.txtEditGradeNumber);
            this.tbpLectureAdd.Controls.Add(this.lblEditLectureName);
            this.tbpLectureAdd.Controls.Add(this.lblEditGradeNumber);
            this.tbpLectureAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpLectureAdd.Location = new System.Drawing.Point(3, 103);
            this.tbpLectureAdd.Name = "tbpLectureAdd";
            this.tbpLecture.SetRow(this.tbpLectureAdd, 2);
            this.tbpLectureAdd.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpLectureAdd.Size = new System.Drawing.Size(398, 95);
            this.tbpLectureAdd.TabIndex = 0;
            // 
            // lblLecture
            // 
            this.lblLecture.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLecture.Appearance.Options.UseFont = true;
            this.lblLecture.Appearance.Options.UseTextOptions = true;
            this.lblLecture.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLecture.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tbpLecture.SetColumn(this.lblLecture, 0);
            this.lblLecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLecture.Location = new System.Drawing.Point(3, 3);
            this.lblLecture.Name = "lblLecture";
            this.tbpLecture.SetRow(this.lblLecture, 0);
            this.lblLecture.Size = new System.Drawing.Size(398, 44);
            this.lblLecture.TabIndex = 1;
            this.lblLecture.Text = "Ders";
            // 
            // lueLecture
            // 
            this.lueLecture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpLecture.SetColumn(this.lueLecture, 0);
            this.lueLecture.Location = new System.Drawing.Point(3, 62);
            this.lueLecture.Name = "lueLecture";
            this.lueLecture.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lueLecture.Properties.Appearance.Options.UseFont = true;
            this.lueLecture.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLecture.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GradeNumber", "Sınıf"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Adı")});
            this.lueLecture.Properties.DisplayMember = "Name";
            this.lueLecture.Properties.DropDownRows = 3;
            this.lueLecture.Properties.NullText = "Lütfen Seçiniz";
            this.lueLecture.Properties.ValueMember = "ID";
            this.tbpLecture.SetRow(this.lueLecture, 1);
            this.lueLecture.Size = new System.Drawing.Size(398, 26);
            this.lueLecture.TabIndex = 2;
            this.lueLecture.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lueLecture_Closed);
            // 
            // lblEditGradeNumber
            // 
            this.lblEditGradeNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEditGradeNumber.Appearance.Options.UseFont = true;
            this.lblEditGradeNumber.Appearance.Options.UseTextOptions = true;
            this.lblEditGradeNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpLectureAdd.SetColumn(this.lblEditGradeNumber, 0);
            this.lblEditGradeNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditGradeNumber.Location = new System.Drawing.Point(3, 3);
            this.lblEditGradeNumber.Name = "lblEditGradeNumber";
            this.tbpLectureAdd.SetRow(this.lblEditGradeNumber, 0);
            this.lblEditGradeNumber.Size = new System.Drawing.Size(127, 42);
            this.lblEditGradeNumber.TabIndex = 0;
            this.lblEditGradeNumber.Text = "Sınıf:";
            // 
            // lblEditLectureName
            // 
            this.lblEditLectureName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEditLectureName.Appearance.Options.UseFont = true;
            this.lblEditLectureName.Appearance.Options.UseTextOptions = true;
            this.lblEditLectureName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpLectureAdd.SetColumn(this.lblEditLectureName, 0);
            this.lblEditLectureName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditLectureName.Location = new System.Drawing.Point(3, 51);
            this.lblEditLectureName.Name = "lblEditLectureName";
            this.tbpLectureAdd.SetRow(this.lblEditLectureName, 1);
            this.lblEditLectureName.Size = new System.Drawing.Size(127, 41);
            this.lblEditLectureName.TabIndex = 1;
            this.lblEditLectureName.Text = "Ders Adı:";
            // 
            // txtEditGradeNumber
            // 
            this.txtEditGradeNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpLectureAdd.SetColumn(this.txtEditGradeNumber, 1);
            this.txtEditGradeNumber.EditValue = "8";
            this.txtEditGradeNumber.Location = new System.Drawing.Point(136, 11);
            this.txtEditGradeNumber.Name = "txtEditGradeNumber";
            this.txtEditGradeNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditGradeNumber.Properties.Appearance.Options.UseFont = true;
            this.tbpLectureAdd.SetRow(this.txtEditGradeNumber, 0);
            this.txtEditGradeNumber.Size = new System.Drawing.Size(127, 26);
            this.txtEditGradeNumber.TabIndex = 2;
            // 
            // txtEditLectureName
            // 
            this.txtEditLectureName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpLectureAdd.SetColumn(this.txtEditLectureName, 1);
            this.txtEditLectureName.Location = new System.Drawing.Point(136, 58);
            this.txtEditLectureName.Name = "txtEditLectureName";
            this.txtEditLectureName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditLectureName.Properties.Appearance.Options.UseFont = true;
            this.tbpLectureAdd.SetRow(this.txtEditLectureName, 1);
            this.txtEditLectureName.Size = new System.Drawing.Size(127, 26);
            this.txtEditLectureName.TabIndex = 3;
            // 
            // btnLectureAdd
            // 
            this.btnLectureAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLectureAdd.Appearance.Options.UseFont = true;
            this.tbpLectureAdd.SetColumn(this.btnLectureAdd, 2);
            this.btnLectureAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLectureAdd.Location = new System.Drawing.Point(268, 51);
            this.btnLectureAdd.Name = "btnLectureAdd";
            this.tbpLectureAdd.SetRow(this.btnLectureAdd, 1);
            this.btnLectureAdd.Size = new System.Drawing.Size(127, 41);
            this.btnLectureAdd.TabIndex = 4;
            this.btnLectureAdd.Text = "Ders\'i Ekle";
            this.btnLectureAdd.Click += new System.EventHandler(this.btnLectureAdd_Click);
            // 
            // tbpUnit
            // 
            this.tbpMain.SetColumn(this.tbpUnit, 1);
            this.tbpUnit.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpUnit.Controls.Add(this.lueUnit);
            this.tbpUnit.Controls.Add(this.lblUnit);
            this.tbpUnit.Controls.Add(this.tbpUnitAdd);
            this.tbpUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpUnit.Location = new System.Drawing.Point(413, 3);
            this.tbpUnit.Name = "tbpUnit";
            this.tbpMain.SetRow(this.tbpUnit, 0);
            this.tbpUnit.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tbpUnit.Size = new System.Drawing.Size(404, 201);
            this.tbpUnit.TabIndex = 1;
            // 
            // lueUnit
            // 
            this.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpUnit.SetColumn(this.lueUnit, 0);
            this.lueUnit.Location = new System.Drawing.Point(3, 62);
            this.lueUnit.Name = "lueUnit";
            this.lueUnit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lueUnit.Properties.Appearance.Options.UseFont = true;
            this.lueUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LectureID", " ", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Numarası"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Adı")});
            this.lueUnit.Properties.DisplayMember = "Name";
            this.lueUnit.Properties.NullText = "Lütfen Seçiniz";
            this.lueUnit.Properties.ValueMember = "ID";
            this.tbpUnit.SetRow(this.lueUnit, 1);
            this.lueUnit.Size = new System.Drawing.Size(398, 26);
            this.lueUnit.TabIndex = 2;
            this.lueUnit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lueUnit_Closed);
            // 
            // lblUnit
            // 
            this.lblUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnit.Appearance.Options.UseFont = true;
            this.lblUnit.Appearance.Options.UseTextOptions = true;
            this.lblUnit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUnit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tbpUnit.SetColumn(this.lblUnit, 0);
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(3, 3);
            this.lblUnit.Name = "lblUnit";
            this.tbpUnit.SetRow(this.lblUnit, 0);
            this.lblUnit.Size = new System.Drawing.Size(398, 44);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "Ünite";
            // 
            // tbpUnitAdd
            // 
            this.tbpUnit.SetColumn(this.tbpUnitAdd, 0);
            this.tbpUnitAdd.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpUnitAdd.Controls.Add(this.btnUnitAdd);
            this.tbpUnitAdd.Controls.Add(this.txtEditUnitName);
            this.tbpUnitAdd.Controls.Add(this.txtEditUnitNumber);
            this.tbpUnitAdd.Controls.Add(this.lblEditUnitName);
            this.tbpUnitAdd.Controls.Add(this.lblEditUnitNumber);
            this.tbpUnitAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpUnitAdd.Location = new System.Drawing.Point(3, 103);
            this.tbpUnitAdd.Name = "tbpUnitAdd";
            this.tbpUnit.SetRow(this.tbpUnitAdd, 2);
            this.tbpUnitAdd.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpUnitAdd.Size = new System.Drawing.Size(398, 95);
            this.tbpUnitAdd.TabIndex = 0;
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitAdd.Appearance.Options.UseFont = true;
            this.tbpUnitAdd.SetColumn(this.btnUnitAdd, 2);
            this.btnUnitAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnitAdd.Location = new System.Drawing.Point(268, 51);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.tbpUnitAdd.SetRow(this.btnUnitAdd, 1);
            this.btnUnitAdd.Size = new System.Drawing.Size(127, 41);
            this.btnUnitAdd.TabIndex = 4;
            this.btnUnitAdd.Text = "Ünite\'yi Ekle";
            this.btnUnitAdd.Click += new System.EventHandler(this.btnUnitAdd_Click);
            // 
            // txtEditUnitName
            // 
            this.txtEditUnitName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpUnitAdd.SetColumn(this.txtEditUnitName, 1);
            this.txtEditUnitName.Location = new System.Drawing.Point(136, 58);
            this.txtEditUnitName.Name = "txtEditUnitName";
            this.txtEditUnitName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditUnitName.Properties.Appearance.Options.UseFont = true;
            this.tbpUnitAdd.SetRow(this.txtEditUnitName, 1);
            this.txtEditUnitName.Size = new System.Drawing.Size(127, 26);
            this.txtEditUnitName.TabIndex = 3;
            // 
            // txtEditUnitNumber
            // 
            this.txtEditUnitNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpUnitAdd.SetColumn(this.txtEditUnitNumber, 1);
            this.txtEditUnitNumber.Location = new System.Drawing.Point(136, 11);
            this.txtEditUnitNumber.Name = "txtEditUnitNumber";
            this.txtEditUnitNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditUnitNumber.Properties.Appearance.Options.UseFont = true;
            this.tbpUnitAdd.SetRow(this.txtEditUnitNumber, 0);
            this.txtEditUnitNumber.Size = new System.Drawing.Size(127, 26);
            this.txtEditUnitNumber.TabIndex = 2;
            // 
            // lblEditUnitName
            // 
            this.lblEditUnitName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEditUnitName.Appearance.Options.UseFont = true;
            this.lblEditUnitName.Appearance.Options.UseTextOptions = true;
            this.lblEditUnitName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpUnitAdd.SetColumn(this.lblEditUnitName, 0);
            this.lblEditUnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditUnitName.Location = new System.Drawing.Point(3, 51);
            this.lblEditUnitName.Name = "lblEditUnitName";
            this.tbpUnitAdd.SetRow(this.lblEditUnitName, 1);
            this.lblEditUnitName.Size = new System.Drawing.Size(127, 41);
            this.lblEditUnitName.TabIndex = 1;
            this.lblEditUnitName.Text = "Ünite Adı:";
            // 
            // lblEditUnitNumber
            // 
            this.lblEditUnitNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEditUnitNumber.Appearance.Options.UseFont = true;
            this.lblEditUnitNumber.Appearance.Options.UseTextOptions = true;
            this.lblEditUnitNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpUnitAdd.SetColumn(this.lblEditUnitNumber, 0);
            this.lblEditUnitNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditUnitNumber.Location = new System.Drawing.Point(3, 3);
            this.lblEditUnitNumber.Name = "lblEditUnitNumber";
            this.tbpUnitAdd.SetRow(this.lblEditUnitNumber, 0);
            this.lblEditUnitNumber.Size = new System.Drawing.Size(127, 42);
            this.lblEditUnitNumber.TabIndex = 0;
            this.lblEditUnitNumber.Text = "Ünite Numarası:";
            // 
            // tbpSection
            // 
            this.tbpMain.SetColumn(this.tbpSection, 2);
            this.tbpSection.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpSection.Controls.Add(this.lueSection);
            this.tbpSection.Controls.Add(this.lblSection);
            this.tbpSection.Controls.Add(this.tbpSectionAdd);
            this.tbpSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpSection.Location = new System.Drawing.Point(822, 3);
            this.tbpSection.Name = "tbpSection";
            this.tbpMain.SetRow(this.tbpSection, 0);
            this.tbpSection.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tbpSection.Size = new System.Drawing.Size(404, 201);
            this.tbpSection.TabIndex = 2;
            // 
            // lueSection
            // 
            this.lueSection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpSection.SetColumn(this.lueSection, 0);
            this.lueSection.Location = new System.Drawing.Point(3, 62);
            this.lueSection.Name = "lueSection";
            this.lueSection.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lueSection.Properties.Appearance.Options.UseFont = true;
            this.lueSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSection.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Numarası"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Adı")});
            this.lueSection.Properties.DisplayMember = "Name";
            this.lueSection.Properties.NullText = "Lütfen Seçiniz";
            this.lueSection.Properties.ValueMember = "ID";
            this.tbpSection.SetRow(this.lueSection, 1);
            this.lueSection.Size = new System.Drawing.Size(398, 26);
            this.lueSection.TabIndex = 2;
            // 
            // lblSection
            // 
            this.lblSection.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSection.Appearance.Options.UseFont = true;
            this.lblSection.Appearance.Options.UseTextOptions = true;
            this.lblSection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSection.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tbpSection.SetColumn(this.lblSection, 0);
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSection.Location = new System.Drawing.Point(3, 3);
            this.lblSection.Name = "lblSection";
            this.tbpSection.SetRow(this.lblSection, 0);
            this.lblSection.Size = new System.Drawing.Size(398, 44);
            this.lblSection.TabIndex = 1;
            this.lblSection.Text = "Konu";
            // 
            // tbpSectionAdd
            // 
            this.tbpSection.SetColumn(this.tbpSectionAdd, 0);
            this.tbpSectionAdd.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpSectionAdd.Controls.Add(this.btnSectionAdd);
            this.tbpSectionAdd.Controls.Add(this.txtEditSectionName);
            this.tbpSectionAdd.Controls.Add(this.txtEditSectionNumber);
            this.tbpSectionAdd.Controls.Add(this.lblEditSectionName);
            this.tbpSectionAdd.Controls.Add(this.lblEditSectionNumber);
            this.tbpSectionAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpSectionAdd.Location = new System.Drawing.Point(3, 103);
            this.tbpSectionAdd.Name = "tbpSectionAdd";
            this.tbpSection.SetRow(this.tbpSectionAdd, 2);
            this.tbpSectionAdd.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpSectionAdd.Size = new System.Drawing.Size(398, 95);
            this.tbpSectionAdd.TabIndex = 0;
            // 
            // btnSectionAdd
            // 
            this.btnSectionAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSectionAdd.Appearance.Options.UseFont = true;
            this.tbpSectionAdd.SetColumn(this.btnSectionAdd, 2);
            this.btnSectionAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSectionAdd.Location = new System.Drawing.Point(268, 51);
            this.btnSectionAdd.Name = "btnSectionAdd";
            this.tbpSectionAdd.SetRow(this.btnSectionAdd, 1);
            this.btnSectionAdd.Size = new System.Drawing.Size(127, 41);
            this.btnSectionAdd.TabIndex = 4;
            this.btnSectionAdd.Text = "Konu\'yu Ekle";
            this.btnSectionAdd.Click += new System.EventHandler(this.btnSectionAdd_Click);
            // 
            // txtEditSectionName
            // 
            this.txtEditSectionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpSectionAdd.SetColumn(this.txtEditSectionName, 1);
            this.txtEditSectionName.Location = new System.Drawing.Point(136, 58);
            this.txtEditSectionName.Name = "txtEditSectionName";
            this.txtEditSectionName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditSectionName.Properties.Appearance.Options.UseFont = true;
            this.tbpSectionAdd.SetRow(this.txtEditSectionName, 1);
            this.txtEditSectionName.Size = new System.Drawing.Size(127, 26);
            this.txtEditSectionName.TabIndex = 3;
            // 
            // txtEditSectionNumber
            // 
            this.txtEditSectionNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpSectionAdd.SetColumn(this.txtEditSectionNumber, 1);
            this.txtEditSectionNumber.Location = new System.Drawing.Point(136, 11);
            this.txtEditSectionNumber.Name = "txtEditSectionNumber";
            this.txtEditSectionNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditSectionNumber.Properties.Appearance.Options.UseFont = true;
            this.tbpSectionAdd.SetRow(this.txtEditSectionNumber, 0);
            this.txtEditSectionNumber.Size = new System.Drawing.Size(127, 26);
            this.txtEditSectionNumber.TabIndex = 2;
            // 
            // lblEditSectionName
            // 
            this.lblEditSectionName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEditSectionName.Appearance.Options.UseFont = true;
            this.lblEditSectionName.Appearance.Options.UseTextOptions = true;
            this.lblEditSectionName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpSectionAdd.SetColumn(this.lblEditSectionName, 0);
            this.lblEditSectionName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditSectionName.Location = new System.Drawing.Point(3, 51);
            this.lblEditSectionName.Name = "lblEditSectionName";
            this.tbpSectionAdd.SetRow(this.lblEditSectionName, 1);
            this.lblEditSectionName.Size = new System.Drawing.Size(127, 41);
            this.lblEditSectionName.TabIndex = 1;
            this.lblEditSectionName.Text = "Konu Adı:";
            // 
            // lblEditSectionNumber
            // 
            this.lblEditSectionNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEditSectionNumber.Appearance.Options.UseFont = true;
            this.lblEditSectionNumber.Appearance.Options.UseTextOptions = true;
            this.lblEditSectionNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpSectionAdd.SetColumn(this.lblEditSectionNumber, 0);
            this.lblEditSectionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditSectionNumber.Location = new System.Drawing.Point(3, 3);
            this.lblEditSectionNumber.Name = "lblEditSectionNumber";
            this.tbpSectionAdd.SetRow(this.lblEditSectionNumber, 0);
            this.lblEditSectionNumber.Size = new System.Drawing.Size(127, 42);
            this.lblEditSectionNumber.TabIndex = 0;
            this.lblEditSectionNumber.Text = "Konu Numarası:";
            // 
            // FrmExaminerSectionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 622);
            this.Controls.Add(this.tbpMain);
            this.Name = "FrmExaminerSectionAdd";
            this.Text = "FrmExaminerSectionAdd";
            this.Load += new System.EventHandler(this.FrmExaminerSectionAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).EndInit();
            this.tbpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbpLecture)).EndInit();
            this.tbpLecture.ResumeLayout(false);
            this.tbpLecture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpLectureAdd)).EndInit();
            this.tbpLectureAdd.ResumeLayout(false);
            this.tbpLectureAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueLecture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditGradeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditLectureName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpUnit)).EndInit();
            this.tbpUnit.ResumeLayout(false);
            this.tbpUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpUnitAdd)).EndInit();
            this.tbpUnitAdd.ResumeLayout(false);
            this.tbpUnitAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUnitNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpSection)).EndInit();
            this.tbpSection.ResumeLayout(false);
            this.tbpSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpSectionAdd)).EndInit();
            this.tbpSectionAdd.ResumeLayout(false);
            this.tbpSectionAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSectionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSectionNumber.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tbpMain;
        private DevExpress.Utils.Layout.TablePanel tbpLecture;
        private DevExpress.XtraEditors.LookUpEdit lueLecture;
        private DevExpress.XtraEditors.LabelControl lblLecture;
        private DevExpress.Utils.Layout.TablePanel tbpLectureAdd;
        private DevExpress.XtraEditors.TextEdit txtEditGradeNumber;
        private DevExpress.XtraEditors.LabelControl lblEditLectureName;
        private DevExpress.XtraEditors.LabelControl lblEditGradeNumber;
        private DevExpress.Utils.Layout.TablePanel tbpSection;
        private DevExpress.XtraEditors.LookUpEdit lueSection;
        private DevExpress.XtraEditors.LabelControl lblSection;
        private DevExpress.Utils.Layout.TablePanel tbpSectionAdd;
        private DevExpress.XtraEditors.SimpleButton btnSectionAdd;
        private DevExpress.XtraEditors.TextEdit txtEditSectionName;
        private DevExpress.XtraEditors.TextEdit txtEditSectionNumber;
        private DevExpress.XtraEditors.LabelControl lblEditSectionName;
        private DevExpress.XtraEditors.LabelControl lblEditSectionNumber;
        private DevExpress.Utils.Layout.TablePanel tbpUnit;
        private DevExpress.XtraEditors.LookUpEdit lueUnit;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.Utils.Layout.TablePanel tbpUnitAdd;
        private DevExpress.XtraEditors.SimpleButton btnUnitAdd;
        private DevExpress.XtraEditors.TextEdit txtEditUnitName;
        private DevExpress.XtraEditors.TextEdit txtEditUnitNumber;
        private DevExpress.XtraEditors.LabelControl lblEditUnitName;
        private DevExpress.XtraEditors.LabelControl lblEditUnitNumber;
        private DevExpress.XtraEditors.SimpleButton btnLectureAdd;
        private DevExpress.XtraEditors.TextEdit txtEditLectureName;
    }
}