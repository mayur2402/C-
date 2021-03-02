using System;
using static System.Random;
class Q4
{
	static void Main()
	{
		Random rand=new Random();
		for(int i=1;i<6;i++)
		{
			int num=rand.Next(49);
			Console.WriteLine(num);
		}
	}
}
