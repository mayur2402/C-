using System;
class Q1
{
	public static void Main()
	{
		int[] arr=new int[10];
		int[] arr1=new int[10];
		Console.WriteLine("How many Numbers");
		int n=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number");
		for(int i=0;i<n;i++)
		{
			arr[i]=int.Parse(Console.ReadLine());
		}
		Console.WriteLine("numbers are");
		for(int i=0;i<n;i++)
		{
			Console.WriteLine(arr[i]);
		}
		bool flag=true;
		for(int i=0;i<(n/2);i++)
		{
			if(arr[i]!=arr[n-i-1])
			{
				flag=false;
				break;
			}
		}
		if(flag==true)
		{
			Console.WriteLine("array are symmetric");
		}
	}
}
