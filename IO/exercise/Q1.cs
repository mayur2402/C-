using System;
class Q1
{
	public static void Main()
	{
		Console.WriteLine("\nEnter three numbers");
		int n1=int.Parse(Console.ReadLine());
		int n2=int.Parse(Console.ReadLine());
		int n3=int.Parse(Console.ReadLine());
		int ans=n1+n2+n3;
		Console.WriteLine("sum of numbers is {0}",ans);
	}
}
