using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5_判斷n是否為2的次方_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = Determine(Convert.ToInt32(this.textBox1.Text));
        }

        private string Determine(int n)
        {
            return (n & n - 1) == 0 ? true.ToString() : false.ToString();
        }
    }
}
