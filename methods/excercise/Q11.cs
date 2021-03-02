using System;
class Q3
{
	public static void Main()
	{
		Console.WriteLine("Enter your choice");
		Console.WriteLine("1.Reverse\n2.Average\n3.Equation");
		int choice=int.Parse(Console.ReadLine());
		switch(choice)
		{
			case 1:
				Reverse();
				break;
			case 2:
				Average();
				break;
			case 3:
				Equation();
				break;
		}
	}
	static void Reverse()
	{
		int temp=0,digit=0,n=0;
		Console.WriteLine("Enter number");
		n=int.Parse(Console.ReadLine());
		if(n<0 && n>50000000)
		{
			Console.WriteLine("Enter number in range 0-50000000");
		}
		else
		{
			Console.WriteLine("Number is {0}",n);
			while(n!=0)
			{
				digit=n%10;
				n=n/10;
				temp=temp*10+digit;
			}
			Console.WriteLine("Reverse number is {0}",temp);
		}
	}
	static void Average()
	{
		int n=0,avg=0;
		Console.WriteLine("How many numbers");
		n=int.Parse(Console.ReadLine());
		int[] arr=new int[n];
		for(int i=0;i<n;i++)
		{
			arr[i]=int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Numbers are");
		for(int i=0;i<n;i++)
		{
			Console.WriteLine("{0}",arr[i]);
		}
		for(int i=0;i<n;i++)
		{
			avg=avg+arr[i];
		}
		Console.WriteLine("Average is {0}",avg);
	}
	static void Equation()
	{
		int a=0,b=0,x=0;
		Console.WriteLine("Enter value of a");
		a=int.Parse(Console.ReadLine());
		if(a==0)
		{
			Console.WriteLine("A should be non zero");
		}
		else
		{
			Console.WriteLine("Enter value of b");
			b=int.Parse(Console.ReadLine());
			x=-b/a;
			Console.WriteLine("answer of equation is {0}",x);
		}
	}
}
