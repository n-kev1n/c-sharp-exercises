using System.Security.Cryptography;
using System;
using System.Diagnostics;
class Program
{
 static void Main() {
		 ArrayContainsNumber(new int[] { 0 }, 2);
		 int[] data = { 5, 8, 13, 17, 25, 30, 41, 55 };
		 var watch = System.Diagnostics.Stopwatch.StartNew();
		 Console.WriteLine(ArrayContainsNumber(data, 6));
		 watch.Stop();
		 var elapsedMs = watch.ElapsedMilliseconds;
		 Console.WriteLine("Time taken: "+elapsedMs);
		 
		 var watch2 = System.Diagnostics.Stopwatch.StartNew();
		 int[] data2 = new int[1000000];
		 Array.Fill(data2, 5);
		 Console.WriteLine(ArrayContainsNumber(data2, 6));
		 watch2.Stop();
		 var elapsedMs2 = watch2.ElapsedMilliseconds;
		 Console.WriteLine("Time taken: "+elapsedMs2);
		 
		 }
		 static bool ArrayContainsNumber(int[] data, int wanted)
		 {
		 for (int i = 0; i < data.Length;i++)
		 {
		 if (data[i]==wanted) return true;
		 }
		 return false;
 }
}
