using System;
using System.IO;
class q2
{
	static void Main()
	{
		string InFile1,InFile2,OutFile;
		Console.WriteLine("Enter first file");
		InFile1=Console.ReadLine();
		Console.WriteLine("Enter second file");
		InFile2=Console.ReadLine();
		Console.WriteLine("Enter Output file");
		OutFile=Console.ReadLine();
		Accept(InFile1,OutFile);
		Accept(InFile2,OutFile);
		Display(OutFile);
	}
	static void Accept(string In,string Out)
	{
		StreamReader read=new StreamReader(In);
		StreamWriter write=new StreamWriter(Out,true);
		using(read)
		{
			using(write)
			{
				while(!read.EndOfStream)
				{
					write.WriteLine(read.ReadLine());
				}
			}
		}
	}
	static void Display(string Out)
	{
		StreamReader read=new StreamReader(Out);
		Console.WriteLine(read.ReadToEnd());
	}
}
