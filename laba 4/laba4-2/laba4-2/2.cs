using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace laba4_2
{
    class Program
    {
        [DllImport("MyLib.dll",CallingConvention=CallingConvention.Cdecl) ]
        public static extern int Add(int a, int b);
        [DllImport("MyLib.dll")]
        public static extern int Supply(int a, int b);
        [DllImport("MyLib.dll")]
        public static extern int Subtection(int a, int b);
        [DllImport("MyLib.dll")]
        public static extern int Division(int a, int b);
        static void Main(string[] args)
        {
            int a, b;
            while (true)
            {
                do
                {
                    Console.WriteLine("Enter first number");
                } while (!Int32.TryParse(Console.ReadLine(),out a));
                do
                {
                    Console.WriteLine("Enter second number");
                } while (!Int32.TryParse(Console.ReadLine(),out b));
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Supply");
                Console.WriteLine("3.Subtrection");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Finish program");
                int number;
                do
                {
                    Console.WriteLine("Choose number:");
                } while (!Int32.TryParse(Console.ReadLine(), out number)&& number>=1 && number<=5 );
                switch (number)
                {
                    case 1:
                       Console.WriteLine( MyLib.Class1.Add(a, b));
                        break;
                    case 2:
                        Console.WriteLine(MyLib.Class1.Multiply(a, b));
                        break;
                    case 3:
                       Console.WriteLine( MyLib.Class1.Subtrac(a, b));
                        break;
                    case 4:
                       Console.WriteLine( MyLib.Class1.Divide(a, b));
                        break;
                    case 5:
                        return;


                        
                }

            }
        }
    }
}
