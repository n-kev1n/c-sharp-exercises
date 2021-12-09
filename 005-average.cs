using System;

namespace Program
{
	class AverageCalculator
	{
		static void Main(string[] args)
		{
			int nbr;
			int sum = 0;
			float average;

			Console.WriteLine("How Many Numbers would you like to Calculate? ");
			while(!int.TryParse(Console.ReadLine(), out nbr));
			
			// Creating an Array of Numbers...
			int[] Numbers = new int[nbr];
			
			// Loop for entering the numbers...
			for (int i = 0; i < nbr; i++)
			{
				Console.Write($"{i + 1}> ");
				while(!int.TryParse(Console.ReadLine(), out Numbers[i]));
				sum = sum + Numbers[i];
				Console.WriteLine(sum);
			}
			average = (float)sum / Numbers.Length;
						
			Console.Write("The Average of ");
			// Loop for Answer...
			for (int j = 0; j < nbr; j++)
			{
				Console.Write($"{Numbers[j]} ");
			}
			Console.Write($"is {average}");
		}
	}
}
