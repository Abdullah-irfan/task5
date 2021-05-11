using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {   
            con c = new con();
            c.student1(60, 80);
            c.student2();
            Console.WriteLine("Welcome");
            stat.FN();
            ls.emp();

        }
    }
    class con
    {
        public void student1(int mark1, int mark2)//Constructor with  Parameter
        {

            int sum = mark1 + mark2;
            Console.WriteLine("student1:{0}", sum);
        }
        //here out side the method created one integer value. so here use "this" keyword to cal he value inside the function
        int mark1 = 50;
        public void student2()//Constructor without  Parameter
        {
            int sum = this.mark1 + 50;
            Console.WriteLine("student2:{0}", sum);

        }


    }
    class stat
    {
        public static void FN()
        {
            string FName = "irfan";
            string LName = "abdullah";
            Console.WriteLine(LName + FName);



        }
    }


    class ls 
    {
        public static void emp()
        {
            List<prop> details = new List<prop>();
            details.Add(new prop { Name = "Abdullah", age = 22, qulalification = "MCA" });
            details.Add(new prop { Name = "appun", age = 26, qulalification = "IT" });
            details.Add(new prop { Name = "irfan", age = 23, qulalification = "CS" });

            foreach (prop data in details)
            {
                Console.WriteLine(data.Name + "---" + data.age + "---" + data.qulalification);
            }


        }
    }
}







