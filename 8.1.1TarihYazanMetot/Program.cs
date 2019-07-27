using System;

namespace _8._1._1TarihYazanMetot
{
    class Program
    {
        // 8.1.1
        static void PrintDateTime() 
        {
            Console.WriteLine(DateTime.Now);
        }

        // 8.1.2
        static void PrintStar()
        {
            Console.WriteLine("*");
        }

        // 8.1.3
        static void PrintStar(int starCount)
        {
            for (int i = 0; i < starCount; i++)
            {
                Console.Write("*");
            }
        }

        // 8.1.4
        static void NewLine()
        {
            Console.WriteLine();
        }

        // 8.1.5
        static void NewLine(int lineCount)
        {
            for (int i = 0; i < lineCount; i++)
            {
                Console.WriteLine();
            }
        }

        // 8.1.6
        static void PrintArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
            PrintDateTime(); 
            PrintStar();
            PrintStar(5);
            NewLine();
            NewLine(4);
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintArray(numbers);
            Console.ReadLine();
        }
    }
}
