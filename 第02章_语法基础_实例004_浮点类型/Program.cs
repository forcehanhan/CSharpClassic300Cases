/*
【时      间】：2020年3月12日00:47:43
【题      目】：从控制台输出整数类型。
【知 识  点】：
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第02章_语法基础_实例004_浮点类型
{
    class Program
    {
        static void Main(string[] args)
        {
            float Float = 123.456789f;//单精度
            double Double = 123.456789123456789d;//双精度
            decimal Decimal = 123.456789123456789123456789m;//高精度
            Console.WriteLine("单精度浮点型\tfloat\t{0}", Float);
            Console.WriteLine("双精度浮点型\tdouble\t{0}", Double);
            Console.WriteLine("高精度浮点型\tdecimal\t{0}", Decimal);
            Console.ReadKey();
        }
    }
}
/*
单精度浮点型 float   123.4568
双精度浮点型 double  123.456789123457
高精度浮点型 decimal 123.456789123456789123456789
*/