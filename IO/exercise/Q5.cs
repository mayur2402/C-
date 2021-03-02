/*Write a program that reads from the console two integer numbers ( int ) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25*/
using System;
class Q5
{
	public static void Main()
	{
		Console.WriteLine("Enter two number");
		int n1=int.Parse(Console.ReadLine());
		int n2=int.Parse(Console.ReadLine());
		Console.Write("Numbers divisible by 5 in range {0} to {1} is\n",n1,n2);
		for(int i=n1;i<=n2;i++)
		{
			if(i%5==0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
