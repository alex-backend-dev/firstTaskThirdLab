using System;

namespace firstTaskThirdLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите точность: ");
            double precision = double.Parse(Console.ReadLine());

            Console.Write("Введите значение \"x\": ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Сумма равна: " + GetSum(x, precision));

            Console.ReadLine();
        }

        public static double GetSum(double x, double precision)
        {
            double sum = 0;
            int n = 0;

            while (Math.Abs(Math.Pow(-1, n) * (Math.Pow(x, (2 * n + 1))) / GetFactorial(2 * n + 1)) > precision)
            {
                sum+= Math.Pow(-1, n) * (Math.Pow(x, (2 * n + 1)) / GetFactorial(2 * n + 1));

                n++;
            }

            return sum;
        }

        public static int GetFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * GetFactorial(n - 1);
        }
    }
}
