namespace EduNova.WinForms.Forms.ClassesSections
{
    partial class frmClasses
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridView dgvSections;
        private System.Windows.Forms.Label lblClasses; private System.Windows.Forms.Label lblSections;
        private System.Windows.Forms.Button btnAddClass; private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnDeleteClass; private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btnDeleteSection;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblClasses
            this.lblClasses = new System.Windows.Forms.Label();
            this.lblClasses.Location = new System.Drawing.Point(6, 6);
            this.lblClasses.Size = new System.Drawing.Size(200, 22);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Text = "Grade Classes";
            this.lblClasses.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblClasses.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblClasses.BackColor = System.Drawing.Color.Transparent;
            // btnAddClass
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnAddClass.Location = new System.Drawing.Point(6, 32);
            this.btnAddClass.Size = new System.Drawing.Size(80, 28);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Text = "+ Add";
            this.btnAddClass.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnAddClass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnAddClass.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // btnEditClass
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnEditClass.Location = new System.Drawing.Point(92, 32);
            this.btnEditClass.Size = new System.Drawing.Size(80, 28);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Text = "Edit";
            this.btnEditClass.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3A25");
            this.btnEditClass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnEditClass.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClass.FlatAppearance.BorderSize = 0;
            this.btnEditClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // btnDeleteClass
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnDeleteClass.Location = new System.Drawing.Point(178, 32);
            this.btnDeleteClass.Size = new System.Drawing.Size(80, 28);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.BackColor = System.Drawing.ColorTranslator.FromHtml("#7B2D2D");
            this.btnDeleteClass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFB3B3");
            this.btnDeleteClass.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClass.FlatAppearance.BorderSize = 0;
            this.btnDeleteClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // dgvClasses
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.dgvClasses.Location = new System.Drawing.Point(6, 66);
            this.dgvClasses.Size = new System.Drawing.Size(430, 480);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvClasses.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasses.AutoGenerateColumns = false; this.dgvClasses.ReadOnly = true;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.RowHeadersVisible = false; this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.EnableHeadersVisualStyles = false; this.dgvClasses.ColumnHeadersHeight = 38;
            this.dgvClasses.RowTemplate.Height = 34;
            this.dgvClasses.SelectionChanged += new System.EventHandler(this.dgvClasses_SelectionChanged);
            // lblSections
            this.lblSections = new System.Windows.Forms.Label();
            this.lblSections.Location = new System.Drawing.Point(6, 6);
            this.lblSections.Size = new System.Drawing.Size(200, 22);
            this.lblSections.Name = "lblSections";
            this.lblSections.Text = "Sections";
            this.lblSections.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblSections.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblSections.BackColor = System.Drawing.Color.Transparent;
            // btnAddSection
            this.btnAddSection = new System.Windows.Forms.Button();
            this.btnAddSection.Location = new System.Drawing.Point(6, 32);
            this.btnAddSection.Size = new System.Drawing.Size(80, 28);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Text = "+ Add";
            this.btnAddSection.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnAddSection.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnAddSection.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.FlatAppearance.BorderSize = 0;
            this.btnAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // btnDeleteSection
            this.btnDeleteSection = new System.Windows.Forms.Button();
            this.btnDeleteSection.Location = new System.Drawing.Point(92, 32);
            this.btnDeleteSection.Size = new System.Drawing.Size(80, 28);
            this.btnDeleteSection.Name = "btnDeleteSection";
            this.btnDeleteSection.Text = "Delete";
            this.btnDeleteSection.BackColor = System.Drawing.ColorTranslator.FromHtml("#7B2D2D");
            this.btnDeleteSection.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFB3B3");
            this.btnDeleteSection.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnDeleteSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSection.FlatAppearance.BorderSize = 0;
            this.btnDeleteSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSection.Click += new System.EventHandler(this.btnDeleteSection_Click);
            // dgvSections
            this.dgvSections = new System.Windows.Forms.DataGridView();
            this.dgvSections.Location = new System.Drawing.Point(6, 66);
            this.dgvSections.Size = new System.Drawing.Size(440, 480);
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvSections.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSections.AutoGenerateColumns = false; this.dgvSections.ReadOnly = true;
            this.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSections.RowHeadersVisible = false; this.dgvSections.AllowUserToAddRows = false;
            this.dgvSections.EnableHeadersVisualStyles = false; this.dgvSections.ColumnHeadersHeight = 38;
            this.dgvSections.RowTemplate.Height = 34;
            // splitContainer
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.SplitterDistance = 450;
            this.splitContainer.Panel1.Controls.Add(this.lblClasses);
            this.splitContainer.Panel1.Controls.Add(this.btnAddClass);
            this.splitContainer.Panel1.Controls.Add(this.btnEditClass);
            this.splitContainer.Panel1.Controls.Add(this.btnDeleteClass);
            this.splitContainer.Panel1.Controls.Add(this.dgvClasses);
            this.splitContainer.Panel2.Controls.Add(this.lblSections);
            this.splitContainer.Panel2.Controls.Add(this.btnAddSection);
            this.splitContainer.Panel2.Controls.Add(this.btnDeleteSection);
            this.splitContainer.Panel2.Controls.Add(this.dgvSections);

            this.SuspendLayout();
            this.Controls.Add(this.splitContainer);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Name = "frmClasses";
            this.Text = "EduNova - Classes & Sections";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
