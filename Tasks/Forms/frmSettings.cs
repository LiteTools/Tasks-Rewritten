﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasks.Forms;

namespace Tasks
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            if (Properties.Settings.Default.CleanupMessageBox == true)
            {
                checkBox1.Checked = true;
            }

            if (Properties.Settings.Default.CleanupMessageBox == false)
            {
                checkBox1.Checked = false;
            }

            if (Properties.Settings.Default.EnableCleanupLogs == true)
            {
                checkBox2.Checked = true;
            }

            if (Properties.Settings.Default.EnableCleanupLogs == false)
            {
                checkBox2.Checked = false;
            }

            if (Properties.Settings.Default.Theme == "dark")
            {
                radioButton1.Checked = true;
            }

            if (Properties.Settings.Default.Theme == "light")
            {
                radioButton2.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.CleanupMessageBox = true;
            }
            if (checkBox1.Checked == false)
            {
                Properties.Settings.Default.CleanupMessageBox = false;
            }
            Properties.Settings.Default.Save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText == "English")
            {
                // Switch back to English.
            }

            if (comboBox1.SelectedText == "Spanish")
            {
                // Hey, we're looking for translators!!!
            }


        }
        
        frmMain Main = new frmMain();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Properties.Settings.Default.Theme = "dark";
                Main.CheckTheme();

                CheckTheme();
            }

            if (radioButton2.Checked)
            {
                Properties.Settings.Default.Theme = "light";
                Main.CheckTheme();

                CheckTheme();
            }

            Properties.Settings.Default.Save();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            CheckTheme();
        }

        public void CheckTheme()
        {
            if (Properties.Settings.Default.Theme == "light")
            {
                this.BackColor = Color.FromArgb(250, 250, 250);
              
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label18.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
                checkBox2.ForeColor = Color.Black;
                checkBox1.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                comboBox1.BackColor = Color.GhostWhite;
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.EnableCleanupLogs = true;
            }
            if (checkBox2.Checked == false)
            {
                Properties.Settings.Default.EnableCleanupLogs = false;
            }
            Properties.Settings.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSettingsHolder NewSettings = new frmSettingsHolder();
            NewSettings.Show();
        }
    }
}
