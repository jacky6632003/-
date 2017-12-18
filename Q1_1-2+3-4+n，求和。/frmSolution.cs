using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_1_2_3_4_n_求和_
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
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n % 2 == 0 ? -n + Calculate(n - 1) : n + Calculate(n - 1);
            }
        }
    }
}
