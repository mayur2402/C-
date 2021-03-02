using System;
class Q7
{
	public static void Main()
	{
		int i=0,max=0;
		Console.WriteLine("Enter five number");
		while(i<5)
		{
			string n1=Console.ReadLine();
			int num1;
			bool nn1=Int32.TryParse(n1,out num1);
			if(nn1)
			{
				if(num1>max)
				{
					max=num1;
				}
				i++;		
			}
			else
			{
				Console.WriteLine("Invalid Number");
			}
	
		}
		Console.WriteLine("Max is {0}",max);
	}
}
