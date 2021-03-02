using System;
class Q6
{
	static void Main()
	{
		string line="We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else";
		int index=line.IndexOf("<upcase>");
		Console.WriteLine(index);
		while(index!=-1)
		{
			for(int i=index+8;i<line.IndexOf("</upcase");i++)
			{
				Console.Write(line[i]);
			}
			index=line.IndexOf("<upcase>",index+1);
		}
	}
}
