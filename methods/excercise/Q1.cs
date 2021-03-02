using System;
class Q1
{
	static void Main()
	{
		Console.WriteLine("Enter name");
		string name=Console.ReadLine();
		NameDisplay(name);
	}
	static void NameDisplay(string name)
	{
		Console.WriteLine("Hello {0}",name);
	}
}
