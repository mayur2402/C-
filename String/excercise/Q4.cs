using System;
class Q4
{
	static void Main()
	{
		string s="We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
		for(int i=0;i<s.Length;i++)
		{
			int index=s.IndexOf("<upcase>");
			Console.WriteLine(index);	
		}
	}
}
