/*Write a program that prints on the console the first 100 numbers in the Fibonacci sequence*/
using System;
class Q11
{
	public static void Main()
	{
		Console.Write("\nHow many number");
		int num=int.Parse(Console.ReadLine());
		long a=0,b=1,i=0,ans=0;
		Console.WriteLine(a);
		Console.WriteLine(b);
		for(i=0;i<num;i++)
		{
			ans=a+b;
			a=b;
			b=ans;
			Console.WriteLine(ans);
		}
	}
}
