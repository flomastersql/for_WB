using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TR
{
    public partial class TRtest : Form
    {
        //переменная для хранения региона
        string region = "";
        public TRtest()
        {
            InitializeComponent();
            //при запуске приложения - сразу получение регионов
            DGV_reg.DataSource = DBLayer.getRegions();
            //олновление данных на форме и городов по региону
            renewData(0);
        }

        //олновление данных на форме и городов по региону при нажатии на ячейку с данными регионов
        private void DGV_reg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renewData(e.RowIndex);
        }

        //функция обновления данных на форме и городов по региону
        void renewData(int rowIndex)
        {
            //запись в переменную региона
            region = DGV_reg.Rows[rowIndex].Cells[0].Value.ToString();
            //заполнение данных населенных пунктов по региону
            DGV_city.DataSource = DBLayer.getCitiesByRegion(region);            
            //запись данных о регионе в подпись
            label1.Text = "Регион: " + region;
        }

        //обрабочик кнопки построения листов
        private void buildlists_Click(object sender, EventArgs e)
        {
            //создается индивидуальная таблица для текущего построения листов
            string table_name = DBLayer.createListTable();
            //собирается в string_agg перечень выделенных городов по региону из DataGrid городов
            string city_list = DataOperations.getStringFromDGV(DGV_city);
            // заполняются посещения для 5 3 2 дневных магазинов
            DBLayer.insertDaysPoints(table_name, region, city_list, 5);
            DBLayer.insertDaysPoints(table_name, region, city_list, 3);
            DBLayer.insertDaysPoints(table_name, region, city_list, 2);
            //получаются на уровень приложения магазины с однодневным визитом
            DataTable OneDayStoreVisit = DBLayer.getIdStoresByFreq(region, city_list, 1);
            //идет проход по данным магазинам
            for (int i = 0; i < OneDayStoreVisit.Rows.Count; i++)
            {
                //MessageBox.Show("sdfsdf");
                //и вставка их в наименее загруженный день, который получается первым членом двумерного массива DataTable полученного
                DBLayer.insertOneStore(
                        table_name
                        , OneDayStoreVisit.Rows[i][0].ToString()
                        //из специального метода (т.е ситуация обновляется после каждой вставки, все оттестировано, проверено. Именно на этом этапе принято решение 
                        //поменять двудневные визиты с 2 и 5 на 2 и 4, после прогона разных городов. После смены, четверг перестал быть обескровленным.
                        , DBLayer.getLoadingDaysByIncrease(table_name).Rows[0]["d"].ToString()
                    );
            }

            //получаются на уровень приложения магазины с четырехдневным визитом
            DataTable FourthDayStoreVisit = DBLayer.getIdStoresByFreq(region, city_list, 4);
            for (int i = 0; i < FourthDayStoreVisit.Rows.Count; i++)
            {
                MessageBox.Show("sdfsdf");
                //получаем актуальную загрузку дней перед каждой вставкой
                DataTable LoadingDaysByIncrease = DBLayer.getLoadingDaysByIncrease(table_name);
                
                for(int y = 0; y < 4; y++)
                {
                    DBLayer.insertOneStore(
                        table_name
                        , FourthDayStoreVisit.Rows[i][0].ToString()
                        , LoadingDaysByIncrease.Rows[y]["d"].ToString());
                }
            }
        }

        //обработчик запуска кнопки показа кол-ва магазинов
        private void b_store_count_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                //функция получения кол-ва по региону
                    DBLayer.getCountStores(region,
                    //и перечню городов полученного через логическое преобразование выделенных ячеек DataGrid в строку с запятыми для SQL
                    DataOperations.getStringFromDGV(DGV_city)
                    ), "Кол-во магазинов"
                );
        }
        

    }
}
