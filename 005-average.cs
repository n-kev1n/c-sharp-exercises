using System;

namespace Program
{
	class AverageCalculator
	{
		static void Main(string[] args)
		{
			int nbr, sum = 0;	
			Console.WriteLine("How Many Numbers would you like to Calculate? ");
			while(!int.TryParse(Console.ReadLine(), out nbr) || nbr < 1);
			// Creating an Array of Numbers...
			int[] Numbers = new int[nbr];
			// Loop for entering the numbers...
			for (int i = 0; i < nbr; i++)
			{
				Console.Write($"{i + 1}> ");
				while(!int.TryParse(Console.ReadLine(), out Numbers[i]));
				sum = sum + Numbers[i];
			}
			// Calculating Average...
			float average = (float)sum / Numbers.Length;
			// Answer...
			Console.Write($"The Average of {String.Join(' ', Numbers)} is {average}");
		}
	}
}
