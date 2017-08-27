using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamondShape
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, num;
            while (true)
            {
                Console.Write("Enter a number between 1 to 9 : ");
                num = Convert.ToInt32(Console.ReadLine());
                if ((num <= 9) && (num > 0))
                {
                    break;
                }
                Console.WriteLine("Wrong Input!! Please enter a number between 1 to 9");
            }
            for (a = 1; a <= num; a++)
            {
                for (b = num; b >= a; b --)
                {
                    Console.Write(' ');
                }
                for (b = 1; b <= a; b++)
                {
                    Console.Write('*');
                }
                for (b = 1; b <= a; b++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for (a = 1; a <= num; a++)
            {
                for (b = 0; b < a; b++)
                {
                    Console.Write(' ');
                }
                for (b = num; b >= a; b --)
                {
                    Console.Write('*');
                }
                for (b = num; b >= a; b --)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    }

