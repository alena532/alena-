using System;
using System.Collections.Generic;
using System.Globalization;
namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<myFraction> fraction = new List<myFraction>();
            myFraction first = new myFraction("3/7");
            myFraction second = new myFraction("-11/4");
            myFraction third = new myFraction(56, 56);
            fraction.Add(first);
            fraction.Add(second);
            fraction.Add(third);
            myFraction fourth = myFraction.Parse("4/6");
            myFraction fifth = myFraction.Parse("4.767");
            myFraction another = fourth - fifth;
            Console.WriteLine(another.ToString("F"));
            Console.WriteLine(fifth.ToString());
            myFraction six = fifth;
            Console.WriteLine(six.Equals(fifth));
            Console.WriteLine(six.Equals(fourth));
            myFraction seventh = fourth + fifth;
            Console.WriteLine(seventh.ToString("D"));
            myFraction eight = seventh - six;
            myFraction ninth = eight / seventh;
            myFraction tenth = eight * seventh;
            myFraction eleventh = eight * seventh+first;
            double n =(double) first;
            double c = fourth.ToDouble(CultureInfo.CurrentCulture);
           
            double c1 =(double) fifth;
            Console.WriteLine(n);
            int a = (int)first;
            int b = Convert.ToInt16(first);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(fifth);
            Console.WriteLine(fourth);
            if (fifth > fourth)
            {
                Console.WriteLine("Correct");
            }
            Console.WriteLine(ninth.Equals(tenth));
            ninth = tenth;
            Console.WriteLine(ninth.Equals(tenth));
            Console.WriteLine(fifth.CompareTo(fourth));
            if (ninth == first)
            {
                Console.WriteLine("There are not equals");

            }
           
        }
    }
}
