using System;

namespace Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var answer1 = Add(5, 6);
            var answer2 = Add(7,9);
            var answer3 = Add(10, 10, true);

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool c)
        {
            if (c == true && (a + b) == 1)
            {
                return $"{a + b} dollar";
            }
            else if(c == true)
            {
                return $"{a + b} dollars";
            }
            else
            {
                return $"{a + b}";
            }
            
        }
    }
}
