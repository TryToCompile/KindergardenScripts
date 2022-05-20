using System;

public static class Kata
{
  public static int Factorial(int n)
  {
     if (n < 0) throw new Exception();
     if (n == 1) return n;
     if (n == 0) return 1;
     return n*Factorial(--n);
  }
}
