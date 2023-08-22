using System.Diagnostics;

namespace Taask03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Format = "The time taken is {0} ms \n";
            const string Format1 = "The number of 1s is {0}";

            Console.WriteLine("Please wait...\n");

            //

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            int count = 0;
            for (int i = 1; i < 100000000; i++)
            {
                string s = i.ToString();
                foreach (char c in s)
                {
                    if (c == '1')
                        count++;
                }
            }
            sw1.Stop();
            Console.WriteLine(Format1, count);
            Console.WriteLine(Format, sw1.ElapsedMilliseconds);

            //

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            count = 0;
            for (int i = 1; i < 100000000; i++)
            {
                int n = i;
                while (n > 0)
                {
                    if (n % 10 == 1)
                    {
                        count++;
                    }
                    n /= 10;
                }
            }
            sw2.Stop();
            Console.WriteLine(Format1, count);
            Console.WriteLine(Format, sw2.ElapsedMilliseconds);

            //

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            count = 0;
            for (int d = 0; d < 8; d++)
            {
                int powerOf10 = (int)Math.Pow(10, d);
                int nextPowerOf10 = powerOf10 * 10;
                int right = 0;
                int roundDown = (99999999 / nextPowerOf10) * nextPowerOf10;
                int roundUp = roundDown + nextPowerOf10;
                int digit = (99999999 / powerOf10) % 10;
                if (digit < 1)
                {
                    count += roundDown / 10;
                }
                else if (digit == 1)
                {
                    count += roundDown / 10 + right + 1;
                }
                else
                {
                    count += roundUp / 10;
                }
            }
            sw3.Stop();
            Console.WriteLine(Format1, count);
            Console.WriteLine(Format, sw3.ElapsedMilliseconds);
        }
    }
}