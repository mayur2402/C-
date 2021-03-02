/*Write a program, which finds the maximal sequence of consecutive
equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}
*/
using System;
class Q4
{
	static void Main()
	{
		Console.WriteLine("Enter array Elements");
		int n=int.Parse(Console.ReadLine());
		int[] arr=new int[n];
		Console.WriteLine("Enter Elements");
		for(int i=0;i<n;i++)
		{
			arr[i]=int.Parse(Console.ReadLine());
		}
		int count=1,temp=1,num=0;
		for(int i=0;i<n-1;i++)
		{
			if(arr[i]==arr[i+1])
			{
				count++;
			}
			else
			{
				count=1;
			}
			if(count>temp)
			{
				temp=count;
				num=arr[i];
			}
		}
		Console.Write("maximal sequence of consecutive equal element in array\t");
		for(int i=0;i<temp;i++)
		{
			Console.Write(num+"\t");
		}
	}
}
