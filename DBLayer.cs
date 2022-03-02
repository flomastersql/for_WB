using System;
using System.Data;
using System.Data.SqlClient;

namespace TR
{
    //класс методов для работы с базой данных
    class DBLayer
    {

        static string sconnstr = "uid=uid;pwd=pwd;Initial Catalog=;Data Source=.";

        //вставка магазина в адресный план
        public static void insertOneStore(string table_name, string id, string day_num)
        {
            execSQL(string.Format("insert into {0} (id, day_num) values ('{1}', {2})", table_name, id, day_num));
        }

        //получение id магазинов по параметру частоты посещения
        public static DataTable getIdStoresByFreq(string region, string city_list, int frequency)
        {
            return SQLtoDT(
                string.Format("select id from table1 where region = '{0}' and city in ({1}) and frequency = {2}", region, city_list, frequency)
                );
        }

        //полусение отсортированного по возрастанию загруженности дней формирующегося обхода
        public static DataTable getLoadingDaysByIncrease(string name_table)
        {
            //пришлось применить cte с набором дней на случай если после прохода 5 3 2 дней не все дни недели будут заполнены, скажем если в построении будут только 
            // одно дневные и четырех дневные наборы
            return SQLtoDT(
                "with weekdays(d) as (select 1 union all select 2 union all select 3 union all select 4 union all select 5) " +
                "select wd.d, isnull(loading_days.ld, 0) from weekdays wd left join " +
                string.Format("( select t2.day_num, sum(t1.visit_time_plan) ld from {0} t2 ", name_table) +
                " left join [table1] t1 on t2.[id] = t1.id group by t2.day_num " +
                " ) loading_days on wd.d = loading_days.day_num order by loading_days.ld ");
        }

        //метод для обслуживания распределения 3 2 и 5 дневных посещений точек по листам
        public static void insertDaysPoints(string table_name, string region, string city_list, int frequency)
        {
            //переменная с какого дня начинать заполнять
            int fst_day = 1;
            int lst_day = 5;
            //строки
            string snd_row = string.Format("select id, 2 from table1 where region = '{0}' and city in ({1}) and frequency = {2} union all ", region, city_list, frequency);
            string thd_row = string.Format("select id, 3 from table1 where region = '{0}' and city in ({1}) and frequency = {2} union all ", region, city_list, frequency);
            string fth_row = string.Format("select id, 4 from table1 where region = '{0}' and city in ({1}) and frequency = {2} union all ", region, city_list, frequency);
            //обнуление строк для дней, которые не надо вставлять
            switch(frequency)
            {
                case 3:
                    snd_row = fth_row = "";
                    break;
                case 2:
                    snd_row = thd_row = fth_row = "";
                    fst_day = 2; lst_day = 4; //переопределяем первый и последний день с 1 и 5 на 2 и 4
                    break;
            }                
            //выполнение вставки
            execSQL(
                string.Format(
                    "insert into {0} (id, day_num) " +
                    "select id, {3} day_num from table1 where region = '{1}' and city in ({2}) and frequency = {4} union all " + snd_row + thd_row + fth_row +
                    "select id, {5} from table1 where region = '{1}' and city in ({2}) and frequency = {4} "                   
                    ,table_name, region, city_list, fst_day, frequency, lst_day
                    )
                );
        }

        //метод создания индивидуальной таблицы для маршрутных листов 
        public static string createListTable()
        {
            string name_table = string.Format("table2_{0}", DateTime.Now.ToUniversalTime().ToString().Replace(".", " ").Replace(" ", "").Replace(":", ""));
            execSQL(
                string.Format(" create table {0} ( ", name_table) +
                "id varchar(50), day_num tinyint, road_id int, id_sort int, minutes_to_next int, type_moving tinyint) "
            );
            return name_table;
        }     

        //получение кол-ва магазинов по региону и перечню городов
        public static string getCountStores(string region, string city_list)
        {
            return SQLtoDT(
                string.Format("select count(*) from table1 where region = '{0}' and city in ({1})", region, city_list)
                ).Rows[0][0].ToString();
        }

        //получение неповторяющегося списка городов по определеннуму региону
        public static DataTable getCitiesByRegion(string region)
        {
            return SQLtoDT(string.Format("select distinct city from table1 where region = '{0}'", region));
        }

        //получение неповторяющегося списка регионов
        public static DataTable getRegions()
        {
            return SQLtoDT("select distinct region from table1 order by region");
        }

        //приватная функция для возврата DataTable как результат выполнения команды select
        private static DataTable SQLtoDT(string command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(command, sconnstr);            
            sda.Fill(dt);
            return dt;
        }

        //приватная функция для выполнения SQL команды
        private static void execSQL(string command)
        {
            SqlConnection scon = new SqlConnection(sconnstr);
            scon.Open();

            SqlCommand scom = new SqlCommand(command, scon);
            scom.ExecuteNonQuery();
            scon.Close();
        }


    }
}
