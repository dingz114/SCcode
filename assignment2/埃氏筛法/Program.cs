namespace 埃氏筛法
{
    internal class Program
    {
        static void ai_sieve()
        {
            int[] array = new int[99];
            for (int i = 2; i < 101; i++)
            {
                array[i - 2] = i;
            }
            for (int i = 2; i <= Math.Sqrt(array.Length); i++)
            {
                for (int j = i + 1; j < 101; j++)
                {
                    if (j % i == 0)
                    {
                        array[j - 2] = 0;
                    }
                }
            }
            foreach (int data in array)
            {
                if (data != 0)
                {
                    Console.Write($"{data} ");
                }
            }
        }
        static void Main(string[] args)
        {
            ai_sieve();
        }
    }
}
