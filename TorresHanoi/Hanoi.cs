using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresHanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (!a.isEmpty() && !b.isEmpty())
            {
                // Mover el de a al b
                if (a.Top < b.Top)
                {
                    b.push(a.Elementos.ElementAt(a.Elementos.Count - 1));
                    a.pop();
                    Console.WriteLine("Moved from " + a.Name + " to " + b.Name);
                }
                // Mover el de b al a
                else
                {
                    a.push(b.Elementos.ElementAt(b.Elementos.Count - 1));
                    b.pop();
                    Console.WriteLine("Moved from " + b.Name + " to " + a.Name);
                }
            }
            else if (a.isEmpty() && b.isEmpty())
            {
                // nada
                Console.WriteLine("Can't move");
            }
            else if (a.isEmpty())
            {
                // Mover el de b al a
                a.push(b.Elementos.ElementAt(b.Elementos.Count - 1));
                b.pop();
                Console.WriteLine("Moved from " + b.Name + " to " + a.Name);
            }
            else if (b.isEmpty())
            {
                // Mover el de a al b
                b.push(a.Elementos.ElementAt(a.Elementos.Count - 1));
                a.pop();
                Console.WriteLine("Moved from " + a.Name + " to " + b.Name);
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if (n % 2 != 0)
            {
                while (true)
                {
                    mover_disco(ini, fin);
                    m++;
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                    mover_disco(ini, aux);
                    m++;
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                    mover_disco(aux, fin);
                    m++;
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                }
            }
            else if (n % 2 == 0)
            {
                while (fin.Size < n)
                {
                    mover_disco(ini, aux);
                    m++;
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                    mover_disco(ini, fin);
                    m++;
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                    mover_disco(aux, fin);
                    m++;
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                }
            }
            return m;
        }

    }
}
