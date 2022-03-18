using System;
using System.Globalization;

Main(args);

        static void Main(string[] args)
        {
            decimal percent = 0.07M;
            Console.WriteLine("Введите сумму вклада: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев: ");
            int month = Convert.ToInt32(Console.ReadLine());
            while(month > 0)
            {
              sum += sum * percent;
              month--;
            }
                Console.WriteLine($"Ваша итоговая сумма: {sum}");
        }
