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

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DiveDB database = new DiveDB();
            database.writeDB();
            //writeToFile();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

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

        private void writeToFile()
        {
            StreamWriter writer = new StreamWriter("D:\\Users\\Mark\\Desktop\\OperationsDebriefTest.txt");
            writer.WriteLine("Operations Debrief");
            writer.WriteLine("Date: " + dateTimePicker1.Value.Date);

            radioButtonOutput(radioButton1, textBox1, "Vessel Problems", writer);
            radioButtonOutput(radioButton3, textBox2, "Equipment Problems", writer);
            /*

            if (radioButton1.Checked == true)
            {
                writer.WriteLine("Vessel Problems: Yes");
                writer.WriteLine("Vessel Problem Details: " + textBox1.Text);
            }
            else
                writer.WriteLine("Vessel Problems: No");


            if (radioButton3.Checked == true)
            {
                writer.WriteLine("Equipment Problems: Yes");
                writer.WriteLine("Equipment Problem Details: " + textBox2.Text);
            }
            else
                writer.WriteLine("Equipment Problems: No");

            if (radioButton5.Checked == true)
            {
                writer.WriteLine("Injuries: Yes");
                writer.WriteLine("Injury Details: " + textBox3.Text);
            }
            else
                writer.WriteLine("Injuries: No");

            if (radioButton8.Checked == true)
            {
                writer.WriteLine("Injuries Administration Packet Completed by a Supervisor: Yes");
                writer.WriteLine("Completed by: " + textBox4.Text);
            }
            else
                writer.WriteLine("Injuries Administration Packet Completed by a Supervisor: No");

            if (radioButton12.Checked == true)
            {
                writer.WriteLine("Lost or Damaged Department Property: Yes");
                writer.WriteLine("Lost or Damaged Propety Details: " + textBox5.Text);
            }
            else
                writer.WriteLine("Lost or Damaged Department Property: No");

            if (radioButton16.Checked == true)
            {
                writer.WriteLine("Lost or Damaged Department Property Administrative Packet Completed: Yes");
                writer.WriteLine("Completed by: " + textBox6.Text);
            }
            else
                writer.WriteLine("Lost or Damaged Department Property Administrative Packet Completed: No");

            writer.WriteLine("Worked Well: " + textBox7.Text);
            writer.WriteLine("Did Not Work Well: " + textBox8.Text);
            */

            writer.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
