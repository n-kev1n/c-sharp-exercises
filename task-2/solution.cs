using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15};
        int[] solution = CountPositivesSumNegatives(arr);
        Console.WriteLine($"{solution[0]} {solution[1]}");
    }

    public static int[] CountPositivesSumNegatives(int[] input)
    {
        /* int[] arr = {0,0}; */
        if(input == null || !input.Any())  return new int[] {};
        int countPositives = input.Count(n => n > 0);
        int sumNegatives = input.Where(n => n < 0).Sum();

        return new int[] { countPositives, sumNegatives };
        /* for(int i = 0; i < input.Length; i++) */
        /* { */
        /*    if(input[i] > 0){ */
        /*      arr[0] = arr[0] + 1; */
        /*     } */
        /*    else if(input[i] < 0){ */
        /*      arr[1] = arr[1] + input[i]; */
        /*     } */
        /* } */
        /* return arr; */
    }
}
