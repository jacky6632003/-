using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q12_判斷數字出現的次數_Dictionary版_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text=CalculateTimes(this.textBox1.Text);
        }

        private string CalculateTimes(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c] += 1;
                }
            }

            var result = dic.OrderBy(d => d.Key);

            StringBuilder sb = new StringBuilder();
            foreach (var pair in result)
            {
                sb.Append(pair.Key + " 出現 " + pair.Value + " 次。\n");
            }

            return sb.ToString();
        }
    }
}
