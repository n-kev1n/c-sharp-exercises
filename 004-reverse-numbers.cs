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
			for (int i = 0; i < Numbers.Length; i++)
			{
				Console.Write($"{i + 1}> ");
				// Numbers[i] = Convert.ToInt32(Console.ReadLine());
				while(!int.TryParse(Console.ReadLine(), out Numbers[i]));
			}
			
			Console.WriteLine("Reversed Numbers");
			Array.Reverse(Numbers);
			Console.WriteLine($"{String.Join(',', Numbers)}");
		}
	}
}
