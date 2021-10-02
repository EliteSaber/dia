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
            int half = n / 2,
                center = -1;
            string s = "";
            for (int i = 0; i < half + 1; i++)
            {
                for (int j = 0; j < half - i; j++)
                    s += " ";
                s += "*";
                for(int j = 0; j < center; j++)
                    s += " ";
                center += 2;
                if (i > 0)
                    s += "*";
                s += "\r\n";
            }
            center -= 4;
            for (int i = half; i > 0; i--)
            {
                for (int j = half - i; j >= 0; j--)
                    s += " ";
                s += "*";
                for (int j = center; j > 0; j--)
                    s += " ";
                center -= 2;
                if (i > 1)
                    s += "*";
                s += "\r\n";
            }
            Console.WriteLine(s);
        }
    }
}
