using System;
class Q1
{
	static void Main()
	{
		int[] arr=new int[]{1,2,3};
		Console.WriteLine("before modification array is ");
		for(int i=0;i<arr.Length;i++)
		{
			Console.WriteLine(arr[i]);
		}
		Modify(arr);
	}
	static void Modify(int[] arr)
	{
		arr[0]=5;
		Console.WriteLine("After modification array is ");
		for(int i=0;i<arr.Length;i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}
