using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace DiveApp
{
    public class DiveDB
    {
        private string date = "NA";
        private int vesselProblemsBool = 1;
        private string vesselProblemsDescription = "NA";
        private int equipmentProblemsBool = 1;
        private string equipmentProblemsDescription = "NA";
        private int injuriesBool = 1;
        private string injuriesDescription = "NA";
        private int injuriesSupervisorBool = 1;
        private string injuriesSupervisorName = "NA";
        private int damagesBool = 1;
        private string damagesDescription = "NA";
        private int damagesSupervisorBool = 1;
        private string damagesSupervisorName = "NA";
        private string workedWell = "NA";
        private string notWorkedWell = "NA";
        private SQLiteConnection m_dbConnection;

        public DiveDB()
        {
            // create and connect to the database 
            if (File.Exists("Dive.sqlite"))//Change back to false
            {
                SQLiteConnection.CreateFile("Dive.sqlite");
            }

            m_dbConnection = new SQLiteConnection("Data Source=Dive.sqlite;Version=3;");
            m_dbConnection.Open();

            if (File.Exists("Dive.sqlite"))//change back to false
            {
                // create a table for the debrief section
                string sql = "create table debrief (date varchar(255), vessel_problem boolean, vessel_problem_description varchar(255), ";
                sql += "equipment_problem boolean, equipment_problem_description varchar(255), injuries boolean, injuries_description varchar(255), ";
                sql += "injury_supervisor boolean, injury_supervisor_name varchar(255), damages boolean, damages_description varchar(255), ";
                sql += "damages_supervisor boolean, damages_supervisor_name varchar(255), worked_well varchar(255), worked_bad varchar(255))";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
        }

        public void writeDB()
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\Katreina\\Desktop\\DBTest.txt");

            //string sql = "insert into debrief values ('Sunday, November 20th', 0, 'NA', 1, 'Faulty mask', 'Sliced finger', 1, 'Jim', 0, 'NA', 1, 'Thad', 'Everything', 'Nothing')";
            string sql = "insert into debrief values ('" + date + "', " + vesselProblemsBool + ", '" + vesselProblemsDescription + "', " + equipmentProblemsBool + ", '" + equipmentProblemsDescription;
            sql += "', " + injuriesBool + ", '" + injuriesDescription + "', " + injuriesSupervisorBool + ", '" + injuriesSupervisorName + "', " + damagesBool + ", '" + damagesDescription + "', ";
            sql += damagesSupervisorBool + ", '" + damagesSupervisorName + "', '" + workedWell + "', '" + notWorkedWell + "')"; 

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            // query the table and output the results to a file
            sql = "select * from debrief";

            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                writer.WriteLine("Date: " + reader["date"]);
                writer.WriteLine("Vessel Problem: " + reader["vessel_problem"]);
                writer.WriteLine("  Description: " + reader["vessel_problem_description"]);
                writer.WriteLine("Equipment Problem: " + reader["equipment_problem"]);
                writer.WriteLine("  Description: " + reader["equipment_problem_description"]);
                writer.WriteLine("Injuries: " + reader["injuries"]);
                writer.WriteLine("  Description: " + reader["injuries_description"]);
                writer.WriteLine("  Supervisor: " + reader["injury_supervisor"]);
                writer.WriteLine("    Name: " + reader["injury_supervisor_name"]);
                writer.WriteLine("Damages: " + reader["damages"]);
                writer.WriteLine("  Description: " + reader["damages_description"]);
                writer.WriteLine("  Supervisor: " + reader["damages_supervisor"]);
                writer.WriteLine("    Name: " + reader["damages_supervisor_name"]);
                writer.WriteLine("What worked well: " + reader["worked_well"]);
                writer.WriteLine("What didn't work well: " + reader["worked_bad"]);
            }
            writer.Close();
        }

        public void setDate(string newDate)
        {
            date = newDate;
        }

        public void setVesselProblemsBool(int newVesselProblemsBool)
        {
            vesselProblemsBool = newVesselProblemsBool;
        }

        public void setVesselProblemsDescription(string newDescription)
        {
            vesselProblemsDescription = newDescription;
        }

        public void setEquipmentProblemsBool(int newEquipmentProblemsBool)
        {
            equipmentProblemsBool = newEquipmentProblemsBool;
        }

        public void setEquipmentProblemsDescription(string newDescription)
        {
            equipmentProblemsDescription = newDescription;
        }

        public void setInjuriesBool(int newInjuriesBool)
        {
            injuriesBool = newInjuriesBool;
        }

        public void setInjuriesDescription(string newDescription)
        {
            injuriesDescription = newDescription;
        }

        public void setInjuriesSupervisorBool(int newInjuriesSupervisorBool)
        {
            injuriesSupervisorBool = newInjuriesSupervisorBool;
        }

        public void setInjuriesSupervisorName(string newName)
        {
            injuriesSupervisorName = newName;
        }

        public void setDamagesBool(int newDamagesBool)
        {
            damagesBool = newDamagesBool;
        }

        public void setDamagesDescription(string newDescription)
        {
            damagesDescription = newDescription;
        }

        public void setDamagesSupervisorBool(int newDamagesSupervisorBool)
        {
            damagesSupervisorBool = newDamagesSupervisorBool;
        }

        public void setDamagesSupervisorName(string newName)
        {
            damagesSupervisorName = newName;
        }

        public void setWorkedWell(string newWorkedWell)
        {
            workedWell = newWorkedWell;
        }

        public void setNotWorkedWell(string newNotWorkedWell)
        {
            notWorkedWell = newNotWorkedWell;
        }
    }
}
