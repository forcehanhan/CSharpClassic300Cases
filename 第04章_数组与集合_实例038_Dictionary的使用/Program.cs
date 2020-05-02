/*
【时      间】：2020年3月12日18:26:20
【题      目】：生成省市信息表。
【知 识  点】：Dictionary的使用。
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第04章_数组与集合_实例038_Dictionary的使用
{
    class Program
    {
        static void Main(string[] args) {
            //创建字典
            Dictionary<string, List<string>> provinces = new Dictionary<string, List<string>>();

            //增加
            List<string> hebei = new List<string>();
            provinces.Add("河北", hebei);
            hebei.Add("石家庄");
            hebei.Add("唐山");

            List<string> nanjing = new List<string>();
            provinces.Add("江苏", nanjing);
            nanjing.Add("南京");
            nanjing.Add("苏州");

            List<string> anhui = new List<string>();
            provinces.Add("安徽", anhui);
            anhui.Add("合肥");
            anhui.Add("芜湖");

            List<string> henan = new List<string>();
            provinces.Add("河南", henan);
            henan.Add("郑州");
            henan.Add("洛阳");

            List<string> hainan = new List<string>();
            provinces.Add("海南", hainan);
            hainan.Add("海口");
            hainan.Add("三亚");

            List<string> guangdong = new List<string>();
            provinces.Add("广东", guangdong);
            guangdong.Add("广州");
            guangdong.Add("深圳");

            List<string> shanxi = new List<string>();
            provinces.Add("山西", shanxi);
            shanxi.Add("太原");
            shanxi.Add("大同");

            //遍历
            foreach (KeyValuePair<string, List<string>> province in provinces)
            {
                Console.WriteLine("○{0}省", province.Key);
                Console.WriteLine("------------------");
                foreach (string provinceValue in province.Value)
                {
                    Console.WriteLine("\t|{0}市 ", provinceValue);
                }
            }

            //查询
                Console.Write("请输入你要查询的省,如河北:");
                string str = Console.ReadLine();
                if (provinces.ContainsKey(str))
                {
                    foreach (var city in provinces[str])
                    {
                        Console.WriteLine("\t{0}市", city);
                    }
                }
                else
                {
                    Console.WriteLine("请输入省。");
                }
            Console.ReadKey();
        }//Main
    }//Program
}
