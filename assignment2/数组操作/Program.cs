namespace 数组操作
{
    internal class Program
    {
        static void operation_to_array(int[] a)
        {
            int maxValue = a[0], minValue = a[0], total_num = 0;
            double average_num = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maxValue)
                {
                    maxValue = a[i];
                }
                if (a[i] < minValue)
                {
                    minValue = a[i];
                }
                total_num += a[i];
            }
            average_num = total_num / a.Length;
            Console.WriteLine($"maxValue:{maxValue}");
            Console.WriteLine($"minValue:{minValue}");
            Console.WriteLine($"total_num:{total_num}");
            Console.WriteLine($"average_num:{average_num}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组元素：");
            string input = Console.ReadLine(); 
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            operation_to_array(numbers);
        }
    }
}
