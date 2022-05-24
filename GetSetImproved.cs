using System;
using System.Globalization;


Person Ted = new();
Console.WriteLine(Ted.Year);
Ted.age = 10;
Ted.bornYear = 15;
Console.WriteLine(Ted.Year);


class Person
{
    public int age = 0;
    public int bornYear = 0;
    public int Year 
    {
        get
        {
            return CountYearNow(age,bornYear);
        }
         
    }
    public string Name { get; set; }

    int CountYearNow(int age, int bornYear)
    {
        Console.WriteLine($"wrtln\n{bornYear - age}");
        return 1;
    }

}
