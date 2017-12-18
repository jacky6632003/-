using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4_用BubbleSort排序數列_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = BubbleSort(this.textBox1.Text.Split(new char[]{','}));
        }

        private string BubbleSort(string[] strs)
        {
            int[] ints = Array.ConvertAll(strs, element => Convert.ToInt32(element));

            for (int i = 1; i <= ints.Length - 1; i++)
            {
                for (int j = 1; j <= ints.Length - i; j++)
                {
                    if (ints[j] < ints[j - 1])
                    {
                        int temp=ints[j];
                        ints[j] = ints[j - 1];
                        ints[j - 1] = temp;
                    }
                }
            }

            return string.Join(",", ints);
        }

      
    }
}
