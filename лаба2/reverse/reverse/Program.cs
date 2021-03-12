using System;
namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] another = s.Split(' ');
            Array.Reverse(another);
            for (int i = 0; i < another.Length; i++)
            {
                Console.Write(another[i]);
                Console.Write(" ");
            }
        }
    }
}
