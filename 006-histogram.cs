using System;

namespace Program
{
	class Histogram
	{
		static void Main(string[] args)
		{
			int choice;
			Console.WriteLine("How Many Numbers would you like to Enter: ");
			while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5);

			// Array of Numbers...
			int[] Numbers = new int[choice];
			int[] data = new int[5];

			Console.WriteLine(Numbers[0]);	
			// Loop for Entering the Number...
			for (int i = 0; i < Numbers.Length; i++)
			{
				Console.Write($"{i + 1}> ");
				while(!int.TryParse(Console.ReadLine(), out Numbers[i]));
			}	
			// Loop to Print *
			for (int k = 0; k < Numbers.Length; k++)
			{
				Console.WriteLine($"{Numbers[k] + 1} {new string("*", String.Join(" ", Numbers))}");
			}
		}
	}
}
