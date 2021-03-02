using System;

namespace math {
	class Maths {
		public static void Main(string[] args) {
			Console.WriteLine("Math.Max(20,30)\t"+Math.Max(20,30));
			Console.WriteLine("Math.Abs(-23.34)\t"+Math.Abs(-23.34));
			Console.WriteLine("Enter your name");
			string name = Console.ReadLine();
			Console.WriteLine($"Your name is {name}");
			Console.WriteLine(name[2]);
		}
	}
}