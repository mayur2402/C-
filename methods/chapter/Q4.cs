using System;
class Q4
{
	static void Sum(params decimal[] num)
	{
		decimal sum=0;
		foreach(decimal number in num)
		{
			sum=sum+number;
		}
		Console.WriteLine("Sum of book price is {0}",sum);
	}
	static void Main(string[] args)
	{
		//decimal[] price=new decimal[]{100,200,300};
		Sum(20,30);
	}
}
