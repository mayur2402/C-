using System;
namespace number
{
	class Q1
	{
		public static void Main()
		{
			Console.WriteLine("Enter two numbers");
			int n1=int.Parse(Console.ReadLine());
			int n2=int.Parse(Console.ReadLine());
			if(n1>n2)
			{
				n1=n1+n2;
				n2=n1-n2;
				n1=n1-n2;
				Console.WriteLine("First number is {0}\nSecond number is {1}",n1,n2);
			}
		}
	}
}
