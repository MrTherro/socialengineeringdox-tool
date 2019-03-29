using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SEDTFLU
{
    public partial class UserDashboard : UserControl
    {
        public UserDashboard()
        {
            InitializeComponent();
            textBox1.Text = "Search";
            UBDlabel.Text = Environment.UserName;
            // region info
            string name = RegionInfo.CurrentRegion.DisplayName;
            Location.Text = "Location: " + name;
        }
        ToolTip TlTip = new ToolTip();
        private void UserDashboard_Load(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Dark Theme: ON")
            {
                button4.Text = "Dark Theme: OFF";
                Thread.Sleep(1000);
                this.BackColor = Color.FromArgb(223, 228, 234);
            }
            else if (button4.Text == "Dark Theme: OFF")
            {
                button4.Text = "Dark Theme: ON";
                Thread.Sleep(1000);
                this.BackColor = Color.FromArgb(80, 80, 80);
            }
        }
        private void Location_MouseHover(object sender, EventArgs e)
        {
            TlTip.Show("Depending on Your location this will \n" +
                       "show the user's region location.", Location);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (SignOutUDB.Text == "Sign Out")
            {
                Thread.Sleep(1000);
                UBDlabel.Text = "Local User";
                SignOutUDB.Text = "Sign In";
                button1.Enabled = false;
                button3.Enabled = false;
                button6.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                Location.Enabled = false;
                
            }
            else if (SignOutUDB.Text == "Sign In")
            {
                Thread.Sleep(1000);
                UBDlabel.Text = Environment.UserName;
                SignOutUDB.Text = "Sign Out";
                button1.Enabled = true;
                button3.Enabled = true;
                button6.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                Location.Enabled = true;
                
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://sourceforge.net/projects/sedox-tool-flat-user-interface/reviews/new");
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("We had a problem processing your request. Please Try again later...\n" +
                                "\n" +
                                Ex);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Account show = new Account();
            show.ShowDialog();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DGR = MessageBox.Show("Close the Application?", "Application Exit", MessageBoxButtons.YesNo);
                if (DGR == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (DGR == DialogResult.No)
                {
                    // leaving this blank will close the messagebox when you press no.
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to exit Application!");
            }
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }
        private void UserDashboard_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "Search";
        }
        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "Search";
        }
    }
}
