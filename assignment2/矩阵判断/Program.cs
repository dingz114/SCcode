using System;
namespace 矩阵判断
{
    internal class Program
    {
        static bool isToplic(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] != array[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵的行数:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入矩阵的列数:");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"请输入第{i + 1}行的元素:");
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = int.Parse(inputs[j]);
                }
            }
            if (isToplic(matrix))
            {
                Console.WriteLine("该矩阵是托普利茨矩阵");
            }
            else
            {
                Console.WriteLine("该矩阵不是托普利茨矩阵");
            }
            
        }
    }
}
