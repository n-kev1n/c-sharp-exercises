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
				// Getting Input from the User...
				Console.WriteLine("X\'s Move > ");
				userInput1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("\nO\'s Move > ");
				userInput2 = Convert.ToInt32(Console.ReadLine());
				
				// Validating Inputs...
				switch (userInput1)
				{
					case 1:
						v1 = GAMECHAR1;break;
					case 2:
						v2 = GAMECHAR1;break;
					case 3:
						v3 = GAMECHAR1;break;
					case 4:
						v4 = GAMECHAR1;break;
					case 5:
						v5 = GAMECHAR1;break;
					case 6:
						v6 = GAMECHAR1;break;
					case 7:
						v7 = GAMECHAR1;break;
					case 8:
						v8 = GAMECHAR1;break;
					case 9:
						v9 = GAMECHAR1;break;
					default:
						Console.WriteLine("Invalid Move");break;
				}

				switch (userInput2)
				{
					case 1:
						v1 = GAMECHAR2;break;
					case 2:
						v2 = GAMECHAR2;break;
					case 3:
						v3 = GAMECHAR2;break;
					case 4:
						v4 = GAMECHAR2;break;
					case 5:
						v5 = GAMECHAR2;break;
					case 6:
						v6 = GAMECHAR2;break;
					case 7:
						v7 = GAMECHAR2;break;
					case 8:
						v8 = GAMECHAR2;break;
					case 9:
						v9 = GAMECHAR2;break;
					default:
						Console.WriteLine("Invalid Move");break;
				}


				// Drawing the Board...
				Console.WriteLine("\n     " + v1 + " | " + v2 + " | " + v3 + "\n    ---+---+--- " +
								  "\n     " + v4 + " | " + v5 + " | " + v6 + "\n    ---+---+--- " +
								  "\n     " + v7 + " | " + v8 + " | " + v9 + "\n\n"
					  			 );

				flag = true;
			}
			while(!flag);
		}
	}
}
