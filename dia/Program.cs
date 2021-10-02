using System;

namespace dia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Введите нечетное число:");
                n = Math.Abs(int.Parse(Console.ReadLine()));
            } while (n % 2 == 0);
            int m = n / 2,
                c = -1;
            bool nap = true;
            for(int i = 0; i < n; i++)
            {
                string s = "";
                if (nap)
                {
                    for (int j = 0; j < m; j++)
                    {
                        s += " ";
                    }
                    m--;
                    s += "*";
                    for (int j = 0; j < c; j++)
                    {
                        s += " ";
                    }
                    if (c > 0)
                        s += "*";
                    c += 2;
                }
                else
                {
                    for (int j = m; j >= 0; j--)
                    {
                        s += " ";
                    }
                    m++;
                    s += "*";
                    for (int j = c; j > 0; j--)
                    {
                        s += " ";
                    }
                    if (c > 0)
                        s += "*";
                    c -= 2;
                }
                if (m < 0)
                {
                    nap = false;
                    m = 0;
                    c -= 4;
                }
                Console.WriteLine(s);
            }
        }
    }
}
