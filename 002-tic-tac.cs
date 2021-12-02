using System;

namespace TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			char c1, c2, c3, c4, c5, c6, c7, c8, c9;
			char c = 'X';
			/* c1 = c2 = c3 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = ' '; */

			// Welcome Message
			Console.WriteLine("\nWelcome to TIC-TAC-TOE!!\n");
			Console.Write("Enter Value for Field 1: ");
			c1 = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Value for Field 2: ");
			c2 = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Value for Field 3: ");
			c3 = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Value for Field 4: ");
			c4 = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Value for Field 5: ");
			c5 =  Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Value for Field 6: ");
			c6 = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Value for Field 7: ");
			c7 = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Value for Field 8: ");
			c8 = Convert.ToChar(Console.ReadLine());
			Console.Write("Enter Value for Field 9: ");
			c9 = Convert.ToChar(Console.ReadLine());


			Console.WriteLine("\n     " + c1 + " | " + c2 + " | " + c3 + "\n    ---+---+--- " + 
							  "\n     " + c4 + " | " + c5 + " | " + c6 + "\n    ---+---+--- " +
							  "\n     " + c7 + " | " + c8 + " | " + c9 + "\n\n"
						);

		}
	}
}
