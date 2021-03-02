class Character
{
	public static void Main()
	{
		char ch='a';
		while(ch<='z')
		{
			System.Console.WriteLine("Character is "+ch+" and it's ASCII value is "+(int)ch);
			ch++;
		}
		char ch1='A';
		while(ch1<='Z')
		{
			System.Console.WriteLine("Character is "+ch1+" and it's ASCII value is "+(int)ch1);
			ch1++;
		}
		
	}
} 
