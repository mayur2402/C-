using System;
class Q5
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
		Console.WriteLine("Enter position");
		int pos=int.Parse(Console.ReadLine());
		if(pos<0 && pos>n)
		{
			Console.WriteLine("Enter valid Position");
			return ;
		}
		Check(arr,pos,n);
	}
	static void Check(int[] arr,int pos,int n)
	{
		if(pos==0)
		{
			if(arr[pos]>arr[pos+1])
			{
				Console.WriteLine("{0} greater than right element",arr[pos]);
			}
			else if(arr[pos]<arr[pos+1])
			{
				Console.WriteLine("{0} Smaller than right element",arr[pos]);
			}
			else
			{
				Console.WriteLine("{0} Equal with right element",arr[pos]);
			}
		}
		else if(pos==(n-1))
		{
			if(arr[pos]>arr[pos-1])
			{
				Console.WriteLine("{0} greater than left element",arr[pos]);
			}
			else if(arr[pos]<arr[pos-1])
			{
				Console.WriteLine("{0} Smaller than left element",arr[pos]);
			}
			else
			{
				Console.WriteLine("{0} Equal with left element",arr[pos]);
			}
		}
		else
		{
			if(arr[pos]<arr[pos+1])
			{
				Console.WriteLine("{0} Smaller than right element",arr[pos]);
			}
			else if(arr[pos]>arr[pos+1])
			{
				Console.WriteLine("{0} greater than right element",arr[pos]);
			}
			else
			{
				Console.WriteLine("{0} Equal with right element",arr[pos]);
			}
			if(arr[pos]>arr[pos-1])
			{
				Console.WriteLine("{0} greater than left element",arr[pos]);
			}
			else if(arr[pos]<arr[pos-1])
			{
				Console.WriteLine("{0} Smaller than left element",arr[pos]);
			}
			else
			{
				Console.WriteLine("{0} Equal with left element",arr[pos]);
			}
		}
	}
}
