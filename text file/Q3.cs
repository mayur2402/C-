using System;
using System.IO;
class Q3
{
	static void Main()
	{
		try
		{
			StreamReader read=new StreamReader("Q1.txt");
			Console.WriteLine("file Open successfully");
			Console.WriteLine("Content are");
			using(read)
			{
				Console.WriteLine(read.ReadToEnd());
			}
		}
		catch(FileNotFoundException)
		{
			Console.Error.WriteLine("File not found");
		}
	}
}
