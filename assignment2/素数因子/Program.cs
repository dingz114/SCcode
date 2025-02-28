namespace 素数因子
{
    internal class Program
    {
        static bool isPrime(int data)
        {
            double maxValue = Math.Sqrt(data);
            for (int i = 2; i <= maxValue; i++)
            {
                if (data % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter data:");
            string s = Console.ReadLine();
            int data = int.Parse(s);
            double maxValue = Math.Sqrt(data);
            for (int i = 2; i <= maxValue; i++)
            {
                if (data % i == 0 && isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
