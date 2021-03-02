using System;
class Q12
{
	public static void Main()
	{
		Console.WriteLine("Enter binary number ");
		int n=int.Parse(Console.ReadLine());
	string toDecimal = Convert.ToString(Convert.ToInt(n, 2), 10);
    Console.WriteLine("Result is {0}", toDecimal);
} 
}
