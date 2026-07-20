using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Демо_Экзамен_Тимур_Жуков
{
    public static class DbHelper
    {
        public static string conn = "server=localhost;user=root;password=123456;database=partners_db;";

        public static DataTable GetData(string sql)
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void RunQuery(string sql)
        {
            using (MySqlConnection c = new MySqlConnection(conn))
            {
                c.Open();
                MySqlCommand cmd = new MySqlCommand(sql, c);
                cmd.ExecuteNonQuery();
            }
        }

        
    }
}