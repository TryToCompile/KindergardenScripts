using System;
using System.Globalization;


Console.WriteLine(FindNextSquare(144));


 long FindNextSquare(long num)
{
    double result = Math.Sqrt(num);
    Console.WriteLine(result);
    bool isSquare = result % 1 == 0; //  result - n * result, where n -> largest possible integer that is less than or equal to |x| / |y|
    Console.WriteLine(isSquare);
    if (isSquare == true)
    {
        result++;
        result *= result;
        long l = Convert.ToInt64(result);
        return l;
    }
    else
    {
        return -1;
    }
}
