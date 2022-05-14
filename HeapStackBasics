using System;
using System.Globalization;


Struct struct1 = new Struct();
Struct struct2 = new Struct();

struct2.country = new Country();
struct2.country.x = 5;
struct1 = struct2;      // ссылки будут и тут и там
struct2.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
                      // указывают на один объект в хипе
Console.WriteLine(struct1.country.x); // 8
Console.WriteLine(struct2.country.x); // 8

struct Struct
{
    public int x;
    public int y;
    public Country country; 
    public Struct()
    {
        x = 0;
        y = 0;
        country = new Country(); // выделение памяти для объекта Country
    }
}
class Country
{
    public int x;
    public int y;
}
