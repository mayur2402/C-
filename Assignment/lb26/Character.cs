using System;
namespace lb
{
	class Character
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("\nEnter Character\t");
			char ch = char.Parse(Console.ReadLine());

			if(ch >= 'a' && ch <= 'z')
			{
				Console.WriteLine("{0}",(char)(ch-32));
			}
		}
	}
}