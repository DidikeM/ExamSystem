
namespace ExamSystem.WebFormsUI.Forms.StudentForms
{
    partial class FrmStudentSectionSelect
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
            this.btnStartExam = new DevExpress.XtraEditors.SimpleButton();
            this.lueLecture = new DevExpress.XtraEditors.LookUpEdit();
            this.lueUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.lueSection = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLecture = new DevExpress.XtraEditors.LabelControl();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lblSection = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lueLecture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartExam
            // 
            this.btnStartExam.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartExam.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnStartExam, 6);
            this.btnStartExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartExam.Location = new System.Drawing.Point(1052, 3);
            this.btnStartExam.Name = "btnStartExam";
            this.tablePanel1.SetRow(this.btnStartExam, 0);
            this.btnStartExam.Size = new System.Drawing.Size(169, 68);
            this.btnStartExam.TabIndex = 7;
            this.btnStartExam.Text = "Sınavı Başlat";
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // lueLecture
            // 
            this.tablePanel1.SetColumn(this.lueLecture, 1);
            this.lueLecture.Location = new System.Drawing.Point(178, 24);
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
            this.lueLecture.Properties.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lueLecture_Properties_Closed);
            this.tablePanel1.SetRow(this.lueLecture, 0);
            this.lueLecture.Size = new System.Drawing.Size(169, 26);
            this.lueLecture.TabIndex = 8;
            // 
            // lueUnit
            // 
            this.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tablePanel1.SetColumn(this.lueUnit, 3);
            this.lueUnit.Location = new System.Drawing.Point(528, 24);
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
            this.tablePanel1.SetRow(this.lueUnit, 0);
            this.lueUnit.Size = new System.Drawing.Size(169, 26);
            this.lueUnit.TabIndex = 9;
            this.lueUnit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lueUnit_Closed);
            // 
            // lueSection
            // 
            this.lueSection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tablePanel1.SetColumn(this.lueSection, 5);
            this.lueSection.Location = new System.Drawing.Point(877, 24);
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
            this.tablePanel1.SetRow(this.lueSection, 0);
            this.lueSection.Size = new System.Drawing.Size(169, 26);
            this.lueSection.TabIndex = 10;
            // 
            // lblLecture
            // 
            this.lblLecture.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLecture.Appearance.Options.UseFont = true;
            this.lblLecture.Appearance.Options.UseTextOptions = true;
            this.lblLecture.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblLecture.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.lblLecture, 0);
            this.lblLecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLecture.Location = new System.Drawing.Point(3, 3);
            this.lblLecture.Name = "lblLecture";
            this.tablePanel1.SetRow(this.lblLecture, 0);
            this.lblLecture.Size = new System.Drawing.Size(169, 68);
            this.lblLecture.TabIndex = 11;
            this.lblLecture.Text = "Ders";
            // 
            // lblUnit
            // 
            this.lblUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnit.Appearance.Options.UseFont = true;
            this.lblUnit.Appearance.Options.UseTextOptions = true;
            this.lblUnit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblUnit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.lblUnit, 2);
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(353, 3);
            this.lblUnit.Name = "lblUnit";
            this.tablePanel1.SetRow(this.lblUnit, 0);
            this.lblUnit.Size = new System.Drawing.Size(169, 68);
            this.lblUnit.TabIndex = 12;
            this.lblUnit.Text = "Ünite";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.lblSection);
            this.tablePanel1.Controls.Add(this.lblUnit);
            this.tablePanel1.Controls.Add(this.lblLecture);
            this.tablePanel1.Controls.Add(this.lueSection);
            this.tablePanel1.Controls.Add(this.lueUnit);
            this.tablePanel1.Controls.Add(this.lueLecture);
            this.tablePanel1.Controls.Add(this.btnStartExam);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 350F)});
            this.tablePanel1.Size = new System.Drawing.Size(1224, 591);
            this.tablePanel1.TabIndex = 0;
            // 
            // lblSection
            // 
            this.lblSection.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSection.Appearance.Options.UseFont = true;
            this.lblSection.Appearance.Options.UseTextOptions = true;
            this.lblSection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblSection.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.lblSection, 4);
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSection.Location = new System.Drawing.Point(702, 3);
            this.lblSection.Name = "lblSection";
            this.tablePanel1.SetRow(this.lblSection, 0);
            this.lblSection.Size = new System.Drawing.Size(169, 68);
            this.lblSection.TabIndex = 13;
            this.lblSection.Text = "Konu";
            // 
            // FrmStudentSectionSelect
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 591);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmStudentSectionSelect";
            this.Text = "FrmStudentSectionExam";
            this.Load += new System.EventHandler(this.FrmStudentSectionExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueLecture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStartExam;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.XtraEditors.LabelControl lblLecture;
        private DevExpress.XtraEditors.LookUpEdit lueSection;
        private DevExpress.XtraEditors.LookUpEdit lueUnit;
        private DevExpress.XtraEditors.LookUpEdit lueLecture;
        private DevExpress.XtraEditors.LabelControl lblSection;
    }
}