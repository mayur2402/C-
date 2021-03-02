using System;
class Student
{
	public string Name;
	public string Email;
	public string Course;
	public int Phone;
	public static int Count=0;
	public enum University
	{
		SavitriBaiPhule,Mumbai,delhi,Oxfort,Kolkata
	}
	public University univ;
	public enum Subject
	{
		Physics,Chemistry,Maths,Biology,ComputerScience,Electronics
	}
	public Subject sub;
	public Student()
	{
	}
	public Student(string Name,string Email,string Course,int Phone,University univ,Subject sub)
	{
		this.Name=Name;
		this.Email=Email;
		this.Course=Course;
		this.Phone=Phone;
		this.univ=univ;
		this.sub=sub;
	}
	static void StudentCount()
	{
		Count++;
	}
	public void Display()
	{
		Console.WriteLine("Name of Student is {0} Email is {1} Phone Number is {2} University in which he/she study is {3} and subject are {4}",this.Name,this.Email,this.Phone,Student.University.delhi,Student.Subject.Physics);
	}
/*	public string NAME
	{
		get
		{
			return this.Name;
		}
		set
		{
			this.Name=Name;
		}
	}
	public string EMAIL
	{
		get
		{
			return this.Email;
		}
		set
		{
			this.Email=Email;
		}
	}
	public string COURSE
	{
		get
		{
			return this.Course;
		}
		set
		{
			this.Course=Course;
		}
	}
	public int PHONE
	{
		get
		{
			return this.Phone;
		}
		set
		{
			this.Phone=Phone;
		}
	}*/
}
class StudentTest
{
	static void Main()
	{
		Student stu=new Student();
		Student stu1=new Student();
//		Student stu2=new Student("Aniket","aniket@gmail.com");
//		Student stu3=new Student("Devarshi","devarshi@gmail.com","BCS");
		Student stu4=new Student("Sagar","sagar@gmail.com","BCS",88767689,"delhi","Physics");
		stu.Display();
		stu1.Display();
		stu4.Display();
	}
}
