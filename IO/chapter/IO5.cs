using System;
using System.Threading;
using System.Globalization;
class IO5
{
	public static void Main()
	{
		DateTime d=new DateTime(2020,04,27,1,23,45);
		Thread.CurrentThread.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
		Console.WriteLine("{0:N}",11234.23);
		Console.WriteLine("{0:D}",d);
		Thread.CurrentThread.CurrentCulture=CultureInfo.GetCultureInfo("bg-BG");
		Console.WriteLine("{0:N}",11234.23);
		Console.WriteLine("{0:D}",d);
	}
}
