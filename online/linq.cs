using System;
using System.Linq;
using System.Collections.Generic;
class Number
{
	static void Main()
	{
		List<int> num = new List<int>{10,20,30,40,50,60,70,80,90,33,55,45,76,89};
		var n = from no in num where no%2 == 0 select no;
		foreach(int i in n)
		{
			Console.WriteLine(i);
		}
	}
}
