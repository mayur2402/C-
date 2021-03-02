using System;
class Q4
{
	public static void Main()
	{
		for(int i=1;i<=4;i++)
		{
			for(int j=1;j<=13;j++)
			{
				switch(i)
				{
					case 1:Console.WriteLine("diamond");break;
					case 2:Console.WriteLine("heart");break;
					case 3:Console.WriteLine("spades");break;
					case 4:Console.WriteLine("clubs");break;
				}
				switch(j)
				{
					case 1:Console.WriteLine("2");break;
					case 2:Console.WriteLine("3");break;
					case 3:Console.WriteLine("4");break;
					case 4:Console.WriteLine("5");break;
					case 5:Console.WriteLine("6");break;
					case 6:Console.WriteLine("7");break;
					case 7:Console.WriteLine("8");break;
					case 8:Console.WriteLine("9");break;
					case 9:Console.WriteLine("2");break;
					case 10:Console.WriteLine("K");break;
					case 11:Console.WriteLine("Q");break;
					case 12:Console.WriteLine("J");break;
					case 13:Console.WriteLine("A");break;
				}
			}
			Console.WriteLine();
		}
	}
}
