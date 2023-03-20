using System;

namespace New_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine("please enter student's name: ");
            student1.name = Console.ReadLine();
            Console.WriteLine("enter your age: ");
            student1.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("check if student has years left to study");
            Console.WriteLine("enter the year when you entered the university: ");
            student1.passyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("now check years left:");
            student1.Yearstofinish();
            Console.WriteLine("now choose the subject, 0 means math, 1 - chemistry, 2 - english,3 - anything else ");
            student1.n = Convert.ToInt32(Console.ReadLine());
            student1.Subject();

            Teacher teacher1 = new Teacher();
            Console.WriteLine("enter the name: ");
            teacher1.Name = Console.ReadLine();


            Console.WriteLine("now choose the subject, 0 means math, 1 - chemistry, 2 - english,3 - anything else ");
            teacher1.m = Convert.ToInt32(Console.ReadLine());
            teacher1.Result();
        }
    }
}

