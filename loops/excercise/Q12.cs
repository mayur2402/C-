using System;
class Q12
{
	public static void Main()
	{
		Console.WriteLine("Enter number ");
		int n=int.Parse(Console.ReadLine());
		for(int i=1;i<n;i++)
		{
			string binary=Convert.ToString(i,2);
			Console.WriteLine(binary);
		}
	}
}
