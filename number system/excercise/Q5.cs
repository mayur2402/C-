/*Write a program that converts a binary number to decimal one.*/
using System;
class Q5
{
	static void Main()
	{
		Console.WriteLine("Enter binary number to convert in decimal");
		int num=int.Parse(Console.ReadLine());
		int sum=0,temp=0,base1=1;
		while(num>0)
		{
			temp=num%10;
			sum=sum+temp*base1;
			num=num/10;
			base1=base1*2;
		}
		Console.WriteLine("{0}",sum);
	}
}
