using System;
using System.Text;
class Q1
{
	static void Main()
	{
		string name;
		Console.WriteLine("Enter String");
		name=Console.ReadLine();
		string name1=Reverse(name);
		Console.WriteLine("Reverse is {0}",name1);
	}
	static string Reverse(string n)
	{
		StringBuilder sb=new StringBuilder();
		for(int i=n.Length-1;i>=0;i--)
		{
			sb.Append(n[i]);
		}
		return sb.ToString();
	}
}
