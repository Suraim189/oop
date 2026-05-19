using System.Drawing;
using System.Windows.Forms;

namespace EduNova.WinForms.Helpers
{
    public static class Theme
    {
        public static readonly Color BgPrimary      = ColorTranslator.FromHtml("#0D1B14");
        public static readonly Color BgSecondary    = ColorTranslator.FromHtml("#132218");
        public static readonly Color BgCard         = ColorTranslator.FromHtml("#1A2E20");
        public static readonly Color BgSidebar      = ColorTranslator.FromHtml("#0A1510");
        public static readonly Color AccentGold     = ColorTranslator.FromHtml("#C9A84C");
        public static readonly Color AccentEmerald  = ColorTranslator.FromHtml("#2ECC71");
        public static readonly Color AccentHover    = ColorTranslator.FromHtml("#27AE60");
        public static readonly Color TextPrimary    = ColorTranslator.FromHtml("#F0F0E8");
        public static readonly Color TextSecondary  = ColorTranslator.FromHtml("#A8B8A0");
        public static readonly Color TextAccent     = ColorTranslator.FromHtml("#C9A84C");
        public static readonly Color Border         = ColorTranslator.FromHtml("#2A4030");
        public static readonly Color GridHeader     = ColorTranslator.FromHtml("#1A3A25");
        public static readonly Color GridRowAlt     = ColorTranslator.FromHtml("#162A1C");
        public static readonly Color BtnPrimary     = ColorTranslator.FromHtml("#C9A84C");
        public static readonly Color BtnPrimaryText = ColorTranslator.FromHtml("#0D1B14");
        public static readonly Color BtnSecondary   = ColorTranslator.FromHtml("#1A3A25");
        public static readonly Color BtnSecondTxt   = ColorTranslator.FromHtml("#C9A84C");
        public static readonly Color BtnDanger      = ColorTranslator.FromHtml("#7B2D2D");
        public static readonly Color BtnDangerText  = ColorTranslator.FromHtml("#FFB3B3");
        public static readonly Color SidebarActive  = ColorTranslator.FromHtml("#C9A84C");
        public static readonly Color SidebarActTxt  = ColorTranslator.FromHtml("#0D1B14");

        public static readonly Font FontHeading = new Font("Segoe UI", 14f, FontStyle.Bold);
        public static readonly Font FontTitle   = new Font("Segoe UI", 16f, FontStyle.Bold);
        public static readonly Font FontBody    = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font FontBold    = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        public static readonly Font FontSmall   = new Font("Segoe UI", 8.5f, FontStyle.Regular);
        public static readonly Font FontGrid    = new Font("Segoe UI", 9f, FontStyle.Regular);
        public static readonly Font FontGridHdr = new Font("Segoe UI", 9.5f, FontStyle.Bold);

        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = BgPrimary;
            dgv.GridColor = Border;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AutoGenerateColumns = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 38;
            dgv.RowTemplate.Height = 34;
            dgv.DefaultCellStyle.BackColor = BgCard;
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.SelectionBackColor = AccentGold;
            dgv.DefaultCellStyle.SelectionForeColor = BtnPrimaryText;
            dgv.DefaultCellStyle.Font = FontGrid;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = GridHeader;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextPrimary;
            dgv.ColumnHeadersDefaultCellStyle.Font = FontGridHdr;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = GridRowAlt;
        }

        public static void StyleGoldButton(Button btn)
        {
            btn.BackColor = BtnPrimary;
            btn.ForeColor = BtnPrimaryText;
            btn.Font = FontBold;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
        }

        public static void StyleDarkButton(Button btn)
        {
            btn.BackColor = BtnSecondary;
            btn.ForeColor = BtnSecondTxt;
            btn.Font = FontBold;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
        }

        public static void StyleDangerButton(Button btn)
        {
            btn.BackColor = BtnDanger;
            btn.ForeColor = BtnDangerText;
            btn.Font = FontBold;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
        }
    }
}
