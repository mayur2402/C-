using System;
using System.IO;
class Q1
{
	static void Main()
	{
		StreamReader reader=new StreamReader("Q1.txt");
		int count=0;
		string line=reader.ReadLine();
		while(line!=null)
		{
			count++;
			Console.WriteLine(line);
			line=reader.ReadLine();
		}
	reader.Close();
	}
}
