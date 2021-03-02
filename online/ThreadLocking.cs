using System;
using System.Threading;
class ThreadLocking
{
	public void Display()
	{
		lock(this)	//if we not use lock method output is correct
		{
			Console.Write("CSharp is an");
			Thread.Sleep(5000);
			Console.WriteLine("Object Oriented Language");
		}
	}
	static void Main()
	{
		ThreadLocking TL = new ThreadLocking();
		Thread T1 = new Thread(TL.Display);
		Thread T2 = new Thread(TL.Display);
		Thread T3 = new Thread(TL.Display);
		
		T1.Start();
		T2.Start();
		T3.Start();
	}
}
