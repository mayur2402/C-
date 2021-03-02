using System;
class Q2
{
	static void Main()
	{
		Console.WriteLine("Enter three numbers");
		int n1=int.Parse(Console.ReadLine());
		int n2=int.Parse(Console.ReadLine());
		int n3=int.Parse(Console.ReadLine());
		int n=GetMax(GetMax(n1,n2),n3);
		Console.WriteLine("Max number is {0}",n);
	}
	static int GetMax(int x,int y)
	{
		if(x>y)
		{
			return x;
		}
		else
		{
			return y;
		}
	}
}
