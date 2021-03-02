using System;
class Generic
{
/*	public bool Compare(object a,object b)
	{
		if(a.Equals(b))
			return true;
		return false;
	}*/
	public bool Compare<T>(T a,T b)
	{
		if(a.Equals(b))
			return true;
		return false;
	}
	static void Main()
	{
		Generic obj = new Generic();
		bool result;
//		result = obj.Compare(10.19,10.19f);
		result = obj.Compare<double>(10.19,10.19);
		Console.WriteLine(result);
//		result=obj.Compare(11.1f,11.1 );
		result=obj.Compare<float>(11.1f,11.1f);
		Console.WriteLine(result);
//		result=obj.Compare("Sagar","Aniket");
		result=obj.Compare<string>("Sagar","Aniket");
		Console.WriteLine(result);
	}
}
