using System;
using System.Globalization;



 namespace Maths
{
    
    class Multiply
    {
            
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите 2 числа: ");
                int first = Convert.ToInt16(Console.ReadLine());
                int second = Convert.ToInt16(Console.ReadLine());
                if ((first | second) < 0 || (first | second) > 10)
                {
                    Console.WriteLine("Let's try more!!! ( int from 0 to 10 )");
                } else
                {
                    Console.WriteLine("YEEEAH!");
                    break;
                }
            }
        }
    }
}
