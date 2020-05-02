/*
【时      间】：2020年3月12日18:11:12
【题      目】：管理学生信息。
【知 识  点】：List的使用
【操作步骤】：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第04章_数组与集合_实例037_List的使用
{
    struct Student
    {
        public string name;
        public byte age;
        public string sex;
        public int id;
        public Student(string name, byte age, string sex, int id) {
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
            List<Student> stu = new List<Student>();
            stu.Add(new Student("张三", 22, "男", 1011011018));
            stu.Add(new Student("李四", 33, "女", 1011011019));
            stu.Add(new Student("王二", 15, "男", 1011011020));
            stu.Add(new Student("张五", 15, "女", 1011011021));
            stu.Add(new Student("赵柳", 15, "男", 1011011022));
            //foreach (Student s in stu)
            //{
            //    Console.WriteLine(s);
            //}
            stu.Remove(stu[2]);

            foreach (Student s in stu)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }//Main
    }// Program
}
