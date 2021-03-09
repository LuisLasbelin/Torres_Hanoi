using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int discs;
            string line;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("How many discs?");
                line = Console.ReadLine();

                discs = Int32.Parse(line);

                if (discs > 0)
                {
                    done = true;
                    Pila ini = new Pila();
                    Pila fin = new Pila();
                    Pila aux = new Pila();
                    for (int i = 0;  i < discs; i++)
                    {
                        ini.push(new Disco(discs - i));
                    }
                    Hanoi hanoi = new Hanoi();
                    int movimientos = hanoi.iterativo(discs, ini, fin, aux);

                    Console.WriteLine("Total movements.");
                    Console.WriteLine(movimientos);
                }
                else
                {
                    Console.WriteLine("Write a number.");
                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
