using System;
class Q10
{
	public static void Main()
	{
		Console.WriteLine("Enter number");
		int n=int.Parse(Console.ReadLine());
		for(int i=1;i<=n;i++)
		{
			for(int j=i;j<=n;j++)
			{
				Console.Write(j+"\t");
			}
			Console.WriteLine();
		}
	}
}
