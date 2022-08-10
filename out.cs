

Temp temp = new Temp();
Second sec = new Second();
sec.SayNo(temp);

class Temp
{
    public void SayHi (out int a, out int b)
    {
        a = 0;
        b = 0;
    }
}

class Second
{
    public void SayNo (Temp temp)
    {
        int a = 2;
        int b = 2;
        temp.SayHi(out a, out b);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
