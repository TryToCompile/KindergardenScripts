using System;
using System.Globalization;



 namespace Table
{
    
    class NotDivision
    {
            
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\t");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i*j} \t");
                }
            }
        }
    }
}
