/*
Write a program that gets the coefficients a , b and c of a quadratic
equation: ax 2 + bx + c , calculates and prints its real roots (if they exist).
Quadratic equations may have 0, 1 or 2 real roots
*/
using System;
using static System.Math;

namespace CaseStudy
{
	class Quadratic
	{
		public static void Main(string[] args)
		{
			int a = 0,b = 0,c = 0;

			try
			{
				Console.WriteLine("Enter Value of a");
				a = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter Value of b");
				b = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter Value of c");
				c = int.Parse(Console.ReadLine());
			}
			catch(FormatException e)
			{
				Console.WriteLine(e.Message);
				Environment.Exit(0);
			}
			
			if(a == 0)
			{
				Console.WriteLine("Error : Enter Valid Values");
				Environment.Exit(0);
			}

			int desc = ((b*b) - (4 * a * c));

			if(desc < 0)
			{
				Console.WriteLine("Roots are imaginary");
			}
			else if(desc == 0)
			{
				Console.WriteLine("Root is {0}",(-b/(2*a)));
			}
			else
			{
				double root1 = (-b - Sqrt(desc))/(2*a);
				double root2 = (-b + Sqrt(desc))/(2*a);

				Console.WriteLine("Root 1 is {0} \nRoot 2 is {1}",root1,root2);
			}
		}
	}
}