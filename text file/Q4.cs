using System;
using System.IO;
class Q4
{
	static void Main()
	{
		int count=0;
		try
		{
			StreamReader read=new StreamReader("");
			using(read)
			{
				string line = read.ReadLine();
				while(line!=null)
				{
					int index=line.IndexOf("fuck");
					while(index!=-1)
					{
						count++;
						index=line.IndexOf("fuck",index+1);
					}
					line=read.ReadLine();
					Console.WriteLine(line);	
				}
				Console.WriteLine("Word c found {0} times",count);
			}
		}
		catch(FileNotFoundException)
		{
			Console.Error.WriteLine("File not open");
		}
	}
}
