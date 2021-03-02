using System;
namespace number
{
	class Q1
	{
		public static void Main()
		{
			Console.WriteLine("Enter three numbers");
			int n1=int.Parse(Console.ReadLine());
			int n2=int.Parse(Console.ReadLine());
			int n3=int.Parse(Console.ReadLine());
			if((n3<n2)&&(n3<n1))
			{
				int temp=n1;
				n1=n3;
				n3=temp;
				if(n2>n3)
				{
					int temp1=n2;
					n2=n3;
					n3=temp1;
				}
				Console.WriteLine(n1+"\t"+n2+"\t"+n3);
			}
			else if((n2<n3)&&(n2<n1))
			{
				int temp=n1;
				n1=n2;
				n2=temp;
				if(n1>n3)
				{
					int temp1=n1;
					n2=n1;
					n1=temp1;
				}
				Console.WriteLine(n1+"\t"+n2+"\t"+n3);
			}
			else
			{
				Console.WriteLine(n1+"\t"+n2+"\t"+n3);
			}
		}
	}
}
