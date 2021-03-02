using System;
using System.Linq;
using System.Collections.Generic;
class linqSort
{
	static void Main()
	{
		string[] fruits = {"Apple","Mango","Banana","Cherry"};
		var fru = from fruit in fruits orderby fruits.Length select fruit;
		foreach (string f in fru)
		{
			Console.WriteLine(f);
		}
	}
}
