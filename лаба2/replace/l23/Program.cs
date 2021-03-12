using System;
namespace replace
{
    class Program
    {
        static bool check(char a)
        {
            if(a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] asci= new int[s.Length] ;
            char[] temp = new char[s.Length];
            for(int i = 0; i < s.Length; i++)
            {
                if (!(s[i] >= 'a' && s[i] <= 'z'))
                {
                    Console.WriteLine("Mistake!");
                    System.Environment.Exit (2);
                }
            }
            for (int i = s.Length-1; i >=0; i--)
            {
                if (i == 0)
                {
                    asci[i] = Convert.ToInt16(s[i]);
                    break;
                }
                if (check(s[i-1]) )
                {
                    if (s[i] == 'z')
                    {
                        asci[i]= Convert.ToInt16('a');
                    }
                    else
                    {
                        asci[i] = Convert.ToInt16(s[i]) + 1;
                    }
                }
                else
                {
                    asci[i] = Convert.ToInt16(s[i]);
                }
            }
            for(int i = 0; i < asci.Length; i++)
            {
                temp[i] = Convert.ToChar(asci[i]);
            }
            Console.WriteLine(temp);
        }
    }
}
