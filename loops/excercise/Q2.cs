using System;
class Q1
{
	public static void Main()
	{
		int n=0;
		Console.WriteLine("Enter Number");
		n=int.Parse(Console.ReadLine());
		Console.WriteLine("Numbers till {0} not divisible by 3 and 7 is ",n);
		for(int i=1;i<=n;i++)
		{
			if(i%21!=0)
			{
				Console.Write(i+"\t");
			}
		}
		Console.WriteLine();
	}
}
