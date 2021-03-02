using System;
class Q5
{
	static int Sum(params int[] num)
	{
		int sum=0;
		foreach(int n in num)
		{
			sum=sum+n;
		}
		return sum;
	}
	static void Main(string[] args)
	{
		Console.WriteLine("Sum is {0}",Sum(10,20,30));
		Console.WriteLine("Sum is {0}",Sum(10,20,30,40,50,60));
	}
}
