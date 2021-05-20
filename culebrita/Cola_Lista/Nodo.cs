using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.Cola_Lista
{
    class Nodo
    {
        public Object elemento;
        public Nodo siguiente;

        public Nodo(Object x)
        {
            elemento = x;
            siguiente = null;
        }
    }
}
