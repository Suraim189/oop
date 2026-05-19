namespace EduNova.WinForms.Forms.Common
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Size = new System.Drawing.Size(480, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "EduNova";
            this.lblTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 24f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlCard
            this.pnlCard.Location = new System.Drawing.Point(40, 85);
            this.pnlCard.Size = new System.Drawing.Size(400, 380);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20");
            this.pnlCard.Controls.Add(this.lblUsername);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.chkShowPassword);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.lblError);

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(24, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Username";
            this.lblUsername.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblUsername.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(24, 45);
            this.txtUsername.Size = new System.Drawing.Size(352, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtUsername.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtUsername.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(24, 107);
            this.txtPassword.Size = new System.Drawing.Size(352, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\u25CF';
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtPassword.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // chkShowPassword
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(24, 142);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f, System.Drawing.FontStyle.Regular);
            this.chkShowPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(24, 180);
            this.btnLogin.Size = new System.Drawing.Size(352, 48);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnLogin.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnLogin.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblError
            this.lblError.AutoSize = false;
            this.lblError.Location = new System.Drawing.Point(24, 240);
            this.lblError.Size = new System.Drawing.Size(352, 24);
            this.lblError.Name = "lblError";
            this.lblError.Text = "";
            this.lblError.Visible = false;
            this.lblError.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f, System.Drawing.FontStyle.Regular);
            this.lblError.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF6B6B");
            this.lblError.BackColor = System.Drawing.Color.Transparent;

            // frmLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmLogin";
            this.Text = "EduNova - Login";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlCard);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
