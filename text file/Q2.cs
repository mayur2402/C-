using System;
using System.IO;
class Q2
{
	static void Main()
	{
		StreamWriter write=new StreamWriter("a.txt");
		using(write)
		{
			for(int i=1;i<=20;i++)
			{
				write.WriteLine(i);
			}
		}
		StreamReader read=new StreamReader("a.txt");
		using(read)
		{
	/*		string i=read.ReadLine();
			while(i!=null)
			{
				Console.WriteLine(int.Parse(i));
				i=read.ReadLine();
			}*/
			Console.WriteLine(read.ReadToEnd());
		}
	}
}
