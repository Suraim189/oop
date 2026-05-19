using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.AdminSecurity
{
    public partial class frmRolesPermissions : Form
    {
        private readonly AdminService _svc = new AdminService();
        private DataTable _roles;
        private DataTable _permTable;
        public frmRolesPermissions()
        {
            InitializeComponent();
            Load += frmRolesPermissions_Load;
            Theme.StyleDataGridView(dgvRoles); Theme.StyleDataGridView(dgvPermissions);
            SetupRoleGrid(); SetupPermGrid();
            dgvRoles.SelectionChanged += dgvRoles_SelectionChanged;
        }
        private void SetupRoleGrid()
        {
            dgvRoles.Columns.Clear();
            dgvRoles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Role", Width = 180, DataPropertyName = "RoleName" });
        }
        private void SetupPermGrid()
        {
            dgvPermissions.Columns.Clear();
            dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colModule", HeaderText = "Module", Width = 120, DataPropertyName = "Module" });
            dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPerm", HeaderText = "Permission", Width = 280, DataPropertyName = "Permission" });
            dgvPermissions.Columns.Add(new DataGridViewCheckBoxColumn { Name = "colAllowed", HeaderText = "Allowed", Width = 60, DataPropertyName = "Allowed" });
        }
        private void frmRolesPermissions_Load(object sender, EventArgs e) { try { _roles = _svc.GetAllRoles(); dgvRoles.DataSource = _roles; } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); } }
        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null || dgvRoles.CurrentRow.DataBoundItem == null) return;
            var row = (DataRowView)dgvRoles.CurrentRow.DataBoundItem;
            int roleId = Convert.ToInt32(row["RoleId"]);

            var allPerms = _svc.GetAllPermissionCodes();
            var rolePerms = _svc.GetRolePermissions(roleId);
            var allowed = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (DataRow rp in rolePerms.Rows)
                allowed.Add(rp["PermissionCode"].ToString());

            _permTable = new DataTable();
            _permTable.Columns.Add("Module", typeof(string));
            _permTable.Columns.Add("Permission", typeof(string));
            _permTable.Columns.Add("Allowed", typeof(bool));

            foreach (DataRow p in allPerms.Rows)
            {
                var code = p["PermissionCode"].ToString();
                string module = code.Contains(".") ? code.Split('.')[0] : "General";
                _permTable.Rows.Add(module, code, allowed.Contains(code));
            }
            dgvPermissions.DataSource = _permTable;
        }
        private void btnSavePerms_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null || dgvRoles.CurrentRow.DataBoundItem == null || _permTable == null)
                return;
            var row = (DataRowView)dgvRoles.CurrentRow.DataBoundItem;
            int roleId = Convert.ToInt32(row["RoleId"]);
            var codes = new System.Collections.Generic.List<string>();
            foreach (DataRow r in _permTable.Rows)
            {
                if (r["Allowed"] != DBNull.Value && Convert.ToBoolean(r["Allowed"]))
                    codes.Add(r["Permission"].ToString());
            }
            _svc.SetRolePermissions(roleId, codes);
            MessageBox.Show("Permissions saved!");
        }
    }
}
