using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using Excel = Microsoft.Office.Interop.Excel;

namespace Diplom.OtherClasses
{
    public static class  ExportToExcel
    {
       private static Excel.Application excel = new Excel.Application { Visible = false }; //запуск excel
        public static void ExportDataGridToExcel(DataGrid grid)
        {
            try
            {

                var workbook = excel.Workbooks.Add(); //добавляем документ
                var workSheet = workbook.ActiveSheet; //создаем лист

                //добавить заголовки
                for (var Idx = 0; Idx < grid.Columns.Count; Idx++)
                {
                    workSheet.Range["A1"].Offset[0, Idx].Value = grid.Columns[Idx].Header;
                }

                //заполнить таблицу
                for (var i = 0; i < grid.Columns.Count; i++)
                {
                    for (var j = 0; j < grid.Items.Count; j++)
                    {
                        var b = grid.Columns[i].GetCellContent(grid.Items[j]) as TextBlock;
                        var myRange = (Excel.Range) workSheet.Cells[j + 2, i + 1];
                        myRange.HorizontalAlignment = Excel.Constants.xlLeft;
                        myRange.VerticalAlignment = Excel.Constants.xlTop;
                        myRange.Value2 = b.Text;
                    }
                }

                workSheet.Columns.AutoFit();
                workbook.SaveAs();
                workbook.Close(false);
                Mes.SucMes("Сохранено, проверьте файл в папке 'Документы'");
            }

            finally
            {

            }
        }

        private static void CloseProcess()
        {
            Process[] List;
            List = Process.GetProcessesByName("EXCEL");
            foreach (Process proc in List)
            {
                proc.Kill();
            }
        }
    }
}
