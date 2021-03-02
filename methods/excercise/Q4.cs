using System;
class Q4
{
	static void Main()
	{
		Console.WriteLine("How many array");
		int n=int.Parse(Console.ReadLine());
		int[] arr=new int[n];
		Console.WriteLine("Enter array elements");
		for(int i=0;i<n;i++)
		{
			arr[i]=int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter number to check");
		int num=int.Parse(Console.ReadLine());
		MultiElement(arr,n,num);
	}
	static void MultiElement(int[] arr,int n,int num)
	{
		int count=0,pos=0;
		for(int i=0;i<n;i++)
		{
			if(arr[i]==num)
			{
				count++;
				pos=i;
			}
		}
		Console.WriteLine("Number {0} found {1} times",arr[pos],count);
	}
}
