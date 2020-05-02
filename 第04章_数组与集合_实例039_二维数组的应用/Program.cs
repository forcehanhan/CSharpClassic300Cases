/*
【时      间】：2020年3月12日23:55:02
【题      目】：简单的列车售票系统，功能：
                    1、可以查询哪些是空座，哪些是已售出。
                    2、如果座位是空座，则可以将该座位的票售出。
【知 识  点】：二维数组的应用。
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第04章_数组与集合_实例039_二维数组的应用
{
    class Program
    {
        static void Main(string[] args) {
            #region 方法一
            /*
                        int m=20;
                        int n=5;
                        Random random = new Random();
                        bool[,] isSold = new bool[20, 5];
                        bool temp = isSold[0, 0];
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                int r = random.Next(2);//返回区间[0,2)中的值,有0、1，最大值不包含2。如果是Random.Next(0)，则区间为[0,0],最大值包含0。
                                if (r >= 1 && r < 2)
                                {
                                    Console.Write("{0:D3}：有票\t", i * 5 + j + 1);
                                }
                                else
                                {
                                    Console.Write("{0:D3}：无票\t", i * 5 + j + 1);
                                }
                            }
                            Console.WriteLine();
                        }
            */
            #endregion

            #region 方法二
            //随机售票情况
            int m = 20;
            int n = 5;
            Random random = new Random();
            bool[,] isSold = new bool[m, n];
            bool temp = isSold[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    isSold[i, j] = random.Next(2) >= 1;
                    Console.Write("{0:D3}:{1}\t", i * n + j + 1, isSold[i, j] == true ? "有票" : "无票");//i * 5 + j + 1:内循环是每5个数为一个周期
                }
                Console.WriteLine();
            }

            //查询票
            Console.Write("请输入座位号：");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (number == (i * n + j + 1))
                    {
                        Console.WriteLine("{0:D3}:{1}\t", number, isSold[i, j] == true ? "有票" : "无票");
                    }
                }
            }


            /*   if (isSold[(number - 1) % m, (number - 1) % n])
               {
                   Console.WriteLine("{0:D3}:有票", number);
               }
               else
               {
                   Console.WriteLine("{0:D3}:无票", number);
               }*/
            #endregion
            Console.ReadKey();
        }
    }
}
