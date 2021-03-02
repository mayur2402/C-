using System;
class Q2
{
	static void Main()
	{
		Console.WriteLine(DateTime.Now);
		string num="N";
		for(int i=0;i<2000000;i++)
		{
			num+=i;
		}
		Console.WriteLine(num.Substring(0, 1024));
		Console.WriteLine(DateTime.Now);
	}
}
