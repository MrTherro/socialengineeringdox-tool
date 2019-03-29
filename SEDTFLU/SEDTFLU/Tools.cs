using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDTFLU
{
    public partial class Tools : UserControl
    {
        public Tools()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Attack atk = new Attack();
            atk.ShowDialog();
        }
    }
}
