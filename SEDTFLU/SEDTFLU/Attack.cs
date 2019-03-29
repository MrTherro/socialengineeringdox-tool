using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDTFLU
{
    public partial class Attack : Form
    {
        public Attack()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            record1.BringToFront();
            SelectPanel.Height = button2.Height;
            SelectPanel.Top = button2.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search1.BringToFront();
            SelectPanel.Height = button4.Height;
            SelectPanel.Top = button4.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = button1.Height;
            SelectPanel.Top = button1.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = button3.Height;
            SelectPanel.Top = button3.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bannerGrabber1.BringToFront();
            SelectPanel.Height = button5.Height;
            SelectPanel.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = button6.Height;
            SelectPanel.Top = button6.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            synFlood1.BringToFront();
            SelectPanel.Height = button7.Height;
            SelectPanel.Top = button7.Top;
        }

        private void Attack_Load(object sender, EventArgs e)
        {
            record1.BringToFront();
            SelectPanel.Height = button2.Height;
            SelectPanel.Top = button2.Top;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sqlinject1.BringToFront();
            SelectPanel.Height = button11.Height;
            SelectPanel.Top = button11.Top;
        }
    }
} 
