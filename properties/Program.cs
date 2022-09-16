using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////property initializer syntax
            //Student s1=new Student();
            //s1.Rollno = 12;
            //s1.Name = "rahul";
            //s1.Percentage = 91;

            //Console.WriteLine($"{s1.Rollno} {s1.Name} {s1.Percentage}");

            ////object initializer syntax
            //Student s2 = new Student { Rollno = 13, Name = "mahesh", Percentage = 96 };
            //Console.WriteLine($"roll no ={s2.Rollno} name={s2.Name} percentage={s2.Percentage}");

            //Console.WriteLine(s1);

            //Employee emp1 = new Employee("omkar",20000,230);
            //emp1.calculatesal();
            //Console.WriteLine(emp1.displaysalary());


            //Employee emp2 = new Employee("mahesh", 20500, 232);
            //emp2.calculatesal();
            //Console.WriteLine(emp2.displaysalary());


            //Employee emp3 = new Employee("rohit", 21000, 250);
            //emp3.calculatesal();
            //Console.WriteLine(emp3.displaysalary());

            //Student s3 = new Student { Rollno=14,Name="sunny",percentege=44.20,Grade='D'};
            //Console.WriteLine(s3.ToString());


            //Student s4 = new Student { Rollno = 15, Name = "abhishek", percentege = 54.20, Grade = 'D' };
            //Console.WriteLine(s4.ToString());

            calulation c1=new calulation();
            
            Console.WriteLine(c1.addition(20, 30));

            calulation c2 = new calulation();

            Console.WriteLine(c2.addition(20.5, 30));

            calulation c3 = new calulation();

            Console.WriteLine(c3.addition(21.2, 30.5));








        }
    }
}
