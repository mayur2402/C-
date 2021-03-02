using System;
using System.IO;
class Q3
{
	static void Main()
	{
		Console.WriteLine("Enter file name");
		string file=Console.ReadLine();
		Console.WriteLine("Enter file name in which we want output");
		string file1=Console.ReadLine();
		InsertNumber(file,file1);
		Display(file1);
	}
	static void InsertNumber(string file,string file1)
	{
		int count=1;
		StreamReader sr=new StreamReader(file);
		StreamWriter sw=new StreamWriter(file1);
		using(sr)
		{
			using(sw)
			{
				while(!sr.EndOfStream)
				{
					sw.WriteLine("Line {0} {1}",count++,sr.ReadLine());
				}
			}
		}
	}
	static void Display(string file1)
	{
		StreamReader sr=new StreamReader(file1);
		 Console.WriteLine(sr.ReadToEnd());
	}
}
