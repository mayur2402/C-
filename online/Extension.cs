using System;
namespace Online
{
	public class Extension
	{
		public void Test1()
		{
			Console.WriteLine("Method 1");
		}
		public void Test2()
		{
			Console.WriteLine("Method 2");
		}
		static void Main()
		{
			Extension E = new Extension();
			E.Test1();
			E.Test2();
		}
	}
}
