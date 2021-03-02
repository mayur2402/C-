using System;
class Q2
{
	static void Main()
	{
		Console.WriteLine("How many numbers in first array");
		int n1=int.Parse(Console.ReadLine());
		int[] arr1=new int[n1];
		Console.WriteLine("Enter elements");
		for(int i=0;i<n1;i++)
		{
			arr1[i]=int.Parse(Console.ReadLine());
		}
		Console.WriteLine("How many numbers in second array");
		int n2=int.Parse(Console.ReadLine());
		int[] arr2=new int[n2];
		Console.WriteLine("Enter elements");
		for(int i=0;i<n2;i++)
		{
			arr2[i]=int.Parse(Console.ReadLine());
		}
		bool flag=true;
		if(n1==n2)
		{
			for(int i=0;i<n1;i++)
			{
				if(arr1[i]!=arr2[i])
				{
					flag=false;
				}
			}
		}
		else
		{
			flag=false;
		}
		if(flag)
		{
			Console.WriteLine("Equal");
		}
		else
		{
			Console.WriteLine("Equal");
		}	
	}
}
