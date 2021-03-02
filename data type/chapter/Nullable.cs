class Nullable
{
	public static void Main()
	{
		int a=10;
		int ? b=a;
		System.Console.Write(b);
		b=a.value;
		System.Console.Write(b.HasValue);
	}
}
