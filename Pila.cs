using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_analizador_sintactico
{
    class PilaElemen
    {
        public const int ERROR = -1;
        public const int IDENTIFICADOR = 0;
        public const int SIMBOLO = 1;
        public const int SIGNOPESO = 2;
        public const int E = 3;
        public const int INICIAL = 5;

        public int tipo;
        public String simbolo;

        public PilaElemen()
        {
            tipo = 5;
        }

        public String ToString()
        {
            return simbolo;
        }
    }

    class Terminal : PilaElemen
    {
        public Terminal(int id)
        {
            tipo = id;
            if (id == SIGNOPESO)
            {
                simbolo = "$";
            }
        }

        public Terminal(int id, String sim)
        {
            tipo = id;
            simbolo = sim;
        }
    }

    class NoTerminal : PilaElemen
    {
        public NoTerminal(int id, String sim)
        {
            tipo = id;
            simbolo = sim;
        }
    }

    class Estado : PilaElemen
    {
        public Estado(int id, String estado)
        {
            tipo = id;
            simbolo = estado;
        }
    }


    class Pila
    {
        LinkedList<PilaElemen> listaPila = new LinkedList<PilaElemen>();

        public Pila()
        {

        }

        public void push(PilaElemen x)
        {
            listaPila.AddLast(x);
        }

        public PilaElemen top()
        {
            return listaPila.First.Value;
        }

        public PilaElemen pop()
        {
            PilaElemen x = listaPila.First.Value;
            listaPila.Remove(x);

            return x;
        }

        public void vaciarPila()
        {
            listaPila.Clear();
        }

        public void mostrarPila()
        {
            foreach (PilaElemen dato in listaPila)
            {
                Console.Write(dato.ToString());
            }
            Console.WriteLine("\n");
        }
    }
}
