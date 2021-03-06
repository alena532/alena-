uusing System;
namespace replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            int size = a.Length;
            int[] asci = new int[size];
            bool flag = false;
            for (int i = 0; i < size; i++)
            {
                if (flag == true)
                {
                    flag = false;
                    continue;
                }
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    if (i == size - 1)
                    {
                        asci[i] = Convert.ToInt16(a[i]);
                        break;
                    }
                    asci[i] = Convert.ToInt16(a[i]);
                    if (a[i + 1] == 'z')
                    {
                        a[i + 1] = 'a';
                        asci[i + 1] = Convert.ToInt16(a[i + 1]);
                        flag = true;
                    }
                    else
                    {
                        asci[i + 1] = Convert.ToInt16(a[i + 1]) + 1;
                        flag = true;
                    }
                    continue;
                }
                else
                {
                    asci[i] = Convert.ToInt16(a[i]);
                }
            }
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToChar(asci[i]);
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i]);
            }
        }
    }
}
