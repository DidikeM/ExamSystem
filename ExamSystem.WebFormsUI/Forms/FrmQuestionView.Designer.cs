
namespace ExamSystem.WebFormsUI.Forms
{
    partial class FrmQuestionView
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
            this.tbpChoice = new DevExpress.Utils.Layout.TablePanel();
            this.lblTableText = new DevExpress.XtraEditors.LabelControl();
            this.picChoiceD = new DevExpress.XtraEditors.PictureEdit();
            this.picChoiceC = new DevExpress.XtraEditors.PictureEdit();
            this.picChoiceB = new DevExpress.XtraEditors.PictureEdit();
            this.picChoiceA = new DevExpress.XtraEditors.PictureEdit();
            this.lblChoiceD = new DevExpress.XtraEditors.LabelControl();
            this.lblChoiceC = new DevExpress.XtraEditors.LabelControl();
            this.lblChoiceB = new DevExpress.XtraEditors.LabelControl();
            this.lblChoiceA = new DevExpress.XtraEditors.LabelControl();
            this.tbpQuestionİnfo = new DevExpress.Utils.Layout.TablePanel();
            this.lblSectionNameValue = new DevExpress.XtraEditors.LabelControl();
            this.lblUnitNameValue = new DevExpress.XtraEditors.LabelControl();
            this.lblLectureNameValue = new DevExpress.XtraEditors.LabelControl();
            this.lblSectionNumberValue = new DevExpress.XtraEditors.LabelControl();
            this.lblUnitNumberValue = new DevExpress.XtraEditors.LabelControl();
            this.lblgradeNumberValue = new DevExpress.XtraEditors.LabelControl();
            this.lblSectionName = new DevExpress.XtraEditors.LabelControl();
            this.lblUnitName = new DevExpress.XtraEditors.LabelControl();
            this.lblLectureName = new DevExpress.XtraEditors.LabelControl();
            this.lblSectionNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblUnitNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblgradeNumber = new DevExpress.XtraEditors.LabelControl();
            this.rtbQuestion = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).BeginInit();
            this.tbpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestion)).BeginInit();
            this.tbpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpChoice)).BeginInit();
            this.tbpChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiceD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiceC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiceB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiceA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestionİnfo)).BeginInit();
            this.tbpQuestionİnfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpMain.Appearance.Options.UseBackColor = true;
            this.tbpMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 1240F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Controls.Add(this.tbpQuestion);
            this.tbpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMain.Location = new System.Drawing.Point(0, 0);
            this.tbpMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Size = new System.Drawing.Size(1439, 677);
            this.tbpMain.TabIndex = 0;
            // 
            // tbpQuestion
            // 
            this.tbpQuestion.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpQuestion.Appearance.Options.UseBackColor = true;
            this.tbpMain.SetColumn(this.tbpQuestion, 1);
            this.tbpQuestion.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpQuestion.Controls.Add(this.tbpChoice);
            this.tbpQuestion.Controls.Add(this.tbpQuestionİnfo);
            this.tbpQuestion.Controls.Add(this.rtbQuestion);
            this.tbpQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpQuestion.Location = new System.Drawing.Point(103, 3);
            this.tbpQuestion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpQuestion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpQuestion.Name = "tbpQuestion";
            this.tbpMain.SetRow(this.tbpQuestion, 0);
            this.tbpQuestion.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 400F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpQuestion.Size = new System.Drawing.Size(1234, 671);
            this.tbpQuestion.TabIndex = 0;
            // 
            // tbpChoice
            // 
            this.tbpChoice.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpChoice.Appearance.Options.UseBackColor = true;
            this.tbpQuestion.SetColumn(this.tbpChoice, 0);
            this.tbpChoice.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tbpChoice.Controls.Add(this.lblTableText);
            this.tbpChoice.Controls.Add(this.picChoiceD);
            this.tbpChoice.Controls.Add(this.picChoiceC);
            this.tbpChoice.Controls.Add(this.picChoiceB);
            this.tbpChoice.Controls.Add(this.picChoiceA);
            this.tbpChoice.Controls.Add(this.lblChoiceD);
            this.tbpChoice.Controls.Add(this.lblChoiceC);
            this.tbpChoice.Controls.Add(this.lblChoiceB);
            this.tbpChoice.Controls.Add(this.lblChoiceA);
            this.tbpChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpChoice.Location = new System.Drawing.Point(3, 503);
            this.tbpChoice.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.tbpChoice.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbpChoice.Name = "tbpChoice";
            this.tbpQuestion.SetRow(this.tbpChoice, 2);
            this.tbpChoice.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpChoice.Size = new System.Drawing.Size(1228, 165);
            this.tbpChoice.TabIndex = 3;
            // 
            // lblTableText
            // 
            this.tbpChoice.SetColumn(this.lblTableText, 0);
            this.lblTableText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableText.Location = new System.Drawing.Point(0, 0);
            this.lblTableText.Name = "lblTableText";
            this.tbpChoice.SetRow(this.lblTableText, 0);
            this.lblTableText.Size = new System.Drawing.Size(0, 0);
            this.lblTableText.TabIndex = 7;
            this.lblTableText.Text = "    ";
            // 
            // picChoiceD
            // 
            this.tbpChoice.SetColumn(this.picChoiceD, 1);
            this.picChoiceD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picChoiceD.Location = new System.Drawing.Point(37, 126);
            this.picChoiceD.Name = "picChoiceD";
            this.picChoiceD.Properties.AllowFocused = false;
            this.picChoiceD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picChoiceD.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.picChoiceD.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.picChoiceD.Properties.NullText = " ";
            this.picChoiceD.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.picChoiceD.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.tbpChoice.SetRow(this.picChoiceD, 4);
            this.picChoiceD.Size = new System.Drawing.Size(1188, 36);
            this.picChoiceD.TabIndex = 6;
            this.picChoiceD.Click += new System.EventHandler(this.ChoiceD_Click);
            // 
            // picChoiceC
            // 
            this.tbpChoice.SetColumn(this.picChoiceC, 1);
            this.picChoiceC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picChoiceC.Location = new System.Drawing.Point(37, 85);
            this.picChoiceC.Name = "picChoiceC";
            this.picChoiceC.Properties.AllowFocused = false;
            this.picChoiceC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picChoiceC.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.picChoiceC.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.picChoiceC.Properties.NullText = " ";
            this.picChoiceC.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.picChoiceC.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.tbpChoice.SetRow(this.picChoiceC, 3);
            this.picChoiceC.Size = new System.Drawing.Size(1188, 35);
            this.picChoiceC.TabIndex = 6;
            this.picChoiceC.Click += new System.EventHandler(this.ChoiceC_Click);
            // 
            // picChoiceB
            // 
            this.tbpChoice.SetColumn(this.picChoiceB, 1);
            this.picChoiceB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picChoiceB.Location = new System.Drawing.Point(37, 44);
            this.picChoiceB.Name = "picChoiceB";
            this.picChoiceB.Properties.AllowFocused = false;
            this.picChoiceB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picChoiceB.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.picChoiceB.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.picChoiceB.Properties.NullText = " ";
            this.picChoiceB.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.picChoiceB.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.tbpChoice.SetRow(this.picChoiceB, 2);
            this.picChoiceB.Size = new System.Drawing.Size(1188, 35);
            this.picChoiceB.TabIndex = 6;
            this.picChoiceB.Click += new System.EventHandler(this.ChoiceB_Click);
            // 
            // picChoiceA
            // 
            this.tbpChoice.SetColumn(this.picChoiceA, 1);
            this.picChoiceA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picChoiceA.Location = new System.Drawing.Point(37, 3);
            this.picChoiceA.Name = "picChoiceA";
            this.picChoiceA.Properties.AllowFocused = false;
            this.picChoiceA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picChoiceA.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.picChoiceA.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.picChoiceA.Properties.NullText = " ";
            this.picChoiceA.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.picChoiceA.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.tbpChoice.SetRow(this.picChoiceA, 1);
            this.picChoiceA.Size = new System.Drawing.Size(1188, 35);
            this.picChoiceA.TabIndex = 5;
            this.picChoiceA.Click += new System.EventHandler(this.ChoiceA_Click);
            // 
            // lblChoiceD
            // 
            this.lblChoiceD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChoiceD.Appearance.Options.UseFont = true;
            this.tbpChoice.SetColumn(this.lblChoiceD, 0);
            this.lblChoiceD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceD.Location = new System.Drawing.Point(3, 126);
            this.lblChoiceD.Name = "lblChoiceD";
            this.tbpChoice.SetRow(this.lblChoiceD, 4);
            this.lblChoiceD.Size = new System.Drawing.Size(28, 36);
            this.lblChoiceD.TabIndex = 4;
            this.lblChoiceD.Text = "D-) ";
            this.lblChoiceD.Click += new System.EventHandler(this.ChoiceD_Click);
            // 
            // lblChoiceC
            // 
            this.lblChoiceC.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChoiceC.Appearance.Options.UseFont = true;
            this.tbpChoice.SetColumn(this.lblChoiceC, 0);
            this.lblChoiceC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceC.Location = new System.Drawing.Point(3, 85);
            this.lblChoiceC.Name = "lblChoiceC";
            this.tbpChoice.SetRow(this.lblChoiceC, 3);
            this.lblChoiceC.Size = new System.Drawing.Size(28, 35);
            this.lblChoiceC.TabIndex = 4;
            this.lblChoiceC.Text = "C-) ";
            this.lblChoiceC.Click += new System.EventHandler(this.ChoiceC_Click);
            // 
            // lblChoiceB
            // 
            this.lblChoiceB.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChoiceB.Appearance.Options.UseFont = true;
            this.tbpChoice.SetColumn(this.lblChoiceB, 0);
            this.lblChoiceB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceB.Location = new System.Drawing.Point(3, 44);
            this.lblChoiceB.Name = "lblChoiceB";
            this.tbpChoice.SetRow(this.lblChoiceB, 2);
            this.lblChoiceB.Size = new System.Drawing.Size(28, 35);
            this.lblChoiceB.TabIndex = 4;
            this.lblChoiceB.Text = "B-) ";
            this.lblChoiceB.Click += new System.EventHandler(this.ChoiceB_Click);
            // 
            // lblChoiceA
            // 
            this.lblChoiceA.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChoiceA.Appearance.Options.UseFont = true;
            this.tbpChoice.SetColumn(this.lblChoiceA, 0);
            this.lblChoiceA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChoiceA.Location = new System.Drawing.Point(3, 3);
            this.lblChoiceA.Name = "lblChoiceA";
            this.tbpChoice.SetRow(this.lblChoiceA, 1);
            this.lblChoiceA.Size = new System.Drawing.Size(28, 35);
            this.lblChoiceA.TabIndex = 0;
            this.lblChoiceA.Text = "A-) ";
            this.lblChoiceA.Click += new System.EventHandler(this.ChoiceA_Click);
            // 
            // tbpQuestionİnfo
            // 
            this.tbpQuestionİnfo.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpQuestionİnfo.Appearance.Options.UseBackColor = true;
            this.tbpQuestion.SetColumn(this.tbpQuestionİnfo, 0);
            this.tbpQuestionİnfo.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpQuestionİnfo.Controls.Add(this.lblSectionNameValue);
            this.tbpQuestionİnfo.Controls.Add(this.lblUnitNameValue);
            this.tbpQuestionİnfo.Controls.Add(this.lblLectureNameValue);
            this.tbpQuestionİnfo.Controls.Add(this.lblSectionNumberValue);
            this.tbpQuestionİnfo.Controls.Add(this.lblUnitNumberValue);
            this.tbpQuestionİnfo.Controls.Add(this.lblgradeNumberValue);
            this.tbpQuestionİnfo.Controls.Add(this.lblSectionName);
            this.tbpQuestionİnfo.Controls.Add(this.lblUnitName);
            this.tbpQuestionİnfo.Controls.Add(this.lblLectureName);
            this.tbpQuestionİnfo.Controls.Add(this.lblSectionNumber);
            this.tbpQuestionİnfo.Controls.Add(this.lblUnitNumber);
            this.tbpQuestionİnfo.Controls.Add(this.lblgradeNumber);
            this.tbpQuestionİnfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpQuestionİnfo.Location = new System.Drawing.Point(0, 0);
            this.tbpQuestionİnfo.Margin = new System.Windows.Forms.Padding(0);
            this.tbpQuestionİnfo.Name = "tbpQuestionİnfo";
            this.tbpQuestion.SetRow(this.tbpQuestionİnfo, 0);
            this.tbpQuestionİnfo.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpQuestionİnfo.Size = new System.Drawing.Size(1234, 100);
            this.tbpQuestionİnfo.TabIndex = 2;
            // 
            // lblSectionNameValue
            // 
            this.lblSectionNameValue.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSectionNameValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblSectionNameValue, 3);
            this.lblSectionNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionNameValue.Location = new System.Drawing.Point(929, 69);
            this.lblSectionNameValue.Name = "lblSectionNameValue";
            this.tbpQuestionİnfo.SetRow(this.lblSectionNameValue, 2);
            this.lblSectionNameValue.Size = new System.Drawing.Size(303, 28);
            this.lblSectionNameValue.TabIndex = 6;
            this.lblSectionNameValue.Text = "Value";
            // 
            // lblUnitNameValue
            // 
            this.lblUnitNameValue.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnitNameValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblUnitNameValue, 3);
            this.lblUnitNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitNameValue.Location = new System.Drawing.Point(929, 36);
            this.lblUnitNameValue.Name = "lblUnitNameValue";
            this.tbpQuestionİnfo.SetRow(this.lblUnitNameValue, 1);
            this.lblUnitNameValue.Size = new System.Drawing.Size(303, 27);
            this.lblUnitNameValue.TabIndex = 5;
            this.lblUnitNameValue.Text = "Value";
            // 
            // lblLectureNameValue
            // 
            this.lblLectureNameValue.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLectureNameValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblLectureNameValue, 3);
            this.lblLectureNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLectureNameValue.Location = new System.Drawing.Point(929, 3);
            this.lblLectureNameValue.Name = "lblLectureNameValue";
            this.tbpQuestionİnfo.SetRow(this.lblLectureNameValue, 0);
            this.lblLectureNameValue.Size = new System.Drawing.Size(303, 27);
            this.lblLectureNameValue.TabIndex = 4;
            this.lblLectureNameValue.Text = "Value";
            // 
            // lblSectionNumberValue
            // 
            this.lblSectionNumberValue.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSectionNumberValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblSectionNumberValue, 1);
            this.lblSectionNumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionNumberValue.Location = new System.Drawing.Point(312, 69);
            this.lblSectionNumberValue.Name = "lblSectionNumberValue";
            this.tbpQuestionİnfo.SetRow(this.lblSectionNumberValue, 2);
            this.lblSectionNumberValue.Size = new System.Drawing.Size(303, 28);
            this.lblSectionNumberValue.TabIndex = 3;
            this.lblSectionNumberValue.Text = "Value";
            // 
            // lblUnitNumberValue
            // 
            this.lblUnitNumberValue.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnitNumberValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblUnitNumberValue, 1);
            this.lblUnitNumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitNumberValue.Location = new System.Drawing.Point(312, 36);
            this.lblUnitNumberValue.Name = "lblUnitNumberValue";
            this.tbpQuestionİnfo.SetRow(this.lblUnitNumberValue, 1);
            this.lblUnitNumberValue.Size = new System.Drawing.Size(303, 27);
            this.lblUnitNumberValue.TabIndex = 2;
            this.lblUnitNumberValue.Text = "Value";
            // 
            // lblgradeNumberValue
            // 
            this.lblgradeNumberValue.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblgradeNumberValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblgradeNumberValue, 1);
            this.lblgradeNumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblgradeNumberValue.Location = new System.Drawing.Point(312, 3);
            this.lblgradeNumberValue.Name = "lblgradeNumberValue";
            this.tbpQuestionİnfo.SetRow(this.lblgradeNumberValue, 0);
            this.lblgradeNumberValue.Size = new System.Drawing.Size(303, 27);
            this.lblgradeNumberValue.TabIndex = 1;
            this.lblgradeNumberValue.Text = "Value";
            // 
            // lblSectionName
            // 
            this.lblSectionName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSectionName.Appearance.Options.UseFont = true;
            this.lblSectionName.Appearance.Options.UseTextOptions = true;
            this.lblSectionName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblSectionName, 2);
            this.lblSectionName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionName.Location = new System.Drawing.Point(620, 69);
            this.lblSectionName.Name = "lblSectionName";
            this.tbpQuestionİnfo.SetRow(this.lblSectionName, 2);
            this.lblSectionName.Size = new System.Drawing.Size(303, 28);
            this.lblSectionName.TabIndex = 5;
            this.lblSectionName.Text = "Konu Adı:";
            // 
            // lblUnitName
            // 
            this.lblUnitName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnitName.Appearance.Options.UseFont = true;
            this.lblUnitName.Appearance.Options.UseTextOptions = true;
            this.lblUnitName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblUnitName, 2);
            this.lblUnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitName.Location = new System.Drawing.Point(620, 36);
            this.lblUnitName.Name = "lblUnitName";
            this.tbpQuestionİnfo.SetRow(this.lblUnitName, 1);
            this.lblUnitName.Size = new System.Drawing.Size(303, 27);
            this.lblUnitName.TabIndex = 4;
            this.lblUnitName.Text = "Ünite Adı:";
            // 
            // lblLectureName
            // 
            this.lblLectureName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLectureName.Appearance.Options.UseFont = true;
            this.lblLectureName.Appearance.Options.UseTextOptions = true;
            this.lblLectureName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblLectureName, 2);
            this.lblLectureName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLectureName.Location = new System.Drawing.Point(620, 3);
            this.lblLectureName.Name = "lblLectureName";
            this.tbpQuestionİnfo.SetRow(this.lblLectureName, 0);
            this.lblLectureName.Size = new System.Drawing.Size(303, 27);
            this.lblLectureName.TabIndex = 3;
            this.lblLectureName.Text = "Dersin Adı:";
            // 
            // lblSectionNumber
            // 
            this.lblSectionNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSectionNumber.Appearance.Options.UseFont = true;
            this.lblSectionNumber.Appearance.Options.UseTextOptions = true;
            this.lblSectionNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblSectionNumber, 0);
            this.lblSectionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionNumber.Location = new System.Drawing.Point(3, 69);
            this.lblSectionNumber.Name = "lblSectionNumber";
            this.tbpQuestionİnfo.SetRow(this.lblSectionNumber, 2);
            this.lblSectionNumber.Size = new System.Drawing.Size(303, 28);
            this.lblSectionNumber.TabIndex = 2;
            this.lblSectionNumber.Text = "Konu No:";
            // 
            // lblUnitNumber
            // 
            this.lblUnitNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnitNumber.Appearance.Options.UseFont = true;
            this.lblUnitNumber.Appearance.Options.UseTextOptions = true;
            this.lblUnitNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblUnitNumber, 0);
            this.lblUnitNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitNumber.Location = new System.Drawing.Point(3, 36);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.tbpQuestionİnfo.SetRow(this.lblUnitNumber, 1);
            this.lblUnitNumber.Size = new System.Drawing.Size(303, 27);
            this.lblUnitNumber.TabIndex = 1;
            this.lblUnitNumber.Text = "Ünite No:";
            // 
            // lblgradeNumber
            // 
            this.lblgradeNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblgradeNumber.Appearance.Options.UseFont = true;
            this.lblgradeNumber.Appearance.Options.UseTextOptions = true;
            this.lblgradeNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblgradeNumber, 0);
            this.lblgradeNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblgradeNumber.Location = new System.Drawing.Point(3, 3);
            this.lblgradeNumber.Name = "lblgradeNumber";
            this.tbpQuestionİnfo.SetRow(this.lblgradeNumber, 0);
            this.lblgradeNumber.Size = new System.Drawing.Size(303, 27);
            this.lblgradeNumber.TabIndex = 0;
            this.lblgradeNumber.Text = "Sınıf Düzeyi:";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rtbQuestion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tbpQuestion.SetColumn(this.rtbQuestion, 0);
            this.rtbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbQuestion.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.rtbQuestion.Location = new System.Drawing.Point(3, 103);
            this.rtbQuestion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.rtbQuestion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Options.Behavior.ShowPopupMenu = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
            this.rtbQuestion.ReadOnly = true;
            this.tbpQuestion.SetRow(this.rtbQuestion, 1);
            this.rtbQuestion.ShowCaretInReadOnly = false;
            this.rtbQuestion.Size = new System.Drawing.Size(1228, 394);
            this.rtbQuestion.TabIndex = 0;
            // 
            // FrmQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 677);
            this.Controls.Add(this.tbpMain);
            this.Name = "FrmQuestionView";
            this.Text = "FrmQuestionView";
            this.Load += new System.EventHandler(this.FrmQuestionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).EndInit();
            this.tbpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestion)).EndInit();
            this.tbpQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbpChoice)).EndInit();
            this.tbpChoice.ResumeLayout(false);
            this.tbpChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiceD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiceC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiceB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiceA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestionİnfo)).EndInit();
            this.tbpQuestionİnfo.ResumeLayout(false);
            this.tbpQuestionİnfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tbpMain;
        private DevExpress.Utils.Layout.TablePanel tbpQuestion;
        private DevExpress.XtraRichEdit.RichEditControl rtbQuestion;
        private DevExpress.Utils.Layout.TablePanel tbpQuestionİnfo;
        private DevExpress.XtraEditors.LabelControl lblSectionNameValue;
        private DevExpress.XtraEditors.LabelControl lblUnitNameValue;
        private DevExpress.XtraEditors.LabelControl lblLectureNameValue;
        private DevExpress.XtraEditors.LabelControl lblSectionNumberValue;
        private DevExpress.XtraEditors.LabelControl lblUnitNumberValue;
        private DevExpress.XtraEditors.LabelControl lblgradeNumberValue;
        private DevExpress.XtraEditors.LabelControl lblSectionName;
        private DevExpress.XtraEditors.LabelControl lblUnitName;
        private DevExpress.XtraEditors.LabelControl lblLectureName;
        private DevExpress.XtraEditors.LabelControl lblSectionNumber;
        private DevExpress.XtraEditors.LabelControl lblUnitNumber;
        private DevExpress.XtraEditors.LabelControl lblgradeNumber;
        private DevExpress.Utils.Layout.TablePanel tbpChoice;
        private DevExpress.XtraEditors.LabelControl lblChoiceD;
        private DevExpress.XtraEditors.LabelControl lblChoiceC;
        private DevExpress.XtraEditors.LabelControl lblChoiceB;
        private DevExpress.XtraEditors.LabelControl lblChoiceA;
        private DevExpress.XtraEditors.PictureEdit picChoiceD;
        private DevExpress.XtraEditors.PictureEdit picChoiceC;
        private DevExpress.XtraEditors.PictureEdit picChoiceB;
        private DevExpress.XtraEditors.PictureEdit picChoiceA;
        private DevExpress.XtraEditors.LabelControl lblTableText;
    }
}