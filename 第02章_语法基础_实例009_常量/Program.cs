/*
【时      间】：2020年3月12日10:26:32
【题      目】：计算圆的面积。
【知 识  点】：常量的使用
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第02章_语法基础_实例009_常量
{
    class Circle
    {
        private const float PI = 3.14f;
       private readonly float radius = 2.0f;
        public Circle(float radius) {
            this.radius = radius;
        }

        //public float Radius => radius;//新的属性语法格式
        /*    
         *    = 是给一个值叫赋值，=>是给一个表达达支持用来定义一个方法，属性。
         *    ToDo() => 这就是定义了一个方法了，=>后面的表达式就是方法体的内容了
         */
        public float Radius { get { return radius; } } 
        public float GetCircleArea() {
            return PI * Radius * Radius;
        }
    }
    class Program
    {
        static void Main(string[] args) {
            Circle circle = new Circle(10.0f);
            
            Console.WriteLine("圆的面积="+circle .GetCircleArea());
            Console.ReadKey();
        }
    }
}
//圆的面积=314