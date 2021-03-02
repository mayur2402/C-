using System;
class Q2
{
	public static void Main()
	{
		string name="Mayur";
		string name1=name;
		string name2="Mayu";
		Console.WriteLine("Name is {0}",name);
		Console.WriteLine("second Name is {0}",name1);
		Console.WriteLine("third Name is {0}",name2);
		Console.WriteLine(name==name1);
		name2=name2+"r";
		Console.WriteLine(name1==name2);
		Console.WriteLine((object)name==(object)name1);
		Console.WriteLine((object)name1==(object)name2);
	}
}
