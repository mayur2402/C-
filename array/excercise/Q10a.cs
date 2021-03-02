using System;
class Q10a
{
	static void Main()
	{
		Console.WriteLine("How many rows");
		int r=int.Parse(Console.ReadLine());
		Console.WriteLine("How many columns");
		int c=int.Parse(Console.ReadLine());
		int a=0;
		for(int i=1;i<=r;i++)
		{
			Console.Write(i+"\t");
			a=a+i;
			for(int j=1;j<c;j++)
			{
				a=a+r;
				Console.Write(a+"\t");
			}
			a=0;
			Console.WriteLine();
		}
	}
}
