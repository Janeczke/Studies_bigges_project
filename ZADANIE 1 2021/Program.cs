using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE_1_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (i<20&&j<20)
                    {
                        Console.Write("*");

                    }
                    else if (i >= 20 && j < 20)
                    {
                        Console.Write("@");
                    }
                    else if (i < 20 && j >= 20)
                    {
                        Console.Write("#");
                    }
                    else if (i >= 20 && j >= 20)
                    {
                        Console.Write("+");
                    }
                    else if (i >= 20 && j >= 20)
                    {
                        Console.Write("&");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
