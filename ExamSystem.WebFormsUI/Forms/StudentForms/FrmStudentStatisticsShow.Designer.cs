
namespace ExamSystem.WebFormsUI.Forms.StudentForms
{
    partial class FrmStudentStatisticsShow
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
            this.components = new System.ComponentModel.Container();
            this.rtbStatistics = new System.Windows.Forms.RichTextBox();
            this.tbpMain = new DevExpress.Utils.Layout.TablePanel();
            this.tbpRight = new DevExpress.Utils.Layout.TablePanel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.sfdSaveStatistics = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).BeginInit();
            this.tbpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpRight)).BeginInit();
            this.tbpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbStatistics
            // 
            this.tbpMain.SetColumn(this.rtbStatistics, 0);
            this.rtbStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbStatistics.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbStatistics.Location = new System.Drawing.Point(3, 3);
            this.rtbStatistics.Name = "rtbStatistics";
            this.rtbStatistics.ReadOnly = true;
            this.tbpMain.SetRow(this.rtbStatistics, 0);
            this.rtbStatistics.Size = new System.Drawing.Size(1022, 586);
            this.rtbStatistics.TabIndex = 0;
            this.rtbStatistics.Text = "";
            // 
            // tbpMain
            // 
            this.tbpMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 300F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Controls.Add(this.tbpRight);
            this.tbpMain.Controls.Add(this.rtbStatistics);
            this.tbpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMain.Location = new System.Drawing.Point(0, 0);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Size = new System.Drawing.Size(1199, 592);
            this.tbpMain.TabIndex = 1;
            // 
            // tbpRight
            // 
            this.tbpMain.SetColumn(this.tbpRight, 1);
            this.tbpRight.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpRight.Controls.Add(this.btnSave);
            this.tbpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpRight.Location = new System.Drawing.Point(1031, 3);
            this.tbpRight.Name = "tbpRight";
            this.tbpMain.SetRow(this.tbpRight, 0);
            this.tbpRight.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 350F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpRight.Size = new System.Drawing.Size(165, 586);
            this.tbpRight.TabIndex = 1;
            // 
            // btnSave
            // 
            this.tbpRight.SetColumn(this.btnSave, 0);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 516);
            this.btnSave.Name = "btnSave";
            this.tbpRight.SetRow(this.btnSave, 1);
            this.btnSave.Size = new System.Drawing.Size(159, 67);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Raporu Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmStudentStatisticsShow
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 592);
            this.Controls.Add(this.tbpMain);
            this.Name = "FrmStudentStatisticsShow";
            this.Text = "FrmStudentStatisticsShow";
            this.Load += new System.EventHandler(this.FrmStudentStatisticsShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).EndInit();
            this.tbpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbpRight)).EndInit();
            this.tbpRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbStatistics;
        private DevExpress.Utils.Layout.TablePanel tbpMain;
        private DevExpress.Utils.Layout.TablePanel tbpRight;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.XtraSaveFileDialog sfdSaveStatistics;
    }
}