using System;
class Q3
{
	public static void Main()
	{
		Console.WriteLine("Enter number of rows");
		int row=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number of column");
		int col=int.Parse(Console.ReadLine());
		int[,] matrix=new int[row,col];
		Console.WriteLine("Enter elements");
		for(int i=0;i<row;i++)
		{
			for(int j=0;j<col;j++)
			{
				Console.Write("[{0},{1}]\t",i+1,j+1);
				matrix[i,j]=int.Parse(Console.ReadLine());
			}
		}
		Console.WriteLine("Matrix is");
		for(int i=0;i<row;i++)
		{
			for(int j=0;j<col;j++)
			{
				Console.Write(matrix[i,j]+"\t");
			}
			Console.WriteLine();
		}
	}
}
