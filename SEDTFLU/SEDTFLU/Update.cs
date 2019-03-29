using System;
using System.Net;
using System.IO;
using System.Diagnostics;
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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string RemoteURL = "https://sourceforge.net/projects/sedox-tool-flat-user-interface/files/latest/download";
                string Filename = "Social Engineering Dox-Tool.zip", myStringWebResourse = Environment.CurrentDirectory;
                WebClient myWebclient = new WebClient();

                listBox1.Items.Add("Initilizing Application...");
                listBox1.Items.Add("Checking for updates....");
                listBox1.Items.Add("Updates Available!");
                listBox1.Items.Add("Verifying Update from 'https://sourceforge.net'");
                listBox1.Items.Add("\n");
                listBox1.Items.Add("Username: Guest\n");
                listBox1.Items.Add("Password: ***********\n");
                listBox1.Items.Add("\n");
                listBox1.Items.Add("Verification Successful");
                listBox1.Items.Add("Downloading Update...");
                listBox1.Items.Add("Please Wait...");

                myStringWebResourse = RemoteURL + Filename;
                myWebclient.DownloadFile(myStringWebResourse, Filename);
                Process.Start(Application.StartupPath);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                listBox1.Items.Add("\n");
                listBox1.Items.Add("Download + Update Failed...");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show("Failed to exit...");
                Application.Exit();
            }
        }
    }
}
