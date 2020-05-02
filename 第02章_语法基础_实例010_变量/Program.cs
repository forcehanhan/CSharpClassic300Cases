/*
【时      间】：2020年3月12日12:44:27
【题      目】：计算矩形的面积。
【知 识  点】：变量。
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第02章_语法基础_实例010_变量
{
    class Rectangle
    {
        private int lenth;
        private int width;

        public int Lenth { get => lenth; set => lenth = value; }
        public int Width { get => width; set => width = value; }
        public Rectangle(int lenth, int width) {
            this.lenth = lenth;
            this.width = width;
        }
        public int GetArea() {
            checked//如果发生溢出，则会报错
            {
            return Lenth * Width;
            }
        }
    }
    class Program
    {
        static void Main(string[] args) {
            Rectangle rectangle = new Rectangle(100, 200);
            Console.WriteLine("矩形的面积=" + rectangle.GetArea());
            Console.ReadKey();
        }
    }
}
