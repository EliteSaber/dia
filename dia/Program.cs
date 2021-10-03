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
            string s = "";
            for (int i = 1; i <= half + 1; i++)
            {
                for (int j = 1; j <= half + 1 - i; j++)
                    s += " ";
                s += "*";
                if (i > 1)
                {
                    for (int j = 1; j <= 2 * i - 3; j++)
                        s += " ";
                    s += "*";
                }
                s += "\r\n";
            }
            for (int i = half; i > 0; i--)
            {
                for (int j = 1; j <= half + 1 - i; j++)
                    s += " ";
                s += "*";
                if (i > 1)
                {
                    for (int j = 1; j <= 2 * i - 3; j++)
                        s += " ";
                    s += "*";
                }
                s += "\r\n";
            }
            Console.WriteLine(s);
        }
    }
}
