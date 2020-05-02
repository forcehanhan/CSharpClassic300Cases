/*
【时      间】：
【题      目】：生成学生信息表。
【知 识  点】：
【操作步骤】：
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第04章_数组与集合_实例036_ArrayList的使用
{
    struct Student
    {
        public string name;
        public byte age;
        public string sex;
        public int id;
        public Student(string name,byte age,string sex,int id) {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.id = id;
        }
        public override string ToString() {
            return "姓名：" + name + "，" + "年龄：" + age + "，" + "性别：" + sex + "，" + "学号：" + id;
        }
    }
    class Program
    {
        static void Main(string[] args) {
            ArrayList stuList = new ArrayList();
            stuList.Add(new Student("张三", 22, "男", 1011011018));
            stuList.Add(new Student("李四", 33, "女", 1011011019));
            stuList.Add(new Student("王二", 15, "男", 1011011020));
            foreach (var item in stuList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
/*
姓名：张三，年龄：22，性别：男，学号：1011011018
姓名：李四，年龄：33，性别：女，学号：1011011019
姓名：王二，年龄：15，性别：男，学号：1011011020
*/