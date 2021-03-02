/*Which of the following values can be assigned to variables of type float ,
double and decimal : 5, -5.01, 34.567839023; 12.345; 8923.1234857;
3456.091124875956542151256683467?*/
class Q2
{
	public static void Main()
	{
		float f1=-5.01f,f2=12.345f;
		double d1=34.567839023,d2=3456.091124875956542151256683467,d3=8923.1234857;
		decimal dd1=5;
		System.Console.Write("\nFloat number "+f1+"\t"+f2);
		System.Console.Write("\nDouble number "+d1+"\t"+d2+"\t"+d3);
		System.Console.Write("\nDecimal number "+dd1);
	}
}
