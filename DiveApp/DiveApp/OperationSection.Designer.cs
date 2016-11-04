namespace DiveApp
{
    partial class OperationSection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.operationTabControl = new System.Windows.Forms.TabControl();
            this.diver1Tab = new System.Windows.Forms.TabPage();
            this.diver2Tab = new System.Windows.Forms.TabPage();
            this.diver3Tab = new System.Windows.Forms.TabPage();
            this.debriefTab = new System.Windows.Forms.TabPage();
            this.diveTableTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diveLogsButton = new System.Windows.Forms.Button();
            this.operationsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.opPlanTab = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.operationTabControl.SuspendLayout();
            this.debriefTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationTabControl
            // 
            this.operationTabControl.Controls.Add(this.opPlanTab);
            this.operationTabControl.Controls.Add(this.diver1Tab);
            this.operationTabControl.Controls.Add(this.diver2Tab);
            this.operationTabControl.Controls.Add(this.diver3Tab);
            this.operationTabControl.Controls.Add(this.debriefTab);
            this.operationTabControl.Controls.Add(this.diveTableTab);
            this.operationTabControl.Location = new System.Drawing.Point(103, 3);
            this.operationTabControl.Name = "operationTabControl";
            this.operationTabControl.SelectedIndex = 0;
            this.operationTabControl.Size = new System.Drawing.Size(902, 658);
            this.operationTabControl.TabIndex = 1;
            // 
            // diver1Tab
            // 
            this.diver1Tab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.diver1Tab.Location = new System.Drawing.Point(4, 25);
            this.diver1Tab.Name = "diver1Tab";
            this.diver1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.diver1Tab.Size = new System.Drawing.Size(894, 629);
            this.diver1Tab.TabIndex = 1;
            this.diver1Tab.Text = "Diver 1";
            // 
            // diver2Tab
            // 
            this.diver2Tab.BackColor = System.Drawing.Color.CadetBlue;
            this.diver2Tab.Location = new System.Drawing.Point(4, 25);
            this.diver2Tab.Name = "diver2Tab";
            this.diver2Tab.Size = new System.Drawing.Size(894, 629);
            this.diver2Tab.TabIndex = 2;
            this.diver2Tab.Text = "Diver 2";
            // 
            // diver3Tab
            // 
            this.diver3Tab.BackColor = System.Drawing.Color.Teal;
            this.diver3Tab.Location = new System.Drawing.Point(4, 25);
            this.diver3Tab.Name = "diver3Tab";
            this.diver3Tab.Size = new System.Drawing.Size(894, 629);
            this.diver3Tab.TabIndex = 3;
            this.diver3Tab.Text = "Diver 3";
            // 
            // debriefTab
            // 
            this.debriefTab.BackColor = System.Drawing.Color.RoyalBlue;
            this.debriefTab.Controls.Add(this.checkBox1);
            this.debriefTab.Controls.Add(this.dateTimePicker1);
            this.debriefTab.Location = new System.Drawing.Point(4, 25);
            this.debriefTab.Name = "debriefTab";
            this.debriefTab.Size = new System.Drawing.Size(894, 629);
            this.debriefTab.TabIndex = 4;
            this.debriefTab.Text = "Debrief";
            this.debriefTab.Click += new System.EventHandler(this.debriefTab_Click);
            // 
            // diveTableTab
            // 
            this.diveTableTab.BackColor = System.Drawing.Color.LightSlateGray;
            this.diveTableTab.Location = new System.Drawing.Point(4, 25);
            this.diveTableTab.Name = "diveTableTab";
            this.diveTableTab.Size = new System.Drawing.Size(894, 629);
            this.diveTableTab.TabIndex = 5;
            this.diveTableTab.Text = "Dive Table";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.diveLogsButton);
            this.panel1.Controls.Add(this.operationsButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 234);
            this.panel1.TabIndex = 0;
            // 
            // diveLogsButton
            // 
            this.diveLogsButton.Location = new System.Drawing.Point(0, 77);
            this.diveLogsButton.Name = "diveLogsButton";
            this.diveLogsButton.Size = new System.Drawing.Size(94, 77);
            this.diveLogsButton.TabIndex = 1;
            this.diveLogsButton.Text = "Dive Logs";
            this.diveLogsButton.UseVisualStyleBackColor = true;
            this.diveLogsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // operationsButton
            // 
            this.operationsButton.Location = new System.Drawing.Point(0, 0);
            this.operationsButton.Name = "operationsButton";
            this.operationsButton.Size = new System.Drawing.Size(94, 77);
            this.operationsButton.TabIndex = 0;
            this.operationsButton.Text = "Operations";
            this.operationsButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.operationTabControl, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 664);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // opPlanTab
            // 
            this.opPlanTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.opPlanTab.Location = new System.Drawing.Point(4, 25);
            this.opPlanTab.Name = "opPlanTab";
            this.opPlanTab.Padding = new System.Windows.Forms.Padding(3);
            this.opPlanTab.Size = new System.Drawing.Size(894, 629);
            this.opPlanTab.TabIndex = 0;
            this.opPlanTab.Text = "Operation Plan";
            this.opPlanTab.Click += new System.EventHandler(this.preOpTab_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(323, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // OperationSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OperationSection";
            this.Text = "Dive App - Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.operationTabControl.ResumeLayout(false);
            this.debriefTab.ResumeLayout(false);
            this.debriefTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl operationTabControl;
        private System.Windows.Forms.TabPage diver1Tab;
        private System.Windows.Forms.TabPage diver2Tab;
        private System.Windows.Forms.TabPage diver3Tab;
        private System.Windows.Forms.TabPage debriefTab;
        private System.Windows.Forms.TabPage diveTableTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button diveLogsButton;
        private System.Windows.Forms.Button operationsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage opPlanTab;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

