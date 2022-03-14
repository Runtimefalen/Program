using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            int m = 7;
            int n = 7;
            int count = m * n;
            int num = 1;
            Spiralling(num, count, 0);
            Spiralling(num + 2, count, 1);
        }

        private static string Spiralling(int num, int count, int temp)
        {
            string str = null;

            for (int i = num; i <= count; i++)
            {

                if (i % 2 == 0)
                {
                    str = (i - (1 - temp)).ToString();
                    Console.Write("{0, 2}  ", str);
                    str = (i - temp).ToString();
                    Console.Write("{0, 2} | ", str);
                    i += 3;
                }
            }
            Console.WriteLine();
            return str;
        }


    }
}