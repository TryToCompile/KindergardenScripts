using System;
using System.Globalization;


Construct First = new(); // Here will be counter++ from static construct
First.view(); // Here will be public construct with WriteLine
Construct Second = new(); // Here will be counter++ from static construct
Second.view(); // Here will be public construct with WriteLine
Construct Third= new();
Third.view();
Construct Fourth = new();
Fourth.view();
Construct Fifth = new();
Fifth.view();


class Construct
{
    static int counter = -1;
    static Construct()  // This will appear only in first inito of object
    // For real, this will not just (appear in first init) -
    // memory will be allocated even without init 
    // static classes,methods are classes,methods, that will be in any case 
    // and they will be, like, u cant change them, this is smth like roots of the tree, when u make them
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
