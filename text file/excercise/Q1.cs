using System;
using System.IO;
class Q1
{
	static void Main()
	{
		Console.WriteLine("Enter File Name");
		string name=Console.ReadLine();
		int count=1;
		StreamReader read=new StreamReader(name);
		using(read)
		{
			string line=read.ReadLine();
			while(line!=null)
			{
				line=read.ReadLine();
				if(count%2!=0)
				{
					Console.WriteLine(line);
				}
				count++;
			}
		}
	}
}
