/*
【时      间】：2020年3月12日00:29:26
【题      目】：从控制台输出整数类型。
【知 识  点】：整型
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第02章_语法基础_实例004_整型类型
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte Sbyte = 100;                                    //有符号字节类型
            byte Byte = 200;                                       //无符号字节类型
            char Char = '\u0061';                                  //字符型
            short Short = 30000;                                  //有符号短整型
            int Int = 2000000000;                                 //有符号整型
            uint Uint = 4000000000;                             //无符号整型
            long Long = 9000000000000000000;             //有符号长整型
            ulong Ulong = 18000000000000000000;     //无符号长整型
            Console.WriteLine("---------------整型类型-------------");
            Console.WriteLine("有符号字节类型\tsbyte\t{0}", Sbyte);
            Console.WriteLine("无符号字节类型\tbyte\t{0}", Byte);
            Console.WriteLine("字符型类型\tchar\t{0}", Char);
            Console.WriteLine("有符号短整型\tshort\t{0}", Short);
            Console.WriteLine("有符号整型\tint\t{0}", Int);
            Console.WriteLine("无符号整型\tuint\t{0}", Uint);
            Console.WriteLine("有符号长整型\tlong\t{0}", Long);
            Console.WriteLine("无符号长整型\tulong\t{0}", Ulong);
            
            Console.ReadKey();
        }
    }
}
/*
---------------整型类型-------------
有符号字节类型 sbyte   100
无符号字节类型 byte    200
字符型类型    char           a
有符号短整型 short   30000
有符号整型       int     2000000000
无符号整型 uint    4000000000
有符号长整型 long    9000000000000000000
无符号长整型 ulong   18000000000000000000
*/