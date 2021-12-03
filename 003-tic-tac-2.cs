using System;

namespace TicTacToe2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Variable Declaration...
			char v1, v2, v3, v4, v5, v6, v7, v8, v9;

			// Game Constants...
			char GAMECHAR1 = 'X';
			char GAMECHAR2 = 'O';

			// User Input Variable Declaration...
			int userInput1;
			int userInput2;

			// Flag to control Game's Flow...
			bool flag = false;

			v1 = v2 = v3 = v4 = v5 = v6 = v7 = v8 = v9 = ' ';

			// Welcome Message...
			Console.WriteLine("\nWelcome to TIC-TAC-TOE!!\n");
			
			// Game's Main Loop...
			do
			{
				// Checking if All Fields are full...
				if (	(v1 == 'X' || v1 == 'O' ) &&
						(v2 == 'X' || v2 == 'O' ) && 
						(v3 == 'X' || v3 == 'O' ) && 
						(v4 == 'X' || v4 == 'O' ) && 
						(v5 == 'X' || v5 == 'O' ) && 
						(v6 == 'X' || v6 == 'O' ) && 
						(v7 == 'X' || v7 == 'O' ) && 
						(v8 == 'X' || v8 == 'O' ) && 
						(v9 == 'X' || v9 == 'O' ) 
					)
				{
					flag = true;
					Console.WriteLine("Game Over!");
				}
				// Getting Input from the User...
				Console.WriteLine("X\'s Move > ");
				userInput1 = Convert.ToInt32(Console.ReadLine());
				

				// Validating Inputs...
				if (userInput1 == 1)
				{
					v1 = GAMECHAR1;
				}
				else if (v2 == ' ' && userInput1 == 2)
				{
					v2 = GAMECHAR1;
				}
				else if (v3 == ' ' && userInput1 == 3)
				{
					v3 = GAMECHAR1;
				}
				else if (v4 == ' ' && userInput1 == 4)
				{
					v4 = GAMECHAR1;
				}
				else if (v5 == ' ' && userInput1 == 5)
				{
					v5 = GAMECHAR1;
				}
				else if (v6 == ' ' && userInput1 == 6)
				{
					v6 = GAMECHAR1;
				}
				else if (v7 == ' ' && userInput1 == 7)
				{
					v7 = GAMECHAR1;
				}
				else if (v8 == ' ' && userInput1 == 8)
				{
					v8 = GAMECHAR1;
				}
				else if (v9 == ' ' && userInput1 == 9)
				{
					v9 = GAMECHAR1;
				}
				else
				{
					Console.WriteLine("Invalid Move!");
					break;
				}

				// Drawing the Board...
				Console.WriteLine("\n     " + v1 + " | " + v2 + " | " + v3 + "\n    ---+---+--- " +
								  "\n     " + v4 + " | " + v5 + " | " + v6 + "\n    ---+---+--- " +
								  "\n     " + v7 + " | " + v8 + " | " + v9 + "\n\n"
					  			 );

				Console.WriteLine("\nO\'s Move > ");
				userInput2 = Convert.ToInt32(Console.ReadLine());

				// Validating Inputs...
				if (v1 == ' ' && userInput2 == 1)
				{
					v1 = GAMECHAR2;
				}
				else if (v2 == ' ' && userInput2 == 2)
				{
					v2 = GAMECHAR2;
				}
				else if (v3 == ' ' && userInput2 == 3)
				{
					v3 = GAMECHAR2;
				}
				else if (v4 == ' ' && userInput2 == 4)
				{
					v4 = GAMECHAR2;
				}
				else if (v5 == ' ' && userInput2 == 5)
				{
					v5 = GAMECHAR2;
				}
				else if (v6 == ' ' && userInput2 == 6)
				{
					v6 = GAMECHAR2;
				}
				else if (v7 == ' ' && userInput2 == 7)
				{
					v7 = GAMECHAR2;
				}
				else if (v8 == ' ' && userInput2 == 8)
				{
					v8 = GAMECHAR2;
				}
				else if (v9 == ' ' && userInput2 == 9)
				{
					v9 = GAMECHAR2;
				}
				else
				{
					Console.WriteLine("Invalid Move!");
					break;
				}
				
				Console.WriteLine("\n     " + v1 + " | " + v2 + " | " + v3 + "\n    ---+---+--- " +
								  "\n     " + v4 + " | " + v5 + " | " + v6 + "\n    ---+---+--- " +
								  "\n     " + v7 + " | " + v8 + " | " + v9 + "\n\n"
					  			 );
			}
			while(!flag);
		}
	}
}
