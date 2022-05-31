using System;
using System.Globalization;


Construct First = new();
First.view();
Construct Second = new();
Second.view();
Construct Third= new();
Third.view();
Construct Fourth = new();
Fourth.view();
Construct Fifth = new();
Fifth.view();


class Construct
{
    static int counter = -1;
    static Construct()  // This will appear only in first init.
    {
        counter++;
    }

    public Construct()
    {
        Console.WriteLine("i'm here!");
    }

    public void view()
    {
        counter++;
        Console.WriteLine(counter);
    }
}
