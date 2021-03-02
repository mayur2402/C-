using System;
class Q1
{
	public static void Main()
	{
		Console.WriteLine("\nEnter radius of circle");
		double r=double.Parse(Console.ReadLine());
		double area=Math.PI*r*r;
		Console.WriteLine("Area is {0}",area);
	}
}
