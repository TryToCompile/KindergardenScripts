using System;
using System.Globalization;



void Method(ref int refs) // Передаем по ссылке, а не по значению, т.е. сразу ссылаемся на 
{                        // number, который лежит ниже и подписан как "значение" -> int number = 1; // Значение
    refs++;             // т.е. теперь мы будем менять не внутреннее значение, ограниченное областью видимости метода,
    Console.WriteLine(refs); // а уже сразу тот самый number
}
// Если убрать ref, то значение в глобальной области видимости не изменится -> number будет 1, а рефс будет уже 2
// Если же делать с ref, то значение number будет равно 2 
int number = 1; // Значение

Method(ref number);
Console.WriteLine(number);



Person p = new (){ name = "Tom", age = 23 };
ChangePerson(ref p);

Console.WriteLine(p.name); // Bill
Console.WriteLine(p.age); // 45

void ChangePerson(ref Person person)
{
// сработает
person.name = "Alice";
// сработает
person = new Person { name = "Bill", age = 45 };
}

class Person
{
    public string name = "";
    public int age;
}
