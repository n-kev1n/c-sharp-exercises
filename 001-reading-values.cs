using System;

namespace ReadingValues
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 50;
			/* int y = 0; */
			Console.Write("Enter A Number: ");
			int a = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine(x / a);
		}
	}
}
