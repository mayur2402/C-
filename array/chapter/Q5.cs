using System;
class Q5
{
	static void Main()
	{
		int[,] matrix={
				{1,2,3,4,5,6},
				{6,5,4,3,2,1},
				{9,8,7,6,5,4},
				{6,7,5,8,9,0}
			      };
		long sum=0;
		int row=0;
		int col=0;
		long max=0;
		for(int i=0;i<matrix.GetLength(0)-1;i++)
		{
			for(int j=0;j<matrix.GetLength(1)-1;j++)
			{
				sum=matrix[i,j]+matrix[i,j+1]+matrix[i+1,j]+matrix[i+1,j+1];
				if(sum<max)
				{
					max=sum;
					row=i;
					col=j;
				}
			}
		}
		Console.WriteLine("Maximum sum of matrix is {0}",sum);
		Console.WriteLine("Matrix is");
		Console.Write(matrix[row,col]+"\t"+matrix[row+1,col]
+"\n"+matrix[row,col+1]+"\t"+matrix[row+1,col+1]);
	}
}
