using System;
class Q6
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter number");
		int n=int.Parse(Console.ReadLine());
		for(int i=1;i<=n;i++)
		{
			triangle(1,i);
		}
		for(int i=n-1;i>=1;i--)
		{
			triangle(1,i);
		}
	}
	static void triangle(int start,int end)
	{
		for(int j=start;j<=end;j++)
		{
			Console.Write(j+"\t");
		}
		Console.WriteLine();
	}
}
