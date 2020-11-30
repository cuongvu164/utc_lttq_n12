using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTTQ_BTL_N12
{
    public class ExcelUtil
    {
        public static void ExportExcel(DataTable dataTable, string location, string title)
        {

                if (dataTable == null || dataTable.Columns.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ");

                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Workbooks.Add();
                Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;
                workSheet.Name = title;

                workSheet.Cells[1, 1] = title;
                workSheet.Cells[1, 1].Font.Bold = true;
                workSheet.Cells[1, 1].Font.Size = 20;

                workSheet.Cells[2, 1] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                for (var i = 0; i < dataTable.Columns.Count; i++)
                {
                    workSheet.Cells[4, i + 1] = dataTable.Columns[i].ColumnName;
                    workSheet.Cells[4, i + 1].Font.Bold = true;
                }

                for (var i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (var j = 0; j < dataTable.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 5, j + 1] = dataTable.Rows[i][j];
                    }
                }

                if (!string.IsNullOrEmpty(location))
                {
                    try
                    {
                        workSheet.SaveAs(location);
                        excelApp.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Không thể xuất báo cáo\nNguyên nhân: " + ex.Message);
                    }
                }
                else
                {
                    excelApp.Visible = true;
                }

        }

        public static void ExportExcel<E>(IEnumerable<E> data, string location, string title)
        {
            var table = new DataTable();
            using (var reader = ObjectReader.Create(data))
            {
                table.Load(reader);
                ExportExcel(table, location, title);
            }
        }

        private static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }
    }
}
