using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace sklep_SQLite
{
    class polaczenie
    {
        
        
        /*
        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("INSERT INTO SampleTable(Col1,Col2) VALUES ('Sample Text',1)");
            sqliteCommand.ExecuteNonQuery();
        }
        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("SELECT * FROM SampleTable");
            sqliteReader = sqliteCommand.ExecuteReader();
            while (sqliteReader.Read())
            {
                string readerString = sqliteReader.GetString(0);
                Console.WriteLine(readerString);
            }
            conn.Close();
        }
        */
    }
}
