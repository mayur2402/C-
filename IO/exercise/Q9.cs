/*Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum*/
using System;
class Q9
{
	public static void Main()
	{
		Console.WriteLine("How many number");
		int num=int.Parse(Console.ReadLine());
		int i,ans=0;
		for(i=0;i<num;i++)
		{
			ans=ans+i;
		}
		Console.WriteLine("addition is {0}",ans);
	}
}
