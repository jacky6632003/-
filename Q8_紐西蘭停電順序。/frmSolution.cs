using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q8_紐西蘭停電順序_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();

            this.label3.Text = "紐西蘭全國共分為17區，以5為間隔進行停電。\n\n例如：第1區→第6區→第11區→第16區→第5區。\n\n請列出完整的停電順序。";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TotalArea = 17;
            int interval = Convert.ToInt32(this.textBox1.Text);
            int[] sequence = new int[TotalArea];

            List<int> AreaList = new List<int>();
            for (int i = 1; i <= TotalArea; i++)
            {
                AreaList.Add(i);
            }         
            
            int index = -(interval-1);
            for (int i = 0; i < TotalArea; i++)
            {
                index += (interval-1);

                while (index >= AreaList.Count)
                {
                    index -= AreaList.Count;
                }

                sequence[i] = AreaList.ElementAt(index);

                AreaList.RemoveAt(index);
            }

            StringBuilder sb = new StringBuilder();
            foreach (int number in sequence)
            {
                sb.Append(string.Format("第{0}區\n",number));
            }

            this.label1.Text = sb.ToString();
        }
    }
}
