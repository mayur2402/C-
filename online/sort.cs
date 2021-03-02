using System;
using System.Collections.Generic;
public class Customer : IComparable <Customer>
{
	public int Cid { get; set; }
	public string Name { get; set; }
	public double Balance { get;set; }

	public int CompareTo(Customer other)
	{
		if(this.Cid > other.Cid)
			return 1;
		else if(this.Cid < other.Cid)
			return -1;
		else
			return 0;
	}
}
class CompareCustomer : IComparer <Customer>
{
	public int Compare(Customer C1, Customer C2)
	{
		if(C1.Balance > C2.Balance)
			return 1;
		else if(C1.Balance < C2.Balance)
			return -1;
		else
			return 0;
	}
} 
class TestCustomer
{
	static void Main()
	{
		Customer c1 = new Customer { Cid = 101, Name = "Sagar",Balance = 20000};
		Customer c2 = new Customer { Cid = 122, Name = "Chirag",Balance = 1000};
		Customer c3 = new Customer { Cid = 103, Name = "Aniket",Balance = 22000};
		Customer c4 = new Customer { Cid = 114, Name = "Devarshi",Balance = 3000};
		Customer c5 = new Customer { Cid = 105, Name = "Shardul",Balance = 24000};

		List<Customer> Cust = new List<Customer>(){c1,c2,c3,c4,c5};
		Console.WriteLine("Before Sorting");
		foreach(Customer C in Cust)
		{
			Console.WriteLine(C.Cid+"\t"+C.Name+"\t"+C.Balance);
		}

		Cust.Sort();
		Console.WriteLine("After Sorting by id");
		foreach(Customer C in Cust)
		{
			Console.WriteLine(C.Cid+"\t"+C.Name+"\t"+C.Balance);
		}
		CompareCustomer obj = new CompareCustomer();
		Cust.Sort(obj);
		Console.WriteLine("After Sorting by Balance");
		foreach(Customer C in Cust)
		{
			Console.WriteLine(C.Cid+"\t"+C.Name+"\t"+C.Balance);
		}
	
	}
}
