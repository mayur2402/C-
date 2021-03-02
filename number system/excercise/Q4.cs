/*Write a program that converts a decimal number to binary one*/
using System;
class Q4
{
	static void Main()
	{
		Console.WriteLine("Enter number to convert in binary");
		int num=int.Parse(Console.ReadLine());
		int[] b=new int[8];
		int i=0;
		while(num>0)
		{
			b[i]=num%2;
			num=num/2;
			i++;
		}
		for(int j=i-1;j>=0;j--)
		{
			Console.Write("{0}",b[j]);
		}
	}
}
