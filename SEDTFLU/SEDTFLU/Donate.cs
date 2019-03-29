using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace SEDTFLU
{
    public partial class Donate : UserControl
    {
        public Donate()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.me/saajaadeen");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCNCCzQEMHGJtjg8E0d5ALxA");
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
