using System;
namespace New_homework
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public int passyear { get; set; }
        DateTime dt1 = DateTime.Now;
        public int n = 3;



        public void Subject()
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("you chose math");
                    break;
                case 1:
                    Console.WriteLine("you chose chemkstry");
                    break;
                case 2:
                    Console.WriteLine("you chose english");
                    break;
                case 3:
                    Console.WriteLine("you chose another subject");
                    break;

            }

        }
        public void Yearstofinish()
        {
            int result = dt1.Year - passyear;


            if ((result) < 4)
            {
                Console.WriteLine($"years to finish is {4-result} years");
            }
            else { Console.WriteLine("already graduated"); }

        }
    }
}

