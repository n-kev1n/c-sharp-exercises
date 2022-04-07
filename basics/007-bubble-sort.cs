using System;

namespace BubbleSort
{
	class Program
	{
		static int[] SortNumbers(int[] arrTobeSorted){
			int temp;

			for (int i = 0; i <= arrTobeSorted.Length -2; i++)
			{
				for (int j = 0; j <= arrTobeSorted.Length -2; j++)
				{
					if (arrTobeSorted[j] > arrTobeSorted[j + 1])
					{
						temp = arrTobeSorted[ j + 1 ];
						arrTobeSorted[ j + 1 ] = arrTobeSorted[j];
						arrTobeSorted[j] = temp;
					}
				}
			}

			return arrTobeSorted;
		}
		static void Main(string[] args){
			int[] arrUnsorted = {12, 23, 1, 2, 32};
			int[] arrSorted = SortNumbers(arrUnsorted);
			foreach (var item in arrSorted)
				Console.WriteLine($"{item}");
		}		
	}
}
