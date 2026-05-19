namespace EduNova.WinForms.Forms.Common
{
    partial class frmSplash
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.Timer timerProgress;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            // lblLogo
            this.lblLogo.AutoSize = false;
            this.lblLogo.Location = new System.Drawing.Point(0, 80);
            this.lblLogo.Size = new System.Drawing.Size(600, 60);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Text = "EduNova";
            this.lblLogo.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 36f, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle
            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 150);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 28);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "School Management System";
            this.lblSubtitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 12f, System.Drawing.FontStyle.Regular);
            this.lblSubtitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // progressBar1
            this.progressBar1.Location = new System.Drawing.Point(100, 230);
            this.progressBar1.Size = new System.Drawing.Size(400, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 0;

            // timerFade
            this.timerFade.Interval = 50;
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);

            // timerProgress
            this.timerProgress.Interval = 50;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);

            // frmSplash
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmSplash";
            this.Text = "EduNova";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.progressBar1);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
