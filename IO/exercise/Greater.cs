using System;
class Greater
{
	public static void Main()
	{
		Console.WriteLine("\nEnter Two numbers");
		int n1=int.Parse(Console.ReadLine());
		int n2=int.Parse(Console.ReadLine());
		Console.WriteLine("Max is {0}",Math.Max(n1,n2));
	}
}
