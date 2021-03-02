using System;
using static System.Environment;
class Q2
{
	static void Main()
	{
		int start=Environment.TickCount;
		int sum=0;
		for(int i=0;i<100000;i++)
		{
			sum++;
		}
		int end=Environment.TickCount;
		Console.WriteLine("Start is {0} end is {1} total is {2}",start,end,(end-start)/100.0);
	}
}
