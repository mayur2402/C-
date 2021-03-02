using System;
using static System.Math;
class Q5
{
	static void Main()
	{
		Console.WriteLine("Enter two sides length in cm");
		int s1=int.Parse(Console.ReadLine());
		int s2=int.Parse(Console.ReadLine());
		int c=(int)Math.Sqrt((s1*s1)+(s2*s2));
		Console.WriteLine("Hypotenous is {0}",c);
	}
}
