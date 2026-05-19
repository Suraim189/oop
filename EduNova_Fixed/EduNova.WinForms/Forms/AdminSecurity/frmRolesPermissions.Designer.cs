namespace EduNova.WinForms.Forms.AdminSecurity
{
    partial class frmRolesPermissions
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridView dgvPermissions;
        private System.Windows.Forms.Label lblRoles; private System.Windows.Forms.Label lblPerms;
        private System.Windows.Forms.Button btnSavePerms;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblRoles
            this.lblRoles = new System.Windows.Forms.Label(); this.lblRoles.Location = new System.Drawing.Point(12, 12);
            this.lblRoles.Size = new System.Drawing.Size(200, 22); this.lblRoles.Name = "lblRoles";
            this.lblRoles.Text = "Roles"; this.lblRoles.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10f, System.Drawing.FontStyle.Bold);
            this.lblRoles.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            // dgvRoles
            this.dgvRoles = new System.Windows.Forms.DataGridView(); this.dgvRoles.Location = new System.Drawing.Point(12, 38); this.dgvRoles.Size = new System.Drawing.Size(320, 520);
            this.dgvRoles.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.dgvRoles.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvRoles.AutoGenerateColumns = false; this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersVisible = false; this.dgvRoles.AllowUserToAddRows = false; this.dgvRoles.EnableHeadersVisualStyles = false;
            // lblPerms
            this.lblPerms = new System.Windows.Forms.Label(); this.lblPerms.Location = new System.Drawing.Point(350, 12);
            this.lblPerms.Size = new System.Drawing.Size(200, 22); this.lblPerms.Name = "lblPerms";
            this.lblPerms.Text = "Permissions"; this.lblPerms.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10f, System.Drawing.FontStyle.Bold);
            this.lblPerms.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            // dgvPermissions
            this.dgvPermissions = new System.Windows.Forms.DataGridView(); this.dgvPermissions.Location = new System.Drawing.Point(350, 38); this.dgvPermissions.Size = new System.Drawing.Size(600, 480);
            this.dgvPermissions.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.dgvPermissions.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvPermissions.AutoGenerateColumns = false; this.dgvPermissions.ReadOnly = false;
            this.dgvPermissions.RowHeadersVisible = false; this.dgvPermissions.AllowUserToAddRows = false; this.dgvPermissions.EnableHeadersVisualStyles = false;
            // btnSavePerms
            this.btnSavePerms = new System.Windows.Forms.Button(); this.btnSavePerms.Text = "Save Permissions";
            this.btnSavePerms.Location = new System.Drawing.Point(350, 524); this.btnSavePerms.Size = new System.Drawing.Size(200, 36);
            this.btnSavePerms.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnSavePerms.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnSavePerms.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnSavePerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePerms.FlatAppearance.BorderSize = 0; this.btnSavePerms.Click += new System.EventHandler(this.btnSavePerms_Click);

            this.SuspendLayout();
            this.Controls.Add(this.lblRoles); this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.lblPerms); this.Controls.Add(this.dgvPermissions);
            this.Controls.Add(this.btnSavePerms);

            // frmRolesPermissions
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 580);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmRolesPermissions";
            this.Text = "EduNova - Roles & Permissions";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}