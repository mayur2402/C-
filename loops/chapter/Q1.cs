using System;
class Q1
{
	public static void Main()
	{
		Console.WriteLine("\nEnter number to check prime or not");
		int n=int.Parse(Console.ReadLine());
		float sqrt=(float)Math.Sqrt(n);
		int i=2;
		bool prime=true;
		while(i<sqrt)
		{
			if(n%i==0)
			{
				prime=false;
			}
			i++;
		}
		Console.WriteLine("Prime?\t"+prime);
	}
}
