using System;
class Q9
{
	static void Main()
	{
		int[] numbers=new int[20];
		Console.WriteLine("how many numbers");
		int num=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter numbers");
		for(int i=0;i<num;i++)
		{
			numbers[i]=int.Parse(Console.ReadLine());
		}
		Sort(numbers,num);
	}
	static void Sort(int[] number,int n)
	{
		for(int i=0;i<n-1;i++)
		{
			for(int j=i+1;j<n;j++)
			{
				if(number[i]>number[j])
				{
					int old=number[i];
					number[i]=number[j];
					number[j]=old;
				}
			}
		}
		Console.WriteLine("Sorted numbers are");
		for(int i=0;i<n;i++)
		{
			Console.WriteLine(number[i]);
		}
	}
}
