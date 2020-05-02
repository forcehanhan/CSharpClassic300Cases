/*
【时      间】：2020年3月12日00:52:51
【题      目】：判断矩形是否为正方形。
【知 识  点】：结构体和类有什么区别？
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第02章_语法基础_实例006_结构体和布尔类型
{
    //方法一：用结构去写，不使用封装
    struct Rectangle
    {
        public int width ;
        public int height;
        //public int width = 100;//错误！！！结构体中的字段不能被初始化
        //public int height = 200;//错误！！！结构体中的字段不能被初始化
        public bool IsSquare() {
            return width == height;
        }
    }//Rectangle
    class Program
    {
        static void Main(string[] args) {
            Rectangle rectangle;//结构体实例化时，可以不使用new  Rectangle()，但是必须对变量赋值 rectangle.width = 100;否则会报错。
            rectangle.width = 100;
            rectangle.height = 100;
            bool isSquare = rectangle.IsSquare();
            Console.WriteLine("宽为{0}、高为{1}的矩形是不是正方形？{2}", rectangle.width, rectangle.height, isSquare);
            Console.ReadKey();
        }
        /*        宽为100、高为100的矩形是不是正方形？True*/
    }

/*
    //方法二：用结构去写，使用封装
    struct Rectangle
    {
        private int width;
        private int height;

        //封装字段
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Rectangle(int width, int height) {
            this.width = width;
            this.height = height;
        }
        public bool IsSquare() {
            return Width == Height;
        }
        public override string ToString() {
            return string.Format("宽为{0}、高为{1}的矩形是不是正方形？{2}", Width, Height, IsSquare().ToString());
        }
    }//Rectangle
    class Program
    {
        static void Main(string[] args) {
            Rectangle rectangle = new Rectangle(100, 200);
            Console.WriteLine(rectangle);
            Console.ReadKey();
        }
        *//*        宽为100、高为100的矩形是不是正方形？False*//*
    }
*/


    //方法二：用类去写
    /*
        class Rectangle
        {
            private int width;
            private int height;
            public int Width { get => width; set => width = value; }
            public int Height { get => height; set => height = value; }
            public Rectangle() { }
            public Rectangle(int width, int height) {
                this.width = width;
                this.height = height;
            }
            public bool isSquare() {
                return Width == Height;
            }
            public override string ToString() {
                return "是不是正方形：" + isSquare();
            }
        }//Rectangle
        class Program
        {
            static void Main(string[] args) {
                Rectangle rectangle = new Rectangle(20, 20);
                Console.Write("宽为20、高为20的矩形");
                Console.WriteLine(rectangle);
                Console.ReadKey();
            }
        }
    */
}
/*宽为20、高为20的矩形是不是正方形：True*/
