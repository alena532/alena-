using System;
namespace alena2
{
    class Program
    {
        static void Show(char[,] a)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 1 || j == 3)
                    {
                        a[i, j] = '|';
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        if (a[i, j] != 'x' && a[i, j] != 'o')
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(a[i, j]);
                        }
                    }
                    if (i == 1 || i == 3)
                    {
                        a[i, j] = '-';
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        if (a[i, j] != 'x' && a[i, j] != 'o')
                        {
                            a[i, j] = ' ';
                        }
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
        static void MoveOptions()
        {
            Console.WriteLine("Move options:");
            Console.WriteLine("-1-|-2-|-3-");
            Console.WriteLine("-4-|-5-|-6-");
            Console.WriteLine("-7-|-8-|-9-");
        }
        static bool YourMove(char[,] a, int count)
        {
            char temp;
            if (count % 2 != 0)
            {
                temp = 'x';
            }
            else
            {
                temp = 'o';
            }
            int number;
            bool result;
            do
            {
                string temp1 = Console.ReadLine();
                result = Int32.TryParse(temp1, out number);
                if (result == false)
                {
                    Console.WriteLine("Mistake.Try again!");
                }
            } while (result == false);
            if (number > 9)
            {
                Console.WriteLine("Mistake!");
                return false;
            }
            switch (number)
            {
                case 1:
                    if (a[0, 0] == 'x' || a[0, 0] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[0, 0] = temp;
                    break;
                case 2:
                    if (a[0, 2] == 'x' || a[0, 2] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[0, 2] = temp;
                    break;
                case 3:
                    if (a[0, 4] == 'x' || a[0, 4] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[0, 4] = temp;
                    break;
                case 4:
                    if (a[2, 0] == 'x' || a[2, 0] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[2, 0] = temp;
                    break;
                case 5:
                    if (a[2, 2] == 'x' || a[2, 2] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[2, 2] = temp;
                    break;
                case 6:
                    if (a[2, 4] == 'x' || a[2, 4] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[2, 4] = temp;
                    break;
                case 7:
                    if (a[4, 0] == 'x' || a[4, 0] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[4, 0] = temp;
                    break;
                case 8:
                    if (a[4, 2] == 'x' || a[4, 2] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[4, 2] = temp;
                    break;
                case 9:
                    if (a[4, 4] == 'x' || a[4, 4] == 'o')
                    {
                        Console.WriteLine("Mistake!");
                        return false;
                    }
                    a[4, 4] = temp;
                    break;
            }
            return true;
        }
        static bool Check(char[,] a)
        {
            if (a[0, 2] == a[0, 0] && a[0, 2] == a[0, 4] && a[0, 0] != ' ')
            {
                return true;
            }
            else if (a[2, 0] == a[2, 2] && a[2, 2] == a[2, 4] && a[2, 0] != ' ')
            {
                return true;
            }
            else if (a[4, 0] == a[4, 2] && a[4, 2] == a[4, 4] && a[4, 0] != ' ')
            {
                return true;
            }
            else if (a[0, 0] == a[2, 0] && a[0, 0] == a[4, 0] && a[0, 0] != ' ')
            {
                return true;
            }
            else if (a[0, 2] == a[2, 2] && a[2, 2] == a[4, 2] && a[0, 2] != ' ')
            {
                return true;
            }
            else if (a[0, 4] == a[2, 4] && a[2, 4] == a[4, 4] && a[0, 4] != ' ')
            {
                return true;
            }
            else if (a[0, 0] == a[2, 2] && a[2, 2] == a[4, 4] && a[0, 0] != ' ')
            {
                return true;
            }
            else if (a[0, 4] == a[2, 2] && a[2, 2] == a[4, 0] && a[0, 4] != ' ')
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string player1, player2;
            int count = 1;
            char[,] a = new char[5, 5];
            Console.WriteLine("Enter name of first player:");
            player1 = Console.ReadLine();
            Console.WriteLine("Enter name of second player:");
            player2 = Console.ReadLine();
            MoveOptions();
            do
            {
                if (count == 10)
                {
                    Console.WriteLine("Draw!!!");
                    Environment.Exit(0);
                }
                if (count % 2 != 0)
                {
                    Console.WriteLine($"{player1} Enter number:");
                }
                else
                {
                    Console.WriteLine($"{player2} Enter number:");
                }
                if (!YourMove(a, count))
                {
                    while (!YourMove(a, count))
                    {
                        YourMove(a, count);
                    }
                }
                Show(a);
                count++;
            } while (!Check(a));
            if (count % 2 != 0)
            {
                Console.WriteLine($"{player2} YOU WIN!!!");
            }
            else
            {
                Console.WriteLine($"{player1} YOU WIN!!!");
            }
            if (count == 10)
            {
                Console.WriteLine("Draw!!!");
            }
        }
    }
}


