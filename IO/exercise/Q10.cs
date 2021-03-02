/*Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum*/
using System;
class Q9
{
	public static void Main()
	{
		Console.WriteLine("How many number");
		int num=int.Parse(Console.ReadLine());
		int i;
		for(i=1;i<=num;i++)
		{
			Console.WriteLine(i);
		}
		
	}
}
