using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.Cola_Lista
{
    class ColaConLista
    {
        protected Nodo frente;
        protected Nodo fin;
        public int sizee;

        //constructor:crear la cola vacia
        public ColaConLista()
        {
            frente = fin = null;
        }

        //verificar si la cola esta vacia
        public bool colaVacia()
        {
            return (frente == null);
        }

        //insertar: pone elemento por el final de la cola
        public void insertar(Object elemento)
        {
            Nodo a;
            a = new Nodo(elemento);
            if (colaVacia())
            {
                frente = a;
                sizee++;
            }
            else
            {
                fin.siguiente = a;
            }
            fin = a;
        }

        //quitar un elemento
        public Object quitar()
        {
            Object aux;
            if (!colaVacia())
            {
                sizee--;
                aux = frente.elemento;
                frente = frente.siguiente;
            }
            else
            {
                throw new Exception("Error porque la cola esta vacia");
            }
            return aux;
        }

        //vaciar la cola, o liberar todos los nodos
        public void borrarCola()
        {
            for (; frente != null;)
            {
                frente = frente.siguiente;
            }
        }

        //devolver el valor que esta al frente de la cola
        public Object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error: la cola esta vacia");
            }
            return (frente.elemento);
        }

        public Object finalcolaConLista()
        {
            if (!colaVacia())
            {
                return fin;
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

        public int size()
        {
            return sizee;
        }
    }
}
