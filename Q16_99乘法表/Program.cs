using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16_99乘法表
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 9)
            {
                int j = 1;
                while (j <= i)
                {
                    float result = j * i;
                    Console.Write("{0}*{1}={2}\t", j, i, result);//此处可以使用':00'或者\t来控制位置  
                    j++;
                }
                Console.WriteLine();
                i++;
            }

            Console.WriteLine();
            int sum;
            //  
            for (int a = 1; a < 10; a++)
            {
                for (int j = 1; j < 10-a+1; j++)
                {
                    sum = a * j;
                    Console.Write(a + "*" + j + "=" + sum + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int num1 = 1; num1 <= 9; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    int sum2 = num1 * num2;
                    Console.Write(num1 + "*" + num2 + "=" + sum2 + "\n");

                }


            }
            int c = 1;
            int d = 1;

            Console.WriteLine(c == d);

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = i; j <= 9; j++)
            //    {
            //        Console.Write(i.ToString() + "*" + j.ToString() + "=" + (i * j).ToString() + "\t");
            //    }
            //    Console.WriteLine();
            //}


            Console.Read(); //程式暫停等候按鍵
        }

        public static void test1()//九九乘法表  
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "*" + i + " ");
                }
                Console.WriteLine();
            }
        }


        public static void testt()
        {
            Console.WriteLine("輸入：");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear(); //清除以上显示的内容  
            //这层循环控制打印的行数  
            for (int i = 1; i <= n; i++)
            {
                //这层循环控制每行前面打印的空格数  
                for (int k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }
                //这层循环控制每行前面打印*的个数  
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                //每打印完一行换一下行  
                Console.Write("\n");
            }
            Console.ReadKey();

            //打印菱形的上半部，等腰三角形  
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //打印倒等腰三角形  
            for (int i = 8; i >= 0; i--)
            {
                for (int j = i; j <= 8; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();



        }


    }
}
