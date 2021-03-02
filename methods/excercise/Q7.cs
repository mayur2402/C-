using System;
class Q6
{
	static void Main()
	{
		Console.WriteLine("Enter number");
		int n=int.Parse(Console.ReadLine());
		Console.WriteLine("Number is {0}",n);
		Reverse(n);
	}
	static void Reverse(int n)
	{
		int temp=0,digit=0;
		while(n!=0)
		{
			digit=n%10;
			n=n/10;
			temp=temp*10+digit;
		}
		Console.WriteLine("Reverse number is {0}",temp);
	}
}
