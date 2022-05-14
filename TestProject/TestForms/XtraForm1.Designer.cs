
namespace TestProject.TestForms
{
    partial class XtraForm1
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
            this.ucQuestionView1 = new TestProject.TestForms.UcQuestionView();
            this.SuspendLayout();
            // 
            // ucQuestionView1
            // 
            this.ucQuestionView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucQuestionView1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucQuestionView1.Appearance.Options.UseBackColor = true;
            this.ucQuestionView1.Location = new System.Drawing.Point(12, 12);
            this.ucQuestionView1.Name = "ucQuestionView1";
            this.ucQuestionView1.Size = new System.Drawing.Size(1280, 666);
            this.ucQuestionView1.TabIndex = 0;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 690);
            this.Controls.Add(this.ucQuestionView1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private UcQuestionView ucQuestionView1;
    }
}