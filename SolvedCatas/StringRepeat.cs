using System;
using System.Globalization;
using Codewars; // hm


Kata kata = new();

Console.WriteLine(kata.RepeatStr(2,"*"));

namespace Codewars
{
    class Kata
    {
        public string RepeatStr(int n, string s)
        {
            string sum = "";
            for (; n > 0; n--)
            {
                sum += s;
            }
            return sum;
        }
    }
}
