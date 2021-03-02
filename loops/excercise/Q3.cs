using System;
class Q1
{
	public static void Main()
	{
		int n=0;
		int lowest=1000,highest=0;
		Console.WriteLine("How many Number");
		n=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number");
		for(int i=1;i<=n;i++)
		{
			int num=int.Parse(Console.ReadLine());
			if(i==0)
			{
				lowest=highest=num;
			}
			else
			{
				if(lowest>num)
				{
					lowest=num;
				}
				else if(highest<num)
				{
					highest=num;
				}
			}
		}
		Console.WriteLine("Highest is {0} and lowest is {1}",highest,lowest);
	}
}
