/*Write a program, which finds the maximal sequence of consecutively
placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}
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
		for(int i=0;i<n-1;i++)
		{
			if(arr[i]==(arr[i+1]-1))
			{
				Console.WriteLine("\t"+arr[i]);
			}
		}
	}
}
