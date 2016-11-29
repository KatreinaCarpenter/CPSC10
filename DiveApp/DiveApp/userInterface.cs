////////////////////////////////////////////////////////////////////////////////
// System:
// File:
// Author: Katreina Carpenter
// Updated: 10/27/2016
// Compiler: Microsoft Visual C#
//
// <Comments on what the module contains, parameters passed to it, special
// processing done, etc.>
// 
// Date         Who                  Comments
////////////////////////////////////////////////////////////////////////////////
// 10/27/2016   Katreina Carpenter   <Notes on significant changes made>
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiveApp
{
    public partial class userInterface : Form
    {
        public DiveDB database = new DiveDB();

        public userInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void preOpTab_Click(object sender, EventArgs e)
        {

        }

        private void debriefTab_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            database.setVesselProblemsDescription(vesselProblemsDescription.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            database.writeDB();
            //writeToFile();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (vesselProblemsYes.Checked)
            {
                database.setVesselProblemsBool(1);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (equipmentProblemsNo.Checked)
            {
                database.setEquipmentProblemsBool(0);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            database.setEquipmentProblemsDescription(equipmentProblemsDescription.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            database.setInjuriesDescription(injuriesDescription.Text);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (supervisorCompletedYes1.Checked)
            {
                database.setInjuriesSupervisorBool(1);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (supervisorCompletedNo1.Checked)
            {
                database.setInjuriesSupervisorBool(0);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            database.setInjuriesSupervisorName(supervisorDescription1.Text);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (lostDamagedPropertyYes.Checked)
            {
                database.setDamagesBool(1);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            database.setDamagesDescription(lostDamagedPropertyDescription.Text);
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (supervisorCompletedYes2.Checked)
            {
                database.setDamagesSupervisorBool(1);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            database.setWorkedWell(workedWellDescription.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            database.setNotWorkedWell(notWorkWellDescription.Text);
        }

        private void radioButtonOutput(RadioButton selection, TextBox text, String label, StreamWriter writer)
        {
            if (selection.Checked == true)
            {
                writer.WriteLine(label + ": Yes");
                writer.WriteLine(label + " Details: " + text.Text);
            }
            else
                writer.WriteLine(label + ": No");
        }

        private void debrief_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void debrief_date_ValueChanged_1(object sender, EventArgs e)
        {
            database.setDate(debrief_date.Value.Date.ToString());
        }

        private void vesselProblemsNo_CheckedChanged(object sender, EventArgs e)
        {
            if (vesselProblemsNo.Checked)
            {
                database.setVesselProblemsBool(0);
            }
        }

        private void equipmentProblemsYes_CheckedChanged(object sender, EventArgs e)
        {
            if (equipmentProblemsYes.Checked)
            {
                database.setEquipmentProblemsBool(1);
            }
        }

        private void injuriesYes_CheckedChanged(object sender, EventArgs e)
        {
            if (injuriesYes.Checked)
            {
                database.setInjuriesBool(1);
            }
        }

        private void injuriesNo_CheckedChanged(object sender, EventArgs e)
        {
            if (injuriesNo.Checked)
            {
                database.setInjuriesBool(0);
            }
        }

        private void lostDamagedPropertyNo_CheckedChanged(object sender, EventArgs e)
        {
            if (lostDamagedPropertyNo.Checked)
            {
                database.setDamagesBool(0);
            }
        }

        private void supervisorCompletedNo2_CheckedChanged(object sender, EventArgs e)
        {
            if (supervisorCompletedNo2.Checked)
            {
                database.setDamagesSupervisorBool(0);
            }   
        }

        private void supervisorDescription2_TextChanged(object sender, EventArgs e)
        {
            database.setDamagesSupervisorName(supervisorDescription2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }
    }
}