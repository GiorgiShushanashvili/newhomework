using System;
namespace New_homework
{
    public class Teacher
    {
        public string Name;
        public bool certified;
        public int m = 3;





        public void Result()
        {
            switch (m)

            {
                case 0:
                    Console.WriteLine("5+5=10");
                    break;
                case 1:
                    Console.WriteLine("h2+O = h2O");
                    break;
                case 2:
                    Console.WriteLine("my fovourite subject is english");
                    break;
                case 3:
                    Console.WriteLine("you chose another subject, teacher isnt competent");
                    break;
            }
        }
    }
}

