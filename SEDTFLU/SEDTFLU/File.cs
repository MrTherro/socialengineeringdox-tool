using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SEDTFLU
{
    public partial class File : UserControl
    {
        public File()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DGR = MessageBox.Show("Close the Application?", "Application Exit", MessageBoxButtons.YesNo);
                if(DGR == DialogResult.Yes)
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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Update show = new Update();
            show.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://sourceforge.net/projects/sedox-tool-flat-user-interface/reviews/new");
        }
    }
}
