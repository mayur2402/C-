/*Declare two variables of type string and give them values "Hello" and
"World". Assign the value obtained by the concatenation of the two
variables of type string (do not miss the space in the middle) to a
variable of type object . Declare a third variable of type string and
initialize it with the value of the variable of type object (you should use
type casting).*/
class Q4
{
	public static void Main()
	{
		string s1="hello";
		string s2="world";
		object o1=s1+" "+s2;
		string s3=(string)o1;
		System.Console.Write("\n"+s1+"\n"+s2+"\n"+o1+"\n"+s3);
	}
}
	
