using System;
using System.Globalization;

namespace Maths
{

    class Calculator
    {

        public static int Main()
        {
            while (true)
            {
                Console.WriteLine("Choose your operation: 1 - addition, 2 - subtraction, 3 - multiply, 4 - division, 5 - remainder div");
                int operationCode = Convert.ToInt32(Console.ReadLine());
                Calculate(operationCode);
            }
        }

        
        
        public static int Addition(int x,int y) => x + y;
        public static int Subtraction(int x, int y) => x - y;

        public static int Multiply(int x, int y) => x * y;

        public static int Division(int x, int y) => x / y; 

        public static int Remainder(int x, int y) => x % y;
        
        public static void Message(int operationCode, string operation, int x, int y, int result)
        {
            Console.WriteLine($"{x} {operation} {y} = {result}");
            Console.WriteLine("Do you need one more operation? 1 - (yes) 2 - (no)");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Calculator.Main();
            }
        }
        public static void Calculate(int operationCode)
        {
            Console.WriteLine($"Input 2 numbers for operation {operationCode}:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int result;
            if (operationCode == 1)
            {
                result = Addition(x,y);
                Message(operationCode, "+", x, y, result);
            }
            else if (operationCode == 2)
            {   
                result=Subtraction(x,y);
                Message(operationCode, "-", x, y, result);    
            }
            else if (operationCode == 3)
            {   
                result=Multiply(x,y);
                Message(operationCode, "*", x, y, result);              
            }
            else if (operationCode == 4)
            {   
                result = Division(x,y);
                Message(operationCode, "/", x, y, result);            
            }
            else if (operationCode == 5)
            {
                result = Remainder(x,y);
                Message(operationCode, "%", x, y, result);             
            } else
            {
                Console.WriteLine("Error! Try Again");
                Calculator.Main();
            }
            Console.WriteLine("BYE!!!");
        }
    }
}
