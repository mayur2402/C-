using System;
class Q4
{
	public static void Main()
	{
		long b=0,p=0,prod=1,i;
		Console.WriteLine("Enter number");
		b=long.Parse(Console.ReadLine());
		Console.WriteLine("Enter number's power");
		p=long.Parse(Console.ReadLine());
		for(i=0;i<p;i++)
		{
			prod=prod*b;
		}
		Console.WriteLine(prod);
	}
}
