using System;

namespace Ø168_3__Data_SQLite_EF_
{
    class Program
    {

        private static string databaseFil = "c:\\tmp\\people.db";
        private static string connectionString = "Data Source=" + databaseFil;

        static void Main(string[] args)
        {
            using (System.Data.SQLite.SQLiteConnection cn = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                cn.Open();
                using (System.Data.SQLite.SQLiteCommand cm = new System.Data.SQLite.SQLiteCommand(cn))
                {
                    cm.CommandText = "select count(*) from person where height<160";
                    cm.CommandType = System.Data.CommandType.Text;
                    object resultat = cm.ExecuteScalar();
                    Console.WriteLine($"Der er {resultat} under 160 i tabellen");
                }
            }
        }
    }


}
