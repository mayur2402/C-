using System;
using System.Text;
using System.IO;
namespace Online
{
	class Html
	{
		static void Main()
		{
			string line = string.Empty;
			StreamReader str = new StreamReader("h.html");
			while((line = str.ReadLine())!= null)
			{
				Console.WriteLine(line);
			}
		}
	}
}
