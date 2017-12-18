using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3_1_2_3_4_n_用遞迴求積_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = Calculate(Convert.ToInt32(this.textBox1.Text)).ToString();
        }

        private int Calculate(int n)
        {
            return n == 1 ? 1 : n * Calculate(n - 1);
        }
    }
}
