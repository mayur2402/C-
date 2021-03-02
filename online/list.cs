using System;
using System.Collections.Generic         ;
public class Customer
{
	public int Cid { get; set; }
	public string Name { get; set; }
	public double Balance { get;set; }
}
class TestCustomer
{
	static void Main()
	{
		List<Customer> Cust = new List<Customer>();
		Customer c1 = new Customer { Cid = 101, Name = "Sagar",Balance = 20000};
		Customer c2 = new Customer { Cid = 102, Name = "Chirag",Balance = 21000};
		Customer c3 = new Customer { Cid = 103, Name = "Aniket",Balance = 22000};
		Customer c4 = new Customer { Cid = 104, Name = "Devarshi",Balance = 23000};
		Customer c5 = new Customer { Cid = 105, Name = "Shardul",Balance = 24000};
	
		Cust.Add(c1);
		Cust.Add(c2);
		Cust.Add(c3);
		Cust.Add(c4);
		Cust.Add(c5);
	
		foreach(Customer C in Cust)
		{
			Console.WriteLine(C.Cid+"\t"+C.Name+"\t"+C.Balance);
		}
	}
}
