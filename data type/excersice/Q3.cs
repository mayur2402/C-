/*Initialize a variable of type int with a value of 256
hexadecimal format (256 is 100 in a numeral system with base 16)*/
class Q3
{
	public static void Main()
	{
		int x=0x1;
		while(x<0x100)
		{
			System.Console.Write(x+"\t");
			x++;
		}
	}
}
