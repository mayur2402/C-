using System;
namespace Online
{
	public class DivideByOddException : ApplicationException
	{
		public override string Message
		{
			get
			{
				return "Attempted to divide by odd";
			}
		}
	}
	class Appclass
	{
		static void Main()
		{
			Console.WriteLine("Enter First number");
			int no1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Second number");
			int no2 = int.Parse(Console.ReadLine());
			if(no2 % 2 != 0)
			{
				throw new DivideByOddException();
			}
			int ans = no1 / no2;
			Console.WriteLine("Division is "+ans);
		}
	}
}

