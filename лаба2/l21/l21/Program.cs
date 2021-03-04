using System;
using System.Linq;
namespace l21
{
    class Program
    {
        static string str;
        static void reversestring()
        {
            str += ' ';
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;

                }
            }
            string[] temp = new string[count];
            int index = 0;
            int prev = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    for (; prev < i; prev++)

                    {
                        temp[index] += str[prev];

                    }
                    index++;
                    prev += 1;

                }
            }
            for (int i = 0; i < count / 2; i++)
            {
                string next = temp[i];
                temp[i] = temp[count - 1 - i];
                temp[count - 1 - i] = next;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(temp[i]);
                Console.Write(" ");
            }
        }
        static void Main(string[] args)
        {
            str = Console.ReadLine();
            reversestring();
        }
    }
}
