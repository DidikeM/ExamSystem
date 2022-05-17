
namespace ExamSystem.WebFormsUI.Forms.ExaminerForms
{
    partial class FrmExaminerQuestionAdd
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
            this.tbpQuestion = new DevExpress.Utils.Layout.TablePanel();
            this.rtbQuestion = new DevExpress.XtraRichEdit.RichEditControl();
            this.tbpTitle = new DevExpress.Utils.Layout.TablePanel();
            this.lueSection = new DevExpress.XtraEditors.LookUpEdit();
            this.lueUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.lueLecture = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSection = new DevExpress.XtraEditors.LabelControl();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.lblLecture = new DevExpress.XtraEditors.LabelControl();
            this.tbpChoiceFormat = new DevExpress.Utils.Layout.TablePanel();
            this.lblChoiceFormat = new DevExpress.XtraEditors.LabelControl();
            this.lueChoiceFormat = new DevExpress.XtraEditors.LookUpEdit();
            this.tbpChoices = new DevExpress.Utils.Layout.TablePanel();
            this.txtChoiceA = new DevExpress.XtraEditors.TextEdit();
            this.imgChoiceA = new DevExpress.XtraEditors.ImageEdit();
            this.lblChoiceA = new DevExpress.XtraEditors.LabelControl();
            this.lblChoiceB = new DevExpress.XtraEditors.LabelControl();
            this.lblChoiceC = new DevExpress.XtraEditors.LabelControl();
            this.lblChoiceD = new DevExpress.XtraEditors.LabelControl();
            this.txtChoiceB = new DevExpress.XtraEditors.TextEdit();
            this.txtChoiceC = new DevExpress.XtraEditors.TextEdit();
            this.txtChoiceD = new DevExpress.XtraEditors.TextEdit();
            this.imgChoiceB = new DevExpress.XtraEditors.ImageEdit();
            this.imgChoiceC = new DevExpress.XtraEditors.ImageEdit();
            this.imgChoiceD = new DevExpress.XtraEditors.ImageEdit();
            this.tbpSave = new DevExpress.Utils.Layout.TablePanel();
            this.btnSaveQuestion = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).BeginInit();
            this.tbpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestion)).BeginInit();
            this.tbpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpTitle)).BeginInit();
            this.tbpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLecture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpChoiceFormat)).BeginInit();
            this.tbpChoiceFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueChoiceFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpChoices)).BeginInit();
            this.tbpChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoiceA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoiceA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoiceB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoiceC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoiceD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoiceB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoiceC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoiceD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpSave)).BeginInit();
            this.tbpSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpMain.Appearance.Options.UseBackColor = true;
            this.tbpMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 900F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Controls.Add(this.tbpSave);
            this.tbpMain.Controls.Add(this.tbpQuestion);
            this.tbpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMain.Location = new System.Drawing.Point(0, 0);
            this.tbpMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Size = new System.Drawing.Size(1160, 623);
            this.tbpMain.TabIndex = 0;
            // 
            // tbpQuestion
            // 
            this.tbpQuestion.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpQuestion.Appearance.Options.UseBackColor = true;
            this.tbpMain.SetColumn(this.tbpQuestion, 0);
            this.tbpQuestion.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpQuestion.Controls.Add(this.tbpChoices);
            this.tbpQuestion.Controls.Add(this.tbpChoiceFormat);
            this.tbpQuestion.Controls.Add(this.rtbQuestion);
            this.tbpQuestion.Controls.Add(this.tbpTitle);
            this.tbpQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpQuestion.Location = new System.Drawing.Point(3, 3);
            this.tbpQuestion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpQuestion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpQuestion.Name = "tbpQuestion";
            this.tbpMain.SetRow(this.tbpQuestion, 0);
            this.tbpQuestion.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 400F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpQuestion.Size = new System.Drawing.Size(894, 617);
            this.tbpQuestion.TabIndex = 0;
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.tbpQuestion.SetColumn(this.rtbQuestion, 0);
            this.rtbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbQuestion.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.rtbQuestion.Location = new System.Drawing.Point(3, 53);
            this.rtbQuestion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.rtbQuestion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.Rtf;
            this.rtbQuestion.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.rtbQuestion.Options.TableOptions.GridLines = DevExpress.XtraRichEdit.RichEditTableGridLinesVisibility.Hidden;
            this.rtbQuestion.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.tbpQuestion.SetRow(this.rtbQuestion, 1);
            this.rtbQuestion.Size = new System.Drawing.Size(888, 394);
            this.rtbQuestion.TabIndex = 2;
            this.rtbQuestion.PopupMenuShowing += new DevExpress.XtraRichEdit.PopupMenuShowingEventHandler(this.rtbQuestion_PopupMenuShowing);
            // 
            // tbpTitle
            // 
            this.tbpTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpTitle.Appearance.Options.UseBackColor = true;
            this.tbpQuestion.SetColumn(this.tbpTitle, 0);
            this.tbpTitle.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpTitle.Controls.Add(this.lueSection);
            this.tbpTitle.Controls.Add(this.lueUnit);
            this.tbpTitle.Controls.Add(this.lueLecture);
            this.tbpTitle.Controls.Add(this.lblSection);
            this.tbpTitle.Controls.Add(this.lblUnit);
            this.tbpTitle.Controls.Add(this.lblLecture);
            this.tbpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpTitle.Location = new System.Drawing.Point(3, 3);
            this.tbpTitle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpTitle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpTitle.Name = "tbpTitle";
            this.tbpQuestion.SetRow(this.tbpTitle, 0);
            this.tbpTitle.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpTitle.Size = new System.Drawing.Size(888, 44);
            this.tbpTitle.TabIndex = 0;
            // 
            // lueSection
            // 
            this.lueSection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpTitle.SetColumn(this.lueSection, 5);
            this.lueSection.Location = new System.Drawing.Point(743, 11);
            this.lueSection.Name = "lueSection";
            this.lueSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSection.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Numarası"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Adı")});
            this.lueSection.Properties.DisplayMember = "Name";
            this.lueSection.Properties.DropDownRows = 5;
            this.lueSection.Properties.NullText = "Lütfen Seçiniz";
            this.lueSection.Properties.ValueMember = "ID";
            this.tbpTitle.SetRow(this.lueSection, 0);
            this.lueSection.Size = new System.Drawing.Size(142, 22);
            this.lueSection.TabIndex = 1;
            // 
            // lueUnit
            // 
            this.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpTitle.SetColumn(this.lueUnit, 3);
            this.lueUnit.Location = new System.Drawing.Point(447, 11);
            this.lueUnit.Name = "lueUnit";
            this.lueUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LectureID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Numarası"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Adı")});
            this.lueUnit.Properties.DisplayMember = "Name";
            this.lueUnit.Properties.DropDownRows = 5;
            this.lueUnit.Properties.NullText = "Lütfen Seçiniz";
            this.lueUnit.Properties.ValueMember = "ID";
            this.tbpTitle.SetRow(this.lueUnit, 0);
            this.lueUnit.Size = new System.Drawing.Size(142, 22);
            this.lueUnit.TabIndex = 3;
            this.lueUnit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lueUnit_Closed);
            // 
            // lueLecture
            // 
            this.lueLecture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpTitle.SetColumn(this.lueLecture, 1);
            this.lueLecture.Location = new System.Drawing.Point(151, 11);
            this.lueLecture.Name = "lueLecture";
            this.lueLecture.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLecture.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GradeNumber", "Sınıf"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ders Adı:")});
            this.lueLecture.Properties.DisplayMember = "Name";
            this.lueLecture.Properties.DropDownRows = 3;
            this.lueLecture.Properties.NullText = "Lütfen Seçiniz";
            this.lueLecture.Properties.ValueMember = "ID";
            this.tbpTitle.SetRow(this.lueLecture, 0);
            this.lueLecture.Size = new System.Drawing.Size(142, 22);
            this.lueLecture.TabIndex = 3;
            this.lueLecture.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lueLecture_Closed);
            // 
            // lblSection
            // 
            this.lblSection.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSection.Appearance.Options.UseFont = true;
            this.lblSection.Appearance.Options.UseTextOptions = true;
            this.lblSection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpTitle.SetColumn(this.lblSection, 4);
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSection.Location = new System.Drawing.Point(595, 3);
            this.lblSection.Name = "lblSection";
            this.tbpTitle.SetRow(this.lblSection, 0);
            this.lblSection.Size = new System.Drawing.Size(142, 38);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Konu:";
            // 
            // lblUnit
            // 
            this.lblUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Appearance.Options.UseFont = true;
            this.lblUnit.Appearance.Options.UseTextOptions = true;
            this.lblUnit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpTitle.SetColumn(this.lblUnit, 2);
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(299, 3);
            this.lblUnit.Name = "lblUnit";
            this.tbpTitle.SetRow(this.lblUnit, 0);
            this.lblUnit.Size = new System.Drawing.Size(142, 38);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Ünite:";
            // 
            // lblLecture
            // 
            this.lblLecture.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLecture.Appearance.Options.UseFont = true;
            this.lblLecture.Appearance.Options.UseTextOptions = true;
            this.lblLecture.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpTitle.SetColumn(this.lblLecture, 0);
            this.lblLecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLecture.Location = new System.Drawing.Point(3, 3);
            this.lblLecture.Name = "lblLecture";
            this.tbpTitle.SetRow(this.lblLecture, 0);
            this.lblLecture.Size = new System.Drawing.Size(142, 38);
            this.lblLecture.TabIndex = 1;
            this.lblLecture.Text = "Ders:";
            // 
            // tbpChoiceFormat
            // 
            this.tbpChoiceFormat.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpChoiceFormat.Appearance.Options.UseBackColor = true;
            this.tbpQuestion.SetColumn(this.tbpChoiceFormat, 0);
            this.tbpChoiceFormat.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 250F)});
            this.tbpChoiceFormat.Controls.Add(this.lueChoiceFormat);
            this.tbpChoiceFormat.Controls.Add(this.lblChoiceFormat);
            this.tbpChoiceFormat.Location = new System.Drawing.Point(3, 453);
            this.tbpChoiceFormat.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpChoiceFormat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpChoiceFormat.Name = "tbpChoiceFormat";
            this.tbpQuestion.SetRow(this.tbpChoiceFormat, 2);
            this.tbpChoiceFormat.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpChoiceFormat.Size = new System.Drawing.Size(888, 44);
            this.tbpChoiceFormat.TabIndex = 3;
            // 
            // lblChoiceFormat
            // 
            this.lblChoiceFormat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoiceFormat.Appearance.Options.UseFont = true;
            this.lblChoiceFormat.Appearance.Options.UseTextOptions = true;
            this.lblChoiceFormat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpChoiceFormat.SetColumn(this.lblChoiceFormat, 0);
            this.lblChoiceFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceFormat.Location = new System.Drawing.Point(3, 3);
            this.lblChoiceFormat.Name = "lblChoiceFormat";
            this.tbpChoiceFormat.SetRow(this.lblChoiceFormat, 0);
            this.lblChoiceFormat.Size = new System.Drawing.Size(142, 38);
            this.lblChoiceFormat.TabIndex = 2;
            this.lblChoiceFormat.Text = "Şık Tipi:";
            // 
            // lueChoiceFormat
            // 
            this.lueChoiceFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoiceFormat.SetColumn(this.lueChoiceFormat, 1);
            this.lueChoiceFormat.Location = new System.Drawing.Point(151, 11);
            this.lueChoiceFormat.Name = "lueChoiceFormat";
            this.lueChoiceFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueChoiceFormat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "")});
            this.lueChoiceFormat.Properties.DisplayMember = "Name";
            this.lueChoiceFormat.Properties.DropDownRows = 5;
            this.lueChoiceFormat.Properties.NullText = "Lütfen Seçiniz";
            this.lueChoiceFormat.Properties.ValueMember = "ID";
            this.tbpChoiceFormat.SetRow(this.lueChoiceFormat, 0);
            this.lueChoiceFormat.Size = new System.Drawing.Size(734, 22);
            this.lueChoiceFormat.TabIndex = 4;
            this.lueChoiceFormat.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lueChoiceFormat_Closed);
            // 
            // tbpChoices
            // 
            this.tbpChoices.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpChoices.Appearance.Options.UseBackColor = true;
            this.tbpQuestion.SetColumn(this.tbpChoices, 0);
            this.tbpChoices.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpChoices.Controls.Add(this.imgChoiceD);
            this.tbpChoices.Controls.Add(this.imgChoiceC);
            this.tbpChoices.Controls.Add(this.imgChoiceB);
            this.tbpChoices.Controls.Add(this.txtChoiceD);
            this.tbpChoices.Controls.Add(this.txtChoiceC);
            this.tbpChoices.Controls.Add(this.txtChoiceB);
            this.tbpChoices.Controls.Add(this.lblChoiceD);
            this.tbpChoices.Controls.Add(this.lblChoiceC);
            this.tbpChoices.Controls.Add(this.lblChoiceB);
            this.tbpChoices.Controls.Add(this.lblChoiceA);
            this.tbpChoices.Controls.Add(this.imgChoiceA);
            this.tbpChoices.Controls.Add(this.txtChoiceA);
            this.tbpChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpChoices.Location = new System.Drawing.Point(3, 503);
            this.tbpChoices.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpChoices.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpChoices.Name = "tbpChoices";
            this.tbpQuestion.SetRow(this.tbpChoices, 3);
            this.tbpChoices.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpChoices.Size = new System.Drawing.Size(888, 111);
            this.tbpChoices.TabIndex = 4;
            // 
            // txtChoiceA
            // 
            this.txtChoiceA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoices.SetColumn(this.txtChoiceA, 1);
            this.txtChoiceA.EditValue = " ";
            this.txtChoiceA.Location = new System.Drawing.Point(27, 3);
            this.txtChoiceA.Name = "txtChoiceA";
            this.txtChoiceA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtChoiceA.Properties.Appearance.Options.UseFont = true;
            this.tbpChoices.SetRow(this.txtChoiceA, 0);
            this.txtChoiceA.Size = new System.Drawing.Size(426, 24);
            this.txtChoiceA.TabIndex = 0;
            // 
            // imgChoiceA
            // 
            this.imgChoiceA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoices.SetColumn(this.imgChoiceA, 2);
            this.imgChoiceA.Location = new System.Drawing.Point(459, 3);
            this.imgChoiceA.Name = "imgChoiceA";
            this.imgChoiceA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imgChoiceA.Properties.Appearance.Options.UseFont = true;
            this.imgChoiceA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbpChoices.SetRow(this.imgChoiceA, 0);
            this.imgChoiceA.Size = new System.Drawing.Size(426, 24);
            this.imgChoiceA.TabIndex = 1;
            // 
            // lblChoiceA
            // 
            this.lblChoiceA.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblChoiceA.Appearance.Options.UseBackColor = true;
            this.tbpChoices.SetColumn(this.lblChoiceA, 0);
            this.lblChoiceA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceA.Location = new System.Drawing.Point(3, 3);
            this.lblChoiceA.Name = "lblChoiceA";
            this.tbpChoices.SetRow(this.lblChoiceA, 0);
            this.lblChoiceA.Size = new System.Drawing.Size(18, 22);
            this.lblChoiceA.TabIndex = 5;
            this.lblChoiceA.Text = "A-) ";
            this.lblChoiceA.Click += new System.EventHandler(this.lblChoiceA_Click);
            // 
            // lblChoiceB
            // 
            this.tbpChoices.SetColumn(this.lblChoiceB, 0);
            this.lblChoiceB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceB.Location = new System.Drawing.Point(3, 31);
            this.lblChoiceB.Name = "lblChoiceB";
            this.tbpChoices.SetRow(this.lblChoiceB, 1);
            this.lblChoiceB.Size = new System.Drawing.Size(18, 22);
            this.lblChoiceB.TabIndex = 5;
            this.lblChoiceB.Text = "B-) ";
            this.lblChoiceB.Click += new System.EventHandler(this.lblChoiceB_Click);
            // 
            // lblChoiceC
            // 
            this.tbpChoices.SetColumn(this.lblChoiceC, 0);
            this.lblChoiceC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceC.Location = new System.Drawing.Point(3, 59);
            this.lblChoiceC.Name = "lblChoiceC";
            this.tbpChoices.SetRow(this.lblChoiceC, 2);
            this.lblChoiceC.Size = new System.Drawing.Size(18, 22);
            this.lblChoiceC.TabIndex = 5;
            this.lblChoiceC.Text = "C-) ";
            this.lblChoiceC.Click += new System.EventHandler(this.lblChoiceC_Click);
            // 
            // lblChoiceD
            // 
            this.tbpChoices.SetColumn(this.lblChoiceD, 0);
            this.lblChoiceD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceD.Location = new System.Drawing.Point(3, 87);
            this.lblChoiceD.Name = "lblChoiceD";
            this.tbpChoices.SetRow(this.lblChoiceD, 3);
            this.lblChoiceD.Size = new System.Drawing.Size(18, 21);
            this.lblChoiceD.TabIndex = 5;
            this.lblChoiceD.Text = "D-) ";
            this.lblChoiceD.Click += new System.EventHandler(this.lblChoiceD_Click);
            // 
            // txtChoiceB
            // 
            this.txtChoiceB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoices.SetColumn(this.txtChoiceB, 1);
            this.txtChoiceB.EditValue = " ";
            this.txtChoiceB.Location = new System.Drawing.Point(27, 31);
            this.txtChoiceB.Name = "txtChoiceB";
            this.txtChoiceB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtChoiceB.Properties.Appearance.Options.UseFont = true;
            this.tbpChoices.SetRow(this.txtChoiceB, 1);
            this.txtChoiceB.Size = new System.Drawing.Size(426, 24);
            this.txtChoiceB.TabIndex = 5;
            // 
            // txtChoiceC
            // 
            this.txtChoiceC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoices.SetColumn(this.txtChoiceC, 1);
            this.txtChoiceC.EditValue = " ";
            this.txtChoiceC.Location = new System.Drawing.Point(27, 59);
            this.txtChoiceC.Name = "txtChoiceC";
            this.txtChoiceC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtChoiceC.Properties.Appearance.Options.UseFont = true;
            this.tbpChoices.SetRow(this.txtChoiceC, 2);
            this.txtChoiceC.Size = new System.Drawing.Size(426, 24);
            this.txtChoiceC.TabIndex = 5;
            // 
            // txtChoiceD
            // 
            this.txtChoiceD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoices.SetColumn(this.txtChoiceD, 1);
            this.txtChoiceD.EditValue = " ";
            this.txtChoiceD.Location = new System.Drawing.Point(27, 87);
            this.txtChoiceD.Name = "txtChoiceD";
            this.txtChoiceD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtChoiceD.Properties.Appearance.Options.UseFont = true;
            this.tbpChoices.SetRow(this.txtChoiceD, 3);
            this.txtChoiceD.Size = new System.Drawing.Size(426, 24);
            this.txtChoiceD.TabIndex = 5;
            // 
            // imgChoiceB
            // 
            this.imgChoiceB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoices.SetColumn(this.imgChoiceB, 2);
            this.imgChoiceB.Location = new System.Drawing.Point(459, 31);
            this.imgChoiceB.Name = "imgChoiceB";
            this.imgChoiceB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imgChoiceB.Properties.Appearance.Options.UseFont = true;
            this.imgChoiceB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbpChoices.SetRow(this.imgChoiceB, 1);
            this.imgChoiceB.Size = new System.Drawing.Size(426, 24);
            this.imgChoiceB.TabIndex = 5;
            // 
            // imgChoiceC
            // 
            this.imgChoiceC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoices.SetColumn(this.imgChoiceC, 2);
            this.imgChoiceC.Location = new System.Drawing.Point(459, 59);
            this.imgChoiceC.Name = "imgChoiceC";
            this.imgChoiceC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imgChoiceC.Properties.Appearance.Options.UseFont = true;
            this.imgChoiceC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbpChoices.SetRow(this.imgChoiceC, 2);
            this.imgChoiceC.Size = new System.Drawing.Size(426, 24);
            this.imgChoiceC.TabIndex = 5;
            // 
            // imgChoiceD
            // 
            this.imgChoiceD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbpChoices.SetColumn(this.imgChoiceD, 2);
            this.imgChoiceD.Location = new System.Drawing.Point(459, 87);
            this.imgChoiceD.Name = "imgChoiceD";
            this.imgChoiceD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imgChoiceD.Properties.Appearance.Options.UseFont = true;
            this.imgChoiceD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbpChoices.SetRow(this.imgChoiceD, 3);
            this.imgChoiceD.Size = new System.Drawing.Size(426, 24);
            this.imgChoiceD.TabIndex = 5;
            // 
            // tbpSave
            // 
            this.tbpSave.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpSave.Appearance.Options.UseBackColor = true;
            this.tbpMain.SetColumn(this.tbpSave, 1);
            this.tbpSave.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpSave.Controls.Add(this.btnSaveQuestion);
            this.tbpSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpSave.Location = new System.Drawing.Point(903, 3);
            this.tbpSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpSave.Name = "tbpSave";
            this.tbpMain.SetRow(this.tbpSave, 0);
            this.tbpSave.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpSave.Size = new System.Drawing.Size(254, 617);
            this.tbpSave.TabIndex = 1;
            // 
            // btnSaveQuestion
            // 
            this.tbpSave.SetColumn(this.btnSaveQuestion, 0);
            this.btnSaveQuestion.Location = new System.Drawing.Point(3, 496);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.tbpSave.SetRow(this.btnSaveQuestion, 3);
            this.btnSaveQuestion.Size = new System.Drawing.Size(248, 87);
            this.btnSaveQuestion.TabIndex = 0;
            this.btnSaveQuestion.Text = "Soruyu Kaydet";
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // FrmExaminerQuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 623);
            this.Controls.Add(this.tbpMain);
            this.Name = "FrmExaminerQuestionAdd";
            this.Text = "FrmExaminerQuestionAdd";
            this.Load += new System.EventHandler(this.FrmExaminerQuestionAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).EndInit();
            this.tbpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestion)).EndInit();
            this.tbpQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbpTitle)).EndInit();
            this.tbpTitle.ResumeLayout(false);
            this.tbpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLecture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpChoiceFormat)).EndInit();
            this.tbpChoiceFormat.ResumeLayout(false);
            this.tbpChoiceFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueChoiceFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpChoices)).EndInit();
            this.tbpChoices.ResumeLayout(false);
            this.tbpChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoiceA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoiceA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoiceB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoiceC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoiceD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoiceB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoiceC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoiceD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpSave)).EndInit();
            this.tbpSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tbpMain;
        private DevExpress.Utils.Layout.TablePanel tbpQuestion;
        private DevExpress.Utils.Layout.TablePanel tbpTitle;
        private DevExpress.XtraEditors.LabelControl lblSection;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.XtraEditors.LabelControl lblLecture;
        private DevExpress.XtraRichEdit.RichEditControl rtbQuestion;
        private DevExpress.XtraEditors.LookUpEdit lueSection;
        private DevExpress.XtraEditors.LookUpEdit lueUnit;
        private DevExpress.XtraEditors.LookUpEdit lueLecture;
        private DevExpress.Utils.Layout.TablePanel tbpChoiceFormat;
        private DevExpress.XtraEditors.LookUpEdit lueChoiceFormat;
        private DevExpress.XtraEditors.LabelControl lblChoiceFormat;
        private DevExpress.Utils.Layout.TablePanel tbpChoices;
        private DevExpress.XtraEditors.ImageEdit imgChoiceA;
        private DevExpress.XtraEditors.TextEdit txtChoiceA;
        private DevExpress.XtraEditors.LabelControl lblChoiceA;
        private DevExpress.XtraEditors.LabelControl lblChoiceB;
        private DevExpress.XtraEditors.LabelControl lblChoiceC;
        private DevExpress.XtraEditors.LabelControl lblChoiceD;
        private DevExpress.XtraEditors.ImageEdit imgChoiceD;
        private DevExpress.XtraEditors.ImageEdit imgChoiceC;
        private DevExpress.XtraEditors.ImageEdit imgChoiceB;
        private DevExpress.XtraEditors.TextEdit txtChoiceD;
        private DevExpress.XtraEditors.TextEdit txtChoiceC;
        private DevExpress.XtraEditors.TextEdit txtChoiceB;
        private DevExpress.Utils.Layout.TablePanel tbpSave;
        private DevExpress.XtraEditors.SimpleButton btnSaveQuestion;
    }
}