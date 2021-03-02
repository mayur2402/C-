using System;
using System.Threading;
class ThreadTest
{
	static long count1,count2;
	static void ICount1()
	{
		while(true)
		{
			count1=count1+1;
		}
	}
	static void ICount2()
	{
		while(true)
		{
			count2=count2+1;
		}
	}
	static void Main()
	{
		Thread t1 = new Thread(ICount1);
		Thread t2 = new Thread(ICount2);
		t1.Start();
		t2.Start();

		Console.WriteLine("Main Thread is going to sleep");
		Thread.Sleep(15000);
		Console.WriteLine("Main Thread is going to start");
		
		t1.Priority = ThreadPriority.Lowest;
		t2.Priority = ThreadPriority.Highest;

		t1.Abort();
		t2.Abort();

		t1.Join();
		t2.Join();

		Console.WriteLine("Count 1 is "+count1);
		Console.WriteLine("Count 2 is "+count2);
	}
}
