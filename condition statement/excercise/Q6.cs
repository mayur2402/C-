using System;
class Q6
{
	public static void Main()
	{
		float a=0,b=0,c=0,d=0,r1=0,r2=0;
		Console.WriteLine("Enter a b and c");
		a=float.Parse(Console.ReadLine());
		b=float.Parse(Console.ReadLine());
		c=float.Parse(Console.ReadLine());
		d=(b*b)-(4*a*c);
		if(d<0)
		{
			Console.WriteLine("Roots are imaginary");
		}
		else
		{
			r1=(-b+(float)Math.Sqrt(d))/(2*a);
			r2=(-b-(float)Math.Sqrt(d))/(2*a);
			Console.WriteLine("Roots are {0} and {1}",r1,r2);
		}
	}
}
