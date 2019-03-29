using System;
using System.Net.NetworkInformation;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace SEDTFLU
{
    public partial class Main : Form
    {
        /// CAUTION! //
        /// ///////////
        int mov;
        int movX;
        int movY;
        public Main()
        {
            InitializeComponent();
            SelectPanel.Height = Dashboard.Height;
            SelectPanel.Top = Dashboard.Top;
            newsStand1.BringToFront();
            userDashboard1.Hide();
            try
            {
                Mutex mutex = new Mutex(false, "FlatuiMutex");
                if (mutex.WaitOne(0, false))
                {
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.EnableVisualStyles();
                    Application.Run(new Form());
                }
                else
                {
                    try
                    {
                        MessageBox.Show("An instance of the application is Currently running.");
                        this.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        //       **DO NOT EDIT THIS SECTION NOR THE CAUTION SECTION!!**
        //    **THESE LETS YOU MOVE THE APPLICATION AROUND YOUR SCREEN!!**
        /////////////////////////////////////////////////////////////////////
        private void Main_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    label2.Text = "CONNECTED";
                    label2.ForeColor = Color.LimeGreen;
                }
                else
                {
                    label2.Text = "DISCONNECTED";
                    label2.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to capture network Availability");
            }
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = Dashboard.Height;
            SelectPanel.Top = Dashboard.Top;
            newsStand1.BringToFront();
        }
        private void Console_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = Console.Height;
            SelectPanel.Top = Console.Top;
            console1.BringToFront();

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "CShell.exe";
                process.Start();
                
            }
            catch (Exception)
            {
                MessageBox.Show("\n" +
                                "Failed to open Console... Error Code: 0x80004005\n" +
                                "\n" +
                                "Please Locate Application and Try again later...");
            }
        } 
        private void ToolsButton_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = ToolsButton.Height;
            SelectPanel.Top = ToolsButton.Top;
            tools1.BringToFront();
        }
        private void DonateButton_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = DonateButton.Height;
            SelectPanel.Top = DonateButton.Top;
            donate1.BringToFront();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settings1.BringToFront();
            SelectPanel.Height = SettingsButton.Height;
            SelectPanel.Top = SettingsButton.Top;
        }
        private void FileButton_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = FileButton.Height;
            SelectPanel.Top = FileButton.Top;
            file1.BringToFront();
        }
        private void MiscButton_Click(object sender, EventArgs e)
        {
            about1.BringToFront();
            SelectPanel.Height = MiscButton.Height;
            SelectPanel.Top = MiscButton.Top;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("failed to exit program please restart.");
            }
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (mov == 1)
                {
                    this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                }
            }
            catch
            {
                MessageBox.Show("Failed to navigate window please restart program.");
            }
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            userDashboard1.Show();
            userDashboard1.BringToFront();
        }
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            userDashboard1.Hide();
        }
    }
}
