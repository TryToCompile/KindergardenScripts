using System;
using static System.Console;


var count = new Maths();
double n = Convert.ToDouble(ReadLine());
WriteLine(count.Factorial(n));

class Maths
{
    public double Factorial(double n)
    {
        if (n < 0) return 0;
        if (n == 0) return n + 1;
        if (n == 1) return 1;
        return n * Factorial(n - 1);
    }
}