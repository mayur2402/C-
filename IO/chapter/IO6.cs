using System;
class IO6
{
	public static void Main()
	{
		Console.WriteLine("Enter Your First Name");
		string fname=Console.ReadLine();
		Console.WriteLine("Enter Your Last Name");
		string lname=Console.ReadLine();
		Console.WriteLine("Hello {0} {1} ",fname,lname);
		Console.WriteLine("{0} Enter Your Age",fname);
		int age=int.Parse(Console.ReadLine());
		Console.WriteLine("{0} your age is {1}",fname,age);
	}
}
