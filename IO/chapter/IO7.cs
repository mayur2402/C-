using System;
class IO7
{
	public static void Main()
	{
		Console.WriteLine("\nCalculate area of rectangle or triangle");
		Console.WriteLine("\nEnter l and b for rectangle or a and h for triangle");
		float x=float.Parse(Console.ReadLine());
		float y=float.Parse(Console.ReadLine());
		Console.WriteLine("Enter 1 for rectangle or 2 for triangle");
		float choice=float.Parse(Console.ReadLine());
		float ans=(x*y)/choice;
		Console.WriteLine("Area is {0}",ans);
	}
}
