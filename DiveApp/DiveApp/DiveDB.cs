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
            string sql = "create table student (first_name varchar(20), last_name varchar(20), id int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void writeDB()
        {
            StreamWriter writer = new StreamWriter("D:\\Users\\Mark\\Desktop\\DBTest.txt");


            string sql = "insert into student (first_name, last_name, id) ";

            sql += "values ('" + "Mark" + "', " + "'" + "Houston" + "', " + "47412498" + ")";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            // query the table and output the results to a file
            sql = "select * from student";

            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                writer.WriteLine("First Name: " + reader["first_name"] + "\tLast Name: " + reader["last_name"] + "\tStudent ID: " + reader["id"]);
            writer.Close();
        }
    }
}
