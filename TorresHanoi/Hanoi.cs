using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresHanoi
{
    class Hanoi
    {

        int m = 0;

        /*TODO: Implementar métodos*/
        public int mover_disco(Pila a, Pila b)
        {
            if (!a.isEmpty() && !b.isEmpty())
            {
                // Mover el de a al b
                if (a.Top < b.Top)
                {
                    b.push(a.Elementos.ElementAt(a.Elementos.Count - 1));
                    a.pop();
                    Console.WriteLine("Moved from " + a.Name + " to " + b.Name);
                    return 1;
                }
                // Mover el de b al a
                else
                {
                    a.push(b.Elementos.ElementAt(b.Elementos.Count - 1));
                    b.pop();
                    Console.WriteLine("Moved from " + b.Name + " to " + a.Name);
                    return 1;
                }
            }
            else if (a.isEmpty() && b.isEmpty())
            {
                // nada
                Console.WriteLine("Can't move");
                return 0;
            }
            else if (a.isEmpty())
            {
                // Mover el de b al a
                a.push(b.Elementos.ElementAt(b.Elementos.Count - 1));
                b.pop();
                Console.WriteLine("Moved from " + b.Name + " to " + a.Name);
                return 1;
            }
            else if (b.isEmpty())
            {
                // Mover el de a al b
                b.push(a.Elementos.ElementAt(a.Elementos.Count - 1));
                a.pop();
                Console.WriteLine("Moved from " + a.Name + " to " + b.Name);
                return 1;
            }
            return 0;
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            
            if (n % 2 != 0)
            {
                while (true)
                {
                    m += mover_disco(ini, fin);
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                    m += mover_disco(ini, aux);
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                    m += mover_disco(aux, fin);
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
                    m += mover_disco(ini, aux);
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                    m += mover_disco(ini, fin);
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                    m += mover_disco(aux, fin);
                    if (ini.isEmpty() && aux.isEmpty())
                    {
                        break;
                    }
                }
            }
            return m;
        }

        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {

            if(n == 1)
            {
                // m es la cantidad de movimientos declarada al inicio de la clase Hanoi
                m += mover_disco(ini, fin);
            } else
            {
                // Se cambia el orden de las pilas y se vuelve a llamar recursivo()
                recursivo(n - 1, ini, aux, fin);
                // Siempre se mueven las pilas primera y segunda enviadas en las variables de entrada
                m += mover_disco(ini, fin);
                // Con esta llamada se tienen en cuenta todas las posibilidades de movimientos (ini,aux) (ini,fin) (fin,aux)
                recursivo(n - 1, aux, fin, ini);
            }

            return m;
        }
    }
}
