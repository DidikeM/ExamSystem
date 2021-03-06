
namespace ExamSystem.WebFormsUI.Forms.StudentForms
{
    partial class FrmStudentExam
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
            this.tbpMain = new DevExpress.Utils.Layout.TablePanel();
            this.btnNextQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.lblQuestionNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblCounter = new DevExpress.XtraEditors.LabelControl();
            this.timerExam = new System.Windows.Forms.Timer(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).BeginInit();
            this.tbpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpMain.Appearance.Options.UseBackColor = true;
            this.tbpMain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Controls.Add(this.btnNextQuestion);
            this.tbpMain.Controls.Add(this.lblQuestionNumber);
            this.tbpMain.Controls.Add(this.lblCounter);
            this.tbpMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbpMain.Location = new System.Drawing.Point(963, 0);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 250F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tbpMain.Size = new System.Drawing.Size(298, 536);
            this.tbpMain.TabIndex = 0;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextQuestion.Appearance.Options.UseFont = true;
            this.tbpMain.SetColumn(this.btnNextQuestion, 0);
            this.btnNextQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextQuestion.Location = new System.Drawing.Point(3, 472);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.tbpMain.SetRow(this.btnNextQuestion, 3);
            this.btnNextQuestion.Size = new System.Drawing.Size(292, 61);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Sıradaki Soru";
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestionNumber.Appearance.Options.UseFont = true;
            this.lblQuestionNumber.Appearance.Options.UseTextOptions = true;
            this.lblQuestionNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblQuestionNumber.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tbpMain.SetColumn(this.lblQuestionNumber, 0);
            this.lblQuestionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionNumber.Location = new System.Drawing.Point(3, 70);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.tbpMain.SetRow(this.lblQuestionNumber, 1);
            this.lblQuestionNumber.Size = new System.Drawing.Size(292, 61);
            this.lblQuestionNumber.TabIndex = 1;
            this.lblQuestionNumber.Text = "value";
            // 
            // lblCounter
            // 
            this.lblCounter.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCounter.Appearance.Options.UseFont = true;
            this.lblCounter.Appearance.Options.UseTextOptions = true;
            this.lblCounter.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCounter.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tbpMain.SetColumn(this.lblCounter, 0);
            this.lblCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCounter.Location = new System.Drawing.Point(3, 3);
            this.lblCounter.Name = "lblCounter";
            this.tbpMain.SetRow(this.lblCounter, 0);
            this.lblCounter.Size = new System.Drawing.Size(292, 61);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "value";
            // 
            // timerExam
            // 
            this.timerExam.Interval = 1000;
            this.timerExam.Tick += new System.EventHandler(this.timerExam_Tick);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmStudentExam
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 536);
            this.Controls.Add(this.tbpMain);
            this.IsMdiContainer = true;
            this.Name = "FrmStudentExam";
            this.Text = "FrmStudentExam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbpMain)).EndInit();
            this.tbpMain.ResumeLayout(false);
            this.tbpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tbpMain;
        private DevExpress.XtraEditors.SimpleButton btnNextQuestion;
        private DevExpress.XtraEditors.LabelControl lblQuestionNumber;
        private DevExpress.XtraEditors.LabelControl lblCounter;
        private System.Windows.Forms.Timer timerExam;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}