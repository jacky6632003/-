using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q12_判斷數字出現的次數_LINQ版_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = CalculateTimes(this.textBox1.Text);
        }

        private string CalculateTimes(string str)
        {
            var result = (from s in str
                          group s by s into pair
                          select new
                          {
                              number = pair.Key,
                              times = pair.Count()
                          }).OrderBy(p => p.number);

            StringBuilder sb = new StringBuilder();
            foreach (var pair in result)
            {
                sb.Append(pair.number + " 出現 " + pair.times + " 次。\n");
            }

            return sb.ToString();
        }
    }
}
