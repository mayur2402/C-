/*Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.*/
using System;
class Q4
{
	public static void Main()
	{
		Console.WriteLine("|0X{0,-10:x}| |{0,-10:f}| |{0,-10:f}|",234,234.56,-234.56);
	}
}


