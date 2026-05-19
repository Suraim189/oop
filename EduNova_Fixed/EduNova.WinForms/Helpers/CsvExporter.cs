using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EduNova.WinForms.Helpers
{
    public static class CsvExporter
    {
        public static void ExportDataTable(DataTable table, string defaultFileName)
        {
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                dialog.FileName = defaultFileName;
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                var sb = new StringBuilder();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    if (i > 0) sb.Append(',');
                    sb.Append(Escape(table.Columns[i].ColumnName));
                }
                sb.AppendLine();

                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        if (i > 0) sb.Append(',');
                        sb.Append(Escape(row[i]?.ToString()));
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(dialog.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Export completed.");
            }
        }

        private static string Escape(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;
            bool mustQuote = value.Contains(",") || value.Contains("\n") || value.Contains("\r") || value.Contains("\"");
            if (mustQuote)
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }
    }
}
