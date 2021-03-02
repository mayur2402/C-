using System;

namespace lb
{
	class Asc
	{
		public static void Main(string[] args)
		{
			int i = 1;
			while(i < 127)
			{
				Console.WriteLine("{0}\t{1}",i,(char)i);
				i++;
			}
		}
	}
}