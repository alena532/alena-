using System;

namespace строки
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] amount = new int[10];
            string s;
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine(date);
            s = date.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '0':
                        amount[0]++;
                        break;
                    case '1':
                        amount[1]++;
                        break;
                    case '2':
                        amount[2]++;
                        break;
                    case '3':
                        amount[3]++;
                        break;
                    case '4':
                        amount[4]++;
                        break;
                    case '5':
                        amount[5]++;
                        break;
                    case '6':
                        amount[6]++;
                        break;
                    case '7':
                        amount[7]++;
                        break;
                    case '8':
                        amount[8]++;
                        break;
                    case '9':
                        amount[9]++;
                        break;
                }

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Amount of {i}:{amount[i]}\n");
            }

        }
    }
}
