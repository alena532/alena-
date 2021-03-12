using System;
namespace data
{
    class Program
    {
        static void Search(string STR)
        {
            int[] numbers = new int[10];
            for(int i = 0; i < 10; i++)
            {
                numbers[i] = 0;
            }
            for(int i = 0; i < STR.Length; i++)
            {
                if(STR[i]>='0'&& STR[i] <= '9')
                {
                    numbers[STR[i] - 48] += 1;
                }
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number {i}:" + numbers[i]);
            }
        }
        static void Main(string[] args)
        {
            string FirstString = DateTime.Now.ToString("d");
            string SecondString = DateTime.Now.ToString("F");
            Console.WriteLine(FirstString);
             Search(FirstString);
            Console.WriteLine(SecondString);
            Search(SecondString);
        }
    }
}
