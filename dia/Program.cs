using System;

namespace dia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool isNum;
            do
            {
                Console.Write("Введите нечетное число:");
                string num = Console.ReadLine();
                isNum = int.TryParse(num, out n);
                if (isNum)
                {
                    n = Math.Abs(n);
                    isNum = n % 2 != 0;
                    isNum = isNum && n < 80;
                }
            } while (!isNum);
            TwoCycles(n);
        }
        static void TwoCycles(int n)
        {
            int half = n / 2;
            for (int i = 1; i <= half + 1; i++)
                Print(i, half);
            for (int i = half; i > 0; i--)
                Print(i, half);
        }
        static void Print(int i, int half)
        {
            string s = "";
            for (int j = 1; j <= half + 1 - i; j++)
                s += " ";
            s += "*";
            if (i > 1)
            {
                for (int j = 1; j <= 2 * i - 3; j++)
                    s += " ";
                s += "*";
            }
            Console.WriteLine(s);
        }
    }
}
