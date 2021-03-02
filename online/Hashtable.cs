using System;
using System.Collections;
class HashTable
{
	static void Main()
	{
		Hashtable HT = new Hashtable();
		HT.Add("Eid",101);
		HT.Add("Ename","Aniket");
		HT.Add("EJob","Manager");
		HT.Add("EPhone",9877587687);
		foreach(object Key in HT.Keys)
		{
			Console.WriteLine(Key);
		}
		foreach(object Value in HT.Values)
		{
			Console.WriteLine(Value);
		}
	}
}
