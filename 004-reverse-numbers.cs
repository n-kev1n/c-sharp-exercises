using System;

namespace Program
{
	class ReverseNumbers
	{
		static void Main(string[] args)
		{
			int[] Numbers = new int[20];
			Console.Clear();
			Console.WriteLine("\nEnter 20 Numbers:\n");
			
			// Loop to Get Numbers...
			for (int i = 0; i <= 19; i++)
			{
				Console.Write("> ");
				Numbers[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.WriteLine("Reversed Numbers");

			// Loop to Print Numbers...
			for (int j = 19; j >= 0; j--)
			{
				Console.Write($"{Numbers[j]} ");
			}
		}
	}
}
