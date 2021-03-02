using System;
class Q1
{
	public static void Main()
	{
		int n=0;
		Console.WriteLine("Enter Number");
		n=int.Parse(Console.ReadLine());
		for(int i=1;i<=n;i++)
		{
			Console.Write(i+"\t");
		}
		Console.WriteLine();
	}
}
