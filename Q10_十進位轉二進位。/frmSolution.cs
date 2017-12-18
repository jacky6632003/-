using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q10_十進位轉二進位_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = Result(Convert.ToString(Convert.ToInt32(this.textBox1.Text), 2).Reverse());
        }

        private string Result(IEnumerable<char> chars)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in chars)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
