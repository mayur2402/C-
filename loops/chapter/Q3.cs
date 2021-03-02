using System;
class Q3
{
	public static void Main()
	{
		int start=0,end=0,prod=1;
		Console.WriteLine("Enter stating number");
		start=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter ending number");
		end=int.Parse(Console.ReadLine());
		int s=start;
		int e=end;
		do
		{
			prod=prod*start;
			start++;
		}while(start<=end);
		Console.WriteLine("Product of numbers between {0} and {1} is {2} ",s,e,prod);
	}
}
