/*Declare several variables by selecting for each one of them the most
appropriate of the types sbyte , byte , short , ushort , int , uint , long
and ulong in order to assign them the following values: 52,130; -115;
4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
1990; 123456789123456789*/
class Q1
{
	public static void Main()
	{
		byte a=52,a1=97,a2=130,a3=224,a4=000,a5=112,a6=000;
		sbyte a7=-44,a8=-115;
		ushort a9=970,a10=700;
		short a11=-1000,a12=-10000;
		int a13=4825932,a14=20000,a15=1990;
		long a16=123456789123456789;
		System.Console.Write("\nbyte "+a+"\t"+a1+"\t"+a2+"\t"+a3+"\t"+a4+"\t"+a5+"\t"+a6);
		System.Console.Write("\nsign byte "+a7+"\t"+a8);
		System.Console.Write("\nunsigned short "+a9+"\t"+a10);
		System.Console.Write("\nshort "+a11+"\t"+a12);
		System.Console.Write("\ninteger "+a13+"\t"+a14+"\t"+a15);
		System.Console.Write("\nLong "+a16);
	}
}
