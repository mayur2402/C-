using System;
using System.Collections;
class Arraylist
{
	static void Main()
	{
		ArrayList AL = new ArrayList();
		Console.WriteLine("Initial Capacity "+AL.Capacity);
		AL.Add(10);
		AL.Add(20);
		AL.Add(30);
		AL.Add(40);
		AL.Add(50);
		Console.WriteLine("After Adding Elements Capacity "+AL.Capacity);
		Console.WriteLine("Elements in ArrayList");
		foreach(int i in AL)
		{
			Console.WriteLine(i);
		}
		AL.Insert(3,35);
		Console.WriteLine("Elements in ArrayList after adding");
		foreach(int i in AL)
		{
			Console.WriteLine(i);
		}
		AL.Remove(40);
		Console.WriteLine("Elements in ArrayList after removing");
		foreach(int i in AL)
		{
			Console.WriteLine(i);
		}
	}
}
