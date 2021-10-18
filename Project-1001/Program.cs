using System;

namespace Project_1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two number");
            double a = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.Addition\n"+
                            "2.Subtraction\n"+
                            "3.Multiplication\n"+
                            "4.Division");
            int test = Convert.ToInt32(Console.ReadLine());
            if (test == 1)
                Console.WriteLine(a + b);

            if (test == 2)
            { Console.WriteLine(a - b); 
            }
                
            if (test == 3)
                {
                Console.WriteLine(a * b); 
                }

            if (test == 4)
            {
                Console.WriteLine(a / b);
            }
            Console.ReadLine();
        }
    }
}
