
namespace ExamSystem.WebFormsUI.Forms.StudentForms
{
    partial class FrmStudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnExamStart = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnChangeTimeInterval = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnShowStatistics = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barBtnSectionExam = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barBtnExamStart,
            this.barBtnChangeTimeInterval,
            this.barBtnShowStatistics,
            this.barBtnSectionExam});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1363, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnExamStart
            // 
            this.barBtnExamStart.Caption = "Sınavı Başlat                ";
            this.barBtnExamStart.Id = 1;
            this.barBtnExamStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnExamStart.ImageOptions.Image")));
            this.barBtnExamStart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnExamStart.ImageOptions.LargeImage")));
            this.barBtnExamStart.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnExamStart.ItemAppearance.Hovered.Options.UseFont = true;
            this.barBtnExamStart.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnExamStart.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnExamStart.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnExamStart.ItemAppearance.Pressed.Options.UseFont = true;
            this.barBtnExamStart.Name = "barBtnExamStart";
            this.barBtnExamStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExamStart_ItemClick);
            // 
            // barBtnChangeTimeInterval
            // 
            this.barBtnChangeTimeInterval.Caption = "Zaman Aralıklarını değiştir";
            this.barBtnChangeTimeInterval.Id = 2;
            this.barBtnChangeTimeInterval.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnChangeTimeInterval.ImageOptions.Image")));
            this.barBtnChangeTimeInterval.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnChangeTimeInterval.ImageOptions.LargeImage")));
            this.barBtnChangeTimeInterval.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnChangeTimeInterval.ItemAppearance.Hovered.Options.UseFont = true;
            this.barBtnChangeTimeInterval.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnChangeTimeInterval.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnChangeTimeInterval.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnChangeTimeInterval.ItemAppearance.Pressed.Options.UseFont = true;
            this.barBtnChangeTimeInterval.Name = "barBtnChangeTimeInterval";
            this.barBtnChangeTimeInterval.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnChangeTimeInterval_ItemClick);
            // 
            // barBtnShowStatistics
            // 
            this.barBtnShowStatistics.Caption = "Rapor";
            this.barBtnShowStatistics.Id = 3;
            this.barBtnShowStatistics.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnShowStatistics.ImageOptions.SvgImage")));
            this.barBtnShowStatistics.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnShowStatistics.ItemAppearance.Hovered.Options.UseFont = true;
            this.barBtnShowStatistics.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnShowStatistics.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnShowStatistics.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnShowStatistics.ItemAppearance.Pressed.Options.UseFont = true;
            this.barBtnShowStatistics.Name = "barBtnShowStatistics";
            this.barBtnShowStatistics.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnShowStatistics_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnExamStart);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnChangeTimeInterval);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnShowStatistics);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSectionExam);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 548);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1363, 24);
            // 
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // barBtnSectionExam
            // 
            this.barBtnSectionExam.Caption = "Konu Bazlı Sınav";
            this.barBtnSectionExam.Id = 4;
            this.barBtnSectionExam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSectionExam.ImageOptions.SvgImage")));
            this.barBtnSectionExam.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnSectionExam.ItemAppearance.Hovered.Options.UseFont = true;
            this.barBtnSectionExam.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnSectionExam.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnSectionExam.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnSectionExam.ItemAppearance.Pressed.Options.UseFont = true;
            this.barBtnSectionExam.Name = "barBtnSectionExam";
            this.barBtnSectionExam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSectionExam_ItemClick);
            // 
            // FrmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 572);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmStudentMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FrmStudentMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStudentMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnExamStart;
        private DevExpress.XtraBars.BarButtonItem barBtnChangeTimeInterval;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
        private DevExpress.XtraBars.BarButtonItem barBtnShowStatistics;
        private DevExpress.XtraBars.BarButtonItem barBtnSectionExam;
    }
}