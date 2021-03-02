using System;
class Q3
{
	public static void Main()
	{
		int[,] matrix={
				{1,2,3,4},
				{5,6,7,8}
			     };
		Console.WriteLine("Rows are {0} columns are {1}",matrix.GetLength(0),matrix.GetLength(1));
		for(int i=0;i<matrix.GetLength(0);i++)
		{
			for(int j=0;j<matrix.GetLength(1);j++)
			{
				Console.Write(matrix[i,j]+"\t");
			}
			Console.WriteLine();
		}
	}
}
