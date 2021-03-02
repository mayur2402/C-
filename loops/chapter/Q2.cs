using System;
class Q2
{
	public static void Main()
	{
		long f=1;
		int n=0;
		Console.WriteLine("Enter number");
		n=int.Parse(Console.ReadLine());
		Console.WriteLine(n);	
		do
		{
			f=f*n;
			n--;
		}while(n>0);
		Console.WriteLine(f);
	}
}
