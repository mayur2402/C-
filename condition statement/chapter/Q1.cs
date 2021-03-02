using System;
class Q1
{
	public static void Main(string[] args)
	{
		int a=10;
		int b=20;
		bool cond=(a<b) && ((b-a)==a);
		if(cond)
		{
			Console.WriteLine(cond);
		}
	}
}
