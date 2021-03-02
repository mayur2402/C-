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
		for(int i=0;i<n;i++)
		{
			arr1[n-i-1]=arr[i];
		}
		Console.WriteLine("numbers are");
		for(int i=0;i<n;i++)
		{
			Console.WriteLine(arr1[i]);
		}
	}
}
