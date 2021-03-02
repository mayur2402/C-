using System;
class Q5
{
	public static void Main()
	{
		int n=0,fib=0,a=0,b=1,sum=0;
		Console.WriteLine("How Many number in fibonnaci series");
		n=int.Parse(Console.ReadLine());
		Console.WriteLine(a);
		Console.WriteLine(b);
		for(int i=0;i<n;i++)
		{
			fib=a+b;
			a=b;
			b=fib;
			Console.WriteLine(fib);
			sum=sum+fib;
		}
		Console.WriteLine("Sum is {0}",sum);
	}
}
