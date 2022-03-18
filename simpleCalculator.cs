using System;
using System.Globalization;

namespace Maths
{

    class Multiply
    {

        public static int Main()
        {
            while (true)
            {
                Console.WriteLine("Choose your operation: 1 - addition, 2 - subtraction, 3 - multiply, 4 - division");
                int operationCode = Convert.ToInt32(Console.ReadLine());
                switch (operationCode)
                {
                    case 1:
                        Console.WriteLine($"Your choice is {operationCode}.");
                        Worker(operationCode);                       
                        return 0;
                    case 2:
                        Console.WriteLine($"Your choice is {operationCode}.");
                        Worker(operationCode);
                        return 0;
                    case 3:
                        Console.WriteLine($"Your choice is {operationCode}.");
                        Worker(operationCode);
                        return 0;
                    case 4:
                        Console.WriteLine($"Your choice is {operationCode}.");
                        Worker(operationCode);
                        return 0;
                    default:
                        Console.WriteLine($"Error: {operationCode} is not an operation number!");
                        continue;
                }
            }
        }

        public static void Worker(int operationCode)
        {
            if (operationCode == 1) 
            {
                Console.WriteLine($"Input 2 numbers for operation {operationCode}:");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your operation:{x} + {y} = {x + y}");
                Console.WriteLine("Do you need one more operation? 1 - (yes) 2 - (no)");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Multiply.Main();
                } 
            } else if (operationCode == 2)
            {
                Console.WriteLine($"Input 2 numbers for operation {operationCode}:");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your operation:{x} - {y} = {x - y}");
                Console.WriteLine("Do you need one more operation? 1 - (yes) 2 - (no)");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Multiply.Main();
                }
            }
            else if (operationCode == 3)
            {
                Console.WriteLine($"Input 2 numbers for operation {operationCode}:");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your operation:{x} * {y} = {x * y}");
                Console.WriteLine("Do you need one more operation? 1 - (yes) 2 - (no)");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Multiply.Main();
                }
            } else
            {
                Console.WriteLine($"Input 2 numbers for operation {operationCode}:");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your operation:{x} / {y} = {x / y}");
                Console.WriteLine("Do you need one more operation? 1 - (yes) 2 - (no)");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Multiply.Main();
                }
            }
            Console.WriteLine("BYE!!!");
        }
    }
}
