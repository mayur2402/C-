using System;
class Q8
{
	static void Main()
	{
		Console.WriteLine("Enter Date");
		Console.WriteLine("Enter hours");
		int h=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter minutes");
		int m=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter second");
		int s=int.Parse(Console.ReadLine());
		bool isvalid=ishours(h) && isminutes(m) && issecond(s);
		if(isvalid)
		{
			Console.WriteLine("date is {0}:{1}:{2}",h,m,s);
		}
		else
		{
			Console.WriteLine("date is not valid");
		}
	}
	static bool ishours(int h)
	{
		bool check=(h>=0) && (h<24);
		return check;
	}
	static bool isminutes(int m)
	{
		bool check=(m>=0) && (m<60);
		return check;
	}
	static bool issecond(int s)
	{
		bool check=(s>=0) && (s<60);
		return check;
	}
}
