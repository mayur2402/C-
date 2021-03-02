/*A given company has name, address, phone number, fax number, website and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.*/
using System;
class Q3
{
	public static void Main()
	{
		Console.WriteLine("Enter name of Company");
		string cname=Console.ReadLine();
		Console.WriteLine("Enter address of Company");
		string caddr=Console.ReadLine();
		Console.WriteLine("Enter phone number of company");
		long pno=long.Parse(Console.ReadLine());
		Console.WriteLine("Enter fax number of Company");
		long fno=long.Parse(Console.ReadLine());
		Console.WriteLine("Enter website of Company");
		string web=Console.ReadLine();
		Console.WriteLine("Enter details of manager");
		Console.WriteLine("Enter first name of manager");
		string fname=Console.ReadLine();
		Console.WriteLine("Enter surname of manager");
		string sname=Console.ReadLine();
		Console.WriteLine("Enter phone number of manager");
		long pno1=long.Parse(Console.ReadLine());
		Console.WriteLine("\nDetails of Company\n");
		Console.WriteLine("---------------------------------------");
		Console.WriteLine("name of company is {0}\naddress of company is {1}\nphone number of company is {2}\nfax number of company is {3}\nWebsite of company is {4}",cname,caddr,pno,fno,web);
		Console.WriteLine("---------------------------------------");
		Console.WriteLine("\nDetails of Manager\n");
		Console.WriteLine("---------------------------------------");
		Console.WriteLine("Name of Manager is {0}\nPhone number of manager is {1}",fname+" "+sname,pno1);
	}
}
