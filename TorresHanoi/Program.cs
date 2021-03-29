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
                Console.WriteLine("Hanoi Towers");
                Console.WriteLine("Iterative (i) or recursive (r)?");
                line = Console.ReadLine();
                if(line == "i")
                {
                    Console.WriteLine("How many discs?");
                    line = Console.ReadLine();

                    discs = Int32.Parse(line);

                    if (discs > 0)
                    {
                        done = true;
                        Pila ini = new Pila("ini");
                        Pila fin = new Pila("fin");
                        Pila aux = new Pila("aux");
                        for (int i = 0; i < discs; i++)
                        {
                            ini.push(new Disco(discs - i));
                        }
                        Hanoi hanoi = new Hanoi();
                        int movimientos = hanoi.iterativo(discs, ini, fin, aux);

                        double estimated = Math.Pow(2, discs) - 1;

                        Console.WriteLine("Estimated movements: " + estimated);

                        Console.WriteLine("Total movements: " + movimientos);
                    }
                } else if(line == "r")
                {
                    Console.WriteLine("How many discs?");
                    line = Console.ReadLine();

                    discs = Int32.Parse(line);

                    if (discs > 0)
                    {
                        done = true;
                        Pila ini = new Pila("ini");
                        Pila fin = new Pila("fin");
                        Pila aux = new Pila("aux");
                        for (int i = 0; i < discs; i++)
                        {
                            ini.push(new Disco(discs - i));
                        }
                        Hanoi hanoi = new Hanoi();
                        int movimientos = hanoi.recursivo(discs, ini, fin, aux);

                        double estimated = Math.Pow(2, discs) - 1;

                        Console.WriteLine("Estimated movements: " + estimated);

                        Console.WriteLine("Total movements: " + movimientos);
                    }
                }
                
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
