using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q15_判斷是否為質數
{
    public partial class FrmPrimeNumber : Form
    {
        public FrmPrimeNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = prime(Convert.ToInt32(this.textBox1.Text)).ToString();

            label2.Text = Prime(Convert.ToInt32(this.textBox1.Text));
         
        }
        public bool prime(int n)
        {
            if (n < 0)
                return false;

            int n2 = n / 2;
            for (int i = 2; i <= n2; i++)
            {
                if (n % i == 0)
                {

                    return false;
                   
                }


            } 
            return true;

        }

        private static string Prime(int Num)
        {
            List<int> temps = new List<int>();
            //因為 0,1 不算質數，所以從 2 開始
            for (int i = 2; i <= Num; i++)
            {
                //開根號取最大值+1
                int sqrt = Convert.ToInt32(Math.Sqrt(i) + 1) + 1;
                for (int j = 2; j <= sqrt; j++)
                {
                    //目前讀取的數字與要比對的數字不同
                    if (i != j)
                    {
                        //如果餘數是 0 可以斷定該數字不是質數
                        if (i % j == 0)
                            break;
                        //如果一直到最後都無法整除便可斷定該數字是質數
                        else if (i % j != 0 && j == sqrt)
                            temps.Add(i);
                    }
                }
            }
            
            return string.Join(",", temps);
        }
    }
}
