using System;
class Q3
{
	static void Main()
	{
		string paragraph="Pollution, tobacco, preservatives and other factors have contributed to the increased incidence of allergies. To prevent the appearance of allergy, or its annoying symptoms when the person has already developed the condition, the most important thing is to avoid contact with the allergens.";
		Console.WriteLine("Enter word to check");
		string para=Console.ReadLine();
		int count=0;
		for(int i=0;i<paragraph.Length;i++)
		{
			int index=paragraph.IndexOf(para);
			while(index!=-1)
			{
				count++;
			}
		}
		Console.WriteLine("{0} found {1} times",para,count);
	}
}
