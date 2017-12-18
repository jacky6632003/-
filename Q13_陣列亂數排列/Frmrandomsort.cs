using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q13_陣列亂數排列
{
    public partial class Frmrandomsort : Form
    {
        public Frmrandomsort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text= RandomSort(this.textBox1.Text.Split(new char[] { ',' }));
        }

        private string RandomSort(string[] strs)
        {
            int[] ints = Array.ConvertAll(strs, element => Convert.ToInt32(element));

            int len = ints.Length;
            int[] a = ints;
            int[] b = new int[len];

            //for (int i = 0; i < len; i++) a[i] = i + 1;

            Random rnd = new Random();
            int r, aLen;
            int[] tmp = new int[0];

            for (int i = 0; i < len; i++)
            {
                aLen = a.Length;
                r = rnd.Next(0, aLen);
                b[i] = a[r];
                Array.Resize(ref tmp, aLen - 1);

                for (int j = 0, k = 0; j < aLen; j++)
                {
                    if (j != r) tmp[k++] = a[j];
                }

                a = tmp;
            }

            return string.Join(",", b);
        }
    }
}
