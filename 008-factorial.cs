using System;

namespace Factorial
{
	class Program
	{
		static int getFactorial(int n)
		{
			int factorial  = 1;
			for (int i = 1; i <= n; i++)
			{
				factorial = factorial * i;
			}
			return factorial;
		}
		static void Main(string[] args){
			Console.WriteLine("Factorial of 1..10 :");
			Console.WriteLine(getFactorial(10));
		}
	}
}
