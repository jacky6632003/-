using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q7_找錢系統_
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();

            this.label3.Text = "購買金額為1~999的整數，\n\n顧客給1000元，\n\n要找幾個百元鈔、五十元幣、十元幣、一元幣？";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = Change(1000 - Convert.ToInt32(this.textBox1.Text));
        }

        private string Change(int money)
        {
            int hundred, fifty, ten, one;
            one = Ten(Fifty(Hundred(money, out hundred), out fifty), out ten);
            return string.Format("百元鈔 {0} 張\n五十元幣 {1} 枚\n十元幣 {2} 枚\n一元幣 {3} 枚",hundred,fifty,ten,one);
        }

        private int Hundred(int money,out int hundred)
        {
            hundred = money / 100;
            return money % 100;
        }

        private int Fifty(int money, out int fifty)
        {
            fifty = money / 50;
            return money % 50;
        }

        private int Ten(int money, out int ten)
        {
            ten = money / 10;
            return money % 10;
        }
    }
}
