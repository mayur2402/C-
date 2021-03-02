using System;
using static System.Math;
class Q6
{
	static void Main()
	{
	Console.WriteLine("1.Triangle with three side\n2.Triangle with two side");
	Console.WriteLine("3.Triangle with side and altitude");
	Console.WriteLine("Enter Your choice");
	int choice=int.Parse(Console.ReadLine());
	switch(choice)
	{
		case 1:
			Console.WriteLine("Enter three sides of triangle");
			int s1=int.Parse(Console.ReadLine());
			int s2=int.Parse(Console.ReadLine());
			int s3=int.Parse(Console.ReadLine());
			int p=(s1+s2+s3)/2;
			double s=Math.Sqrt(p*(p-s1)*(p-s2)*(p-s3));
			Console.WriteLine("Area of triangle is {0}",s);
			break;
		case 2:
			Console.WriteLine("Enter two sides of triangle");
			int ss1=int.Parse(Console.ReadLine());
			int ss2=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter angle between two side");
			int angle=int.Parse(Console.ReadLine());
			double pp=Math.PI*angle/180;
			double ans=(ss1*ss2*Math.Sin(pp))/2;
			Console.WriteLine("Area of triangle is {0}",ans);
			break;
		case 3:
			Console.WriteLine("Enter side of triangle");
			int sss1=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter altitude of triangle");
			int sss2=int.Parse(Console.ReadLine());
			double ans1=sss1*sss2/2;
			Console.WriteLine("Area of triangle is {0}",ans1);
			break;
	}
}
}
