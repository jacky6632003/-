using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q6_將1_100亂數塞入長度為100的陣列而不重複_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(this.textBox1.Text);

            int[] ints = new int[length];

            List<int> IntList = new List<int>();
            for (int i = 1; i <= length; i++)
            {
                IntList.Add(i);
            }

            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                int number = IntList.ElementAt(r.Next(0, IntList.Count));
                ints[i] = number;
                IntList.Remove(number);
            }

            StringBuilder sb = new StringBuilder();
            foreach (int i in ints)
            {
                sb.Append(i + "\n");
            }

            this.label1.Text = sb.ToString();
        }
    }
}
