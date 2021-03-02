using System;
class Q2
{
	static void Main()
	{
		string expression;
		Console.WriteLine("Enter Expression");
		expression=Console.ReadLine();
		int opening=0,closing=0;
		for(int i=0;i<expression.Length;i++)
		{
			if(expression[i]=='(')
			{
				opening++;
			}
			if(expression[i]==')')
			{
				closing++;
			}
		}
		if((closing-opening)==0)
		{
			Console.WriteLine("Paranthesis are correct");
		}
		else
		{
			Console.WriteLine("Paranthesis are incorrect");
		}
	}
}
