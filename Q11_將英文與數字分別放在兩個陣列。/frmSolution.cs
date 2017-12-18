using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q11_將英文與數字分別放在兩個陣列_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();

            this.textBox1.Text = "Jack,10,14";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strs = this.textBox1.Text.Split(new char[] { ',' });

            ArrayList StrAL = new ArrayList();
            ArrayList IntAL = new ArrayList();

            foreach (string s in strs)
            {
                int i;

                if (int.TryParse(s, out i))
                {
                    IntAL.Add(i);
                }
                else
                {
                    StrAL.Add(s);
                }
            }

            this.label1.Text = string.Join("\n", StrAL.ToArray());
            this.label2.Text = string.Join("\n", IntAL.ToArray());
        }
    }
}
