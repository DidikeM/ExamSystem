
using System.Windows.Forms;

namespace TestProject.TestForms
{
    partial class UcQuestionView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbpQuestion = new DevExpress.Utils.Layout.TablePanel();
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
            this.recQuestion = new DevExpress.XtraRichEdit.RichEditControl();
            this.tbpMain = new DevExpress.Utils.Layout.TablePanel();
            this.rdgChoices = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestion)).BeginInit();
            this.tbpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestionİnfo)).BeginInit();
            this.tbpQuestionİnfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).BeginInit();
            this.tbpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgChoices.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpQuestion
            // 
            this.tbpQuestion.AutoScroll = true;
            this.tbpQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbpMain.SetColumn(this.tbpQuestion, 1);
            this.tbpQuestion.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpQuestion.Controls.Add(this.rdgChoices);
            this.tbpQuestion.Controls.Add(this.tbpQuestionİnfo);
            this.tbpQuestion.Controls.Add(this.recQuestion);
            this.tbpQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpQuestion.Location = new System.Drawing.Point(77, 0);
            this.tbpQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.tbpQuestion.Name = "tbpQuestion";
            this.tbpMain.SetRow(this.tbpQuestion, 0);
            this.tbpQuestion.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 500F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tbpQuestion.Size = new System.Drawing.Size(1240, 678);
            this.tbpQuestion.TabIndex = 0;
            this.tbpQuestion.Paint += new System.Windows.Forms.PaintEventHandler(this.tbMain_Paint);
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
            this.tbpQuestionİnfo.Size = new System.Drawing.Size(1240, 100);
            this.tbpQuestionİnfo.TabIndex = 1;
            // 
            // lblSectionNameValue
            // 
            this.lblSectionNameValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSectionNameValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblSectionNameValue, 3);
            this.lblSectionNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionNameValue.Location = new System.Drawing.Point(933, 69);
            this.lblSectionNameValue.Name = "lblSectionNameValue";
            this.tbpQuestionİnfo.SetRow(this.lblSectionNameValue, 2);
            this.lblSectionNameValue.Size = new System.Drawing.Size(304, 28);
            this.lblSectionNameValue.TabIndex = 6;
            this.lblSectionNameValue.Text = "Value";
            // 
            // lblUnitNameValue
            // 
            this.lblUnitNameValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitNameValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblUnitNameValue, 3);
            this.lblUnitNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitNameValue.Location = new System.Drawing.Point(933, 36);
            this.lblUnitNameValue.Name = "lblUnitNameValue";
            this.tbpQuestionİnfo.SetRow(this.lblUnitNameValue, 1);
            this.lblUnitNameValue.Size = new System.Drawing.Size(304, 27);
            this.lblUnitNameValue.TabIndex = 5;
            this.lblUnitNameValue.Text = "Value";
            // 
            // lblLectureNameValue
            // 
            this.lblLectureNameValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLectureNameValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblLectureNameValue, 3);
            this.lblLectureNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLectureNameValue.Location = new System.Drawing.Point(933, 3);
            this.lblLectureNameValue.Name = "lblLectureNameValue";
            this.tbpQuestionİnfo.SetRow(this.lblLectureNameValue, 0);
            this.lblLectureNameValue.Size = new System.Drawing.Size(304, 27);
            this.lblLectureNameValue.TabIndex = 4;
            this.lblLectureNameValue.Text = "Value";
            // 
            // lblSectionNumberValue
            // 
            this.lblSectionNumberValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSectionNumberValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblSectionNumberValue, 1);
            this.lblSectionNumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionNumberValue.Location = new System.Drawing.Point(313, 69);
            this.lblSectionNumberValue.Name = "lblSectionNumberValue";
            this.tbpQuestionİnfo.SetRow(this.lblSectionNumberValue, 2);
            this.lblSectionNumberValue.Size = new System.Drawing.Size(304, 28);
            this.lblSectionNumberValue.TabIndex = 3;
            this.lblSectionNumberValue.Text = "Value";
            // 
            // lblUnitNumberValue
            // 
            this.lblUnitNumberValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitNumberValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblUnitNumberValue, 1);
            this.lblUnitNumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitNumberValue.Location = new System.Drawing.Point(313, 36);
            this.lblUnitNumberValue.Name = "lblUnitNumberValue";
            this.tbpQuestionİnfo.SetRow(this.lblUnitNumberValue, 1);
            this.lblUnitNumberValue.Size = new System.Drawing.Size(304, 27);
            this.lblUnitNumberValue.TabIndex = 2;
            this.lblUnitNumberValue.Text = "Value";
            // 
            // lblgradeNumberValue
            // 
            this.lblgradeNumberValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblgradeNumberValue.Appearance.Options.UseFont = true;
            this.tbpQuestionİnfo.SetColumn(this.lblgradeNumberValue, 1);
            this.lblgradeNumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblgradeNumberValue.Location = new System.Drawing.Point(313, 3);
            this.lblgradeNumberValue.Name = "lblgradeNumberValue";
            this.tbpQuestionİnfo.SetRow(this.lblgradeNumberValue, 0);
            this.lblgradeNumberValue.Size = new System.Drawing.Size(304, 27);
            this.lblgradeNumberValue.TabIndex = 1;
            this.lblgradeNumberValue.Text = "Value";
            // 
            // lblSectionName
            // 
            this.lblSectionName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSectionName.Appearance.Options.UseFont = true;
            this.lblSectionName.Appearance.Options.UseTextOptions = true;
            this.lblSectionName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblSectionName, 2);
            this.lblSectionName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionName.Location = new System.Drawing.Point(623, 69);
            this.lblSectionName.Name = "lblSectionName";
            this.tbpQuestionİnfo.SetRow(this.lblSectionName, 2);
            this.lblSectionName.Size = new System.Drawing.Size(304, 28);
            this.lblSectionName.TabIndex = 5;
            this.lblSectionName.Text = "Konu Adı:";
            // 
            // lblUnitName
            // 
            this.lblUnitName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitName.Appearance.Options.UseFont = true;
            this.lblUnitName.Appearance.Options.UseTextOptions = true;
            this.lblUnitName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblUnitName, 2);
            this.lblUnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitName.Location = new System.Drawing.Point(623, 36);
            this.lblUnitName.Name = "lblUnitName";
            this.tbpQuestionİnfo.SetRow(this.lblUnitName, 1);
            this.lblUnitName.Size = new System.Drawing.Size(304, 27);
            this.lblUnitName.TabIndex = 4;
            this.lblUnitName.Text = "Ünite Adı:";
            // 
            // lblLectureName
            // 
            this.lblLectureName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLectureName.Appearance.Options.UseFont = true;
            this.lblLectureName.Appearance.Options.UseTextOptions = true;
            this.lblLectureName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblLectureName, 2);
            this.lblLectureName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLectureName.Location = new System.Drawing.Point(623, 3);
            this.lblLectureName.Name = "lblLectureName";
            this.tbpQuestionİnfo.SetRow(this.lblLectureName, 0);
            this.lblLectureName.Size = new System.Drawing.Size(304, 27);
            this.lblLectureName.TabIndex = 3;
            this.lblLectureName.Text = "Dersin Adı:";
            // 
            // lblSectionNumber
            // 
            this.lblSectionNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSectionNumber.Appearance.Options.UseFont = true;
            this.lblSectionNumber.Appearance.Options.UseTextOptions = true;
            this.lblSectionNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblSectionNumber, 0);
            this.lblSectionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionNumber.Location = new System.Drawing.Point(3, 69);
            this.lblSectionNumber.Name = "lblSectionNumber";
            this.tbpQuestionİnfo.SetRow(this.lblSectionNumber, 2);
            this.lblSectionNumber.Size = new System.Drawing.Size(304, 28);
            this.lblSectionNumber.TabIndex = 2;
            this.lblSectionNumber.Text = "Konu No:";
            // 
            // lblUnitNumber
            // 
            this.lblUnitNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitNumber.Appearance.Options.UseFont = true;
            this.lblUnitNumber.Appearance.Options.UseTextOptions = true;
            this.lblUnitNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblUnitNumber, 0);
            this.lblUnitNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitNumber.Location = new System.Drawing.Point(3, 36);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.tbpQuestionİnfo.SetRow(this.lblUnitNumber, 1);
            this.lblUnitNumber.Size = new System.Drawing.Size(304, 27);
            this.lblUnitNumber.TabIndex = 1;
            this.lblUnitNumber.Text = "Ünite No:";
            // 
            // lblgradeNumber
            // 
            this.lblgradeNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblgradeNumber.Appearance.Options.UseFont = true;
            this.lblgradeNumber.Appearance.Options.UseTextOptions = true;
            this.lblgradeNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbpQuestionİnfo.SetColumn(this.lblgradeNumber, 0);
            this.lblgradeNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblgradeNumber.Location = new System.Drawing.Point(3, 3);
            this.lblgradeNumber.Name = "lblgradeNumber";
            this.tbpQuestionİnfo.SetRow(this.lblgradeNumber, 0);
            this.lblgradeNumber.Size = new System.Drawing.Size(304, 27);
            this.lblgradeNumber.TabIndex = 0;
            this.lblgradeNumber.Text = "Sınıf Düzeyi:";
            // 
            // recQuestion
            // 
            this.recQuestion.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.tbpQuestion.SetColumn(this.recQuestion, 0);
            this.recQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recQuestion.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.recQuestion.Location = new System.Drawing.Point(0, 100);
            this.recQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.recQuestion.Name = "recQuestion";
            this.recQuestion.Options.Behavior.ShowPopupMenu = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.recQuestion.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.Rtf;
            this.recQuestion.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.Rtf;
            this.recQuestion.ReadOnly = true;
            this.tbpQuestion.SetRow(this.recQuestion, 1);
            this.recQuestion.Size = new System.Drawing.Size(1240, 500);
            this.recQuestion.TabIndex = 0;
            // 
            // tbpMain
            // 
            this.tbpMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 1240F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Controls.Add(this.tbpQuestion);
            this.tbpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMain.Location = new System.Drawing.Point(0, 0);
            this.tbpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Size = new System.Drawing.Size(1393, 678);
            this.tbpMain.TabIndex = 1;
            // 
            // rdgChoices
            // 
            this.tbpQuestion.SetColumn(this.rdgChoices, 0);
            this.rdgChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgChoices.Location = new System.Drawing.Point(0, 600);
            this.rdgChoices.Margin = new System.Windows.Forms.Padding(0);
            this.rdgChoices.Name = "rdgChoices";
            this.rdgChoices.Properties.Columns = 1;
            this.rdgChoices.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem()});
            this.tbpQuestion.SetRow(this.rdgChoices, 2);
            this.rdgChoices.Size = new System.Drawing.Size(1240, 78);
            this.rdgChoices.TabIndex = 2;
            // 
            // UcQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbpMain);
            this.Name = "UcQuestionView";
            this.Size = new System.Drawing.Size(1393, 678);
            this.Load += new System.EventHandler(this.UcQuestionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestion)).EndInit();
            this.tbpQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbpQuestionİnfo)).EndInit();
            this.tbpQuestionİnfo.ResumeLayout(false);
            this.tbpQuestionİnfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).EndInit();
            this.tbpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgChoices.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tbpQuestion;
        private DevExpress.XtraRichEdit.RichEditControl recQuestion;
        private DevExpress.Utils.Layout.TablePanel tbpMain;
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
        private DevExpress.XtraEditors.RadioGroup rdgChoices;
    }
}
