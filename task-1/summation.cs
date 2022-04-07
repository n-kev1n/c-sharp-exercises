using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int sum = 0;
      for(int i = 1; i <= num; i++)
        sum = sum + i;
      return sum;
    }
}
