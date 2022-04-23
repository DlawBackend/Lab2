using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            String inputNum1 = Console.ReadLine();
            int Num1 = Convert.ToInt32(inputNum1);

            Console.Write("Enter another number: ");
            String inputNum2 = Console.ReadLine();
            int Num2 = Convert.ToInt32(inputNum2);

            int sumNumber = Num1 + Num2;
            

            if (sumNumber < 100) {
                Console.WriteLine("true");   
            } else {
                Console.WriteLine("false");
            }

            Console.ReadLine();
        }
    }
}
