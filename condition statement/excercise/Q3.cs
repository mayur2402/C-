using System;
namespace number
{
	class Q1
	{
		public static void Main()
		{
			Console.WriteLine("Enter three numbers");
			int n1=int.Parse(Console.ReadLine());
			int n2=int.Parse(Console.ReadLine());
			int n3=int.Parse(Console.ReadLine());
			if((n1>n2)&&(n1>n3))
			{
				Console.WriteLine("Biggest number is {0}",n1);
			}
			else if((n2>n1)&&(n2>n3))
			{
				Console.WriteLine("Biggest number is {0}",n2);
			}
			else
			{
				Console.WriteLine("Biggest number is {0}",n3);
			}
		}
	}
}
