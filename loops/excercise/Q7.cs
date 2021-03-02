using System;
class Q5
{
	public static void Main()
	{
		Console.WriteLine("Enter n where (1<k<n)");
		int n=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter k where (1<k<n)");
		int k=int.Parse(Console.ReadLine());
		int div=(n-k);
		for(int i=n-1;i>0;i--)
		{
			n=n*i;
		}
		for(int j=k-1;j>0;j--)
		{
			k=k*j;
		}
		Console.WriteLine(div);
		Console.WriteLine("n! is {0} and k! is {1}",n,k);
		Console.WriteLine("N!*k! is {0}",n*k);
		for(int i=(div-1);i>0;i--)
		{
			div=div*i;
		}
		Console.WriteLine("(N!*k!)/(n-k)! is {0}",(n*k)/div);
	}
}
