using System;
class Q6
{
	static void Main()
	{
		Console.WriteLine("How Many elements in array");
		int n=int.Parse(Console.ReadLine());
		int[] arr=new int[n];
		Console.WriteLine("Enter array elements");
		for(int i=0;i<n;i++)
		{
			arr[i]=int.Parse(Console.ReadLine());
		}
		FindMax(arr,n);
	}
	static void FindMax(int[] arr,int n)
	{
		int max=0;
		for(int i=0;i<n-1;i++)
		{
			for(int j=i;j<n;j++)
			{
				if(arr[i]<arr[j])
				{
					max=arr[j];
					arr[j]=arr[i];
					arr[i]=max;
				}
			}
		}
		Console.WriteLine("Array in decending order is");
		for(int i=0;i<n;i++)
		{
			Console.WriteLine("{0}",arr[i]);
		}
		Console.WriteLine("Maximum number in array is {0}",arr[0]);
	}
}
