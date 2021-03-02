using System;
class Q7
{
	static void Main()
	{
		float temp=0,farh=0;
		Console.WriteLine("Enter temperature in Farhneit");
		farh=float.Parse(Console.ReadLine());
		temp=converttocel(farh);
		Console.WriteLine("Your temperature in degree celcius is {0}",temp);
		if(temp>37)
		{
			Console.WriteLine("You are ill");
		}
	}
	static float converttocel(float f)
	{
		float t=(f-32)*5/9;
		return t;
	}
}
