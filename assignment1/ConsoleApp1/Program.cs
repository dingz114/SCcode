using System;

namespace ConsoleApp1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("请输入第一个数字:");
            s=Console.ReadLine();
            double num1 = Double.Parse(s);

            Console.WriteLine("请输入第二个数字:");
            s = Console.ReadLine();
            double num2 = Double.Parse(s);

            Console.WriteLine("请输入运算符 (+, -, *, /):");
            string choice = Console.ReadLine();

            double result = 0;
            switch (choice)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("除数不能为零!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("运算符无效!");
                    return;
            }

            Console.WriteLine($"结果: {result}");
        }
    }
}
   