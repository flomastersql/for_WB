using System.Windows.Forms;

namespace TR
{
    //класс логических операций
    class DataOperations
    {
        //получение строки перечня через запятую для SQL из выделенных ячеек одностолбчатой DataGrid
        public static string getStringFromDGV (DataGridView dgv)
        {
            //возвращаемая переменная
            string str = "";
            //проход по выделенным ячейкам
            for (int i = 0; i < dgv.SelectedCells.Count; i++)
            {
                //проставляем запятую перед всеми кроме первого номера
                if (i != 0) { str += ","; }
                //безусловное данных очередной выделенной ячейки
                str += "'" + dgv.Rows[dgv.SelectedCells[i].RowIndex].Cells[0].Value.ToString() + "'";
            }
            //возврат строки 
            return str;
        }
    }
}
