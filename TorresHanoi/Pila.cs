using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresHanoi
{
    class Pila
    {
        public int Size { get; set; }

        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
            Top = 0;
            Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d.Valor;
            Size = Elementos.Count();
        }

        public Disco pop()
        {
            Elementos.RemoveAt(Elementos.Count - 1);

            Size = Elementos.Count();

            if (!isEmpty())
            {
                Top = Elementos.ElementAt(Elementos.Count - 1).Valor;
            }
            else
            {
                Top = 0;
            }

            return null;
        }

        public bool isEmpty()
        {
            if (Size <= 0)
            {
                return true;
            }

            return false;

        }

    }
}
