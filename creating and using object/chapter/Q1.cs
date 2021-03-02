using System;
public class Cat
{
	private string name;
	private string color;
	
	public string Name
	{
		get
		{
			return this.name;
		}
		set
		{
			this.name=value;
		}
	}
	public string Color
	{
		get
		{
			return this.color;
		}
		set
		{
			this.color=value;
		}
	}
	public Cat()
	{
		this.name="Pailwan";
		this.color="Grey";
	}
	public Cat(string name,string color)
	{
		this.name=name;
		this.color=color;
	}
	public void SayMaeu()
	{
		Console.WriteLine("Cat {0} say Maeuuuu whose color is {1}",this.name,this.color);
	}
	static void Main()
	{
		Cat first=new Cat();
//		first.name="tony";
//		first.color="Pink";
		first.SayMaeu();
		Cat second=new Cat("Boka","Black");
		second.SayMaeu();
		Console.WriteLine("Cat {0} is {1}",second.Name,second.Color);
	}
}
