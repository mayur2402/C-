using System;
namespace Online
{
	class Exceptionclass
	{
		static void Main()
		{
			try	//block where we write statements generating exception 
			{
				Console.WriteLine("Enter First Number");
				int no1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter Second Number");
				int no2 = int.Parse(Console.ReadLine());
				int ans = no1 / no2;
				Console.WriteLine("Division of {0} and {1} is {2}",no1,no2,ans);
			}
			catch(DivideByZeroException e)	//block to catch exception Divide By Zero
			{
				Console.WriteLine(e.Message);	//e.Message generate automatic message regarding exception
			}
			catch(FormatException e)	//block to catch Format exception value enter other than int 
			{
				Console.WriteLine("Input should be integer");
			}
			catch(Exception e)	//block to catch all exception 
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				Console.WriteLine("Block should be exceute whether exception occur or not");
			}
		}
	}
}
