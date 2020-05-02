/*
【时      间】：2020年3月12日16:39:53
【题      目】：实现简单的计算器。
【知 识  点】：算术运算符
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第02章_语法基础_实例011_算符运算符
{
    class Calculator
    {
        public int GetSum(int a,string oper,int b) {
            switch (oper)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b!=0)
                    {
                    return a / b;
                    }
                    else
                    {
                        Console.WriteLine("除数不能为0！");
                        return -123456789;
                    }
                default:
                    Console.Write("输入错误：");
                    return -123456789;
            }
        }
    }
    class Program
    {
        static void Main(string[] args) {
            Calculator c = new Calculator();
            Console.Write("请输入第一个数：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("请输入+、-、x、÷：");
            string oper = " ";
            oper = Console.ReadLine();
            Console.Write("请输入第二个数：");
            int b = int.Parse(Console.ReadLine());
           int res =  c.GetSum(a, oper, b);
            Console.WriteLine("{0} {1} {2} = {3}",a,oper,b,res);
            Console.ReadKey();
        }
    }
}
