using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDTFLU
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
            this.Enabled = true;
        }
        private void settings_Load(object sender, EventArgs e)
        {
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox6.Text == "Dark Theme: ON")
                {
                    checkBox6.Text = "Dark Theme: OFF";
                    Thread.Sleep(1000);
                    this.BackColor = Color.FromArgb(223, 228, 234);
                    groupBox1.BackColor = Color.FromArgb(223, 228, 234);
                    groupBox2.BackColor = Color.FromArgb(223, 228, 234);
                    groupBox3.BackColor = Color.FromArgb(223, 228, 234);
                }
                else if (checkBox6.Text == "Dark Theme: OFF")
                {
                    checkBox6.Text = "Dark Theme: ON";
                    Thread.Sleep(1000);
                    this.BackColor = Color.FromArgb(80, 80, 80);
                    groupBox1.BackColor = Color.FromArgb(80, 80, 80);
                    groupBox2.BackColor = Color.FromArgb(80, 80, 80);
                    groupBox3.BackColor = Color.FromArgb(80, 80, 80);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("We ran into a problem processing your request.\n" +
                                "\n" +
                                Ex);
            }
            
        }
    }
}
