using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q9_1_2_4_8_n_列出算式_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = Result(Convert.ToInt32(this.textBox1.Text));
        }

        private string Result(int n)
        {
            //作法一：
            //StringBuilder sb = new StringBuilder();

            //sb.Append("n=" + n + " → ");

            //for (int i = 0; i < n; i++)
            //{
            //    sb.Append(Math.Pow(2, i) + "+");
            //}

            //sb.Remove(sb.Length - 1, 1).Append("=" + (Math.Pow(2, n) - 1));

            //return sb.ToString();

            //作法二：
            StringBuilder sb = new StringBuilder();
            List<int> IntList = new List<int>();

            sb.Append("n=" + n + " → ");

            for (int i = 0; i < n; i++)
            {
                sb.Append(Math.Pow(2, i) + "+");
                IntList.Add(Convert.ToInt32(Math.Pow(2, i)));
            }

            sb.Remove(sb.Length - 1, 1).Append("=" + IntList.Sum());

            return sb.ToString();
        }
    }
}
