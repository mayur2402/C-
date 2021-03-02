using System;
using static System.Math;
class Q3
{
	static void Main()
	{
		Console.WriteLine("Enter first side of triangle in centimeter");
		int s1=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter second side of triangle in centimeter");
		int s2=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter angle in degrees between first and second side");
		int a1=int.Parse(Console.ReadLine());
		double r1=Math.PI*a1/180;
		double ans=0.5*s1*s2*Math.Sin(r1);
		Console.WriteLine("area is {0}",ans);
	}
}
