using System;

public class Kata
{
  public static int Triangular(int n)
  {
    int sum = 0;
    for (int i = n; i > 0; i--) sum += n--; 
    return sum;
  }
}
