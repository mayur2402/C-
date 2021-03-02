/*Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.*/
using System;
class Q61
{
	public static void Main()
	{
		Console.WriteLine("\nEnter Two numbers");
		int n1=int.Parse(Console.ReadLine());
		int n2=int.Parse(Console.ReadLine());
		int n3=(n1+n2);
		int n4=(n1-n2);
		int n5=(n3+n4)/2;
		Console.WriteLine("Max is {0}",n5);
		
	}
}
