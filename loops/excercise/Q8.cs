using System;
class Q5
{
	public static void Main()
	{
		Console.WriteLine("Enter n where (1<k<n)");
		int n=int.Parse(Console.ReadLine());
		int n1=(n+1);
		int n2=2*n;
		for(int i=n-1;i>0;i--)
		{
			n=n*i;
		}
		for(int j=n1-1;j>0;j--)
		{
			n1=n1*j;
		}
		for(int k=n2-1;k>0;k--)
		{
			n2=n2*k;
		}
		Console.WriteLine("n! is {0} ,(n+1)! is {1} and 2n! is {2}",n,n1,n2);
		Console.WriteLine("2N!/(n+1)!*n! is {0}",n2/n1*n);
	}
}
