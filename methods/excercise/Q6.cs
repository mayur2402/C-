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
		int pos=FirstOccurence(arr,n);
		if(pos!=-1)
		{
			Console.WriteLine("Position of number greater than neighbouring element is {0}",pos);
		}
	}
	static int FirstOccurence(int[] arr,int n)
	{
		for(int i=1;i<n-1;i++)
		{
			if((arr[i]>arr[i-1])&&(arr[i]>arr[i+1]))
			{
				return i+1;
			}
			else
			{
				return -1;
			}
		}
		return -1;
	}
}
