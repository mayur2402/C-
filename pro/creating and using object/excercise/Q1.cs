using System;
class Q1
{
	static void Main()
	{
		Console.WriteLine("Enter Year");
		int year=int.Parse(Console.ReadLine());
		if(DateTime.IsLeapYear(year))
		{
			Console.WriteLine("Leap Year");
		}
		else
		{
			Console.WriteLine("Not Leap Year");
		}
	}
}
