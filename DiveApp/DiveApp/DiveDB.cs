using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace DiveApp
{
    class DiveDB
    {
        private SQLiteConnection m_dbConnection;

        public DiveDB()
        {
            // create and connect to the database 
            SQLiteConnection.CreateFile("Dive.sqlite");
            m_dbConnection = new SQLiteConnection("Data Source=Dive.sqlite;Version=3;");
            m_dbConnection.Open();

            // create a table
            string sql = "create table dive (id int, tab_name varchar(20), label_name varchar(20), input varchar(20))";
            //string sql = "create table student (first_name varchar(20), last_name varchar(20), id int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void writeDB()
        {
            StreamWriter writer = new StreamWriter("D:\\Users\\Mark\\Desktop\\DBTest.txt");


            string sql = "insert into dive (id, tab_name, label_name, input) ";

            sql += "values ('" + "47412498" + "', " + "'" + "Debrief" + "', " + "Equipment" + "', " + "broken" + ")";/////////////Andrew can you fix this?
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            // query the table and output the results to a file
            sql = "select * from dive";

            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                writer.WriteLine("ID: " + reader["id"] + "\tTab Name: " + reader["tab_name"] + "\tLabel Name: " + reader["label_name"] + "\tInput: " + reader["input"]);
            writer.Close();
        }
    }
}
