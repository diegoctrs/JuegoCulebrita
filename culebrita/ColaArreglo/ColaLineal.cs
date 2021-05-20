using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 999;
        protected int frente;
        public int sizee;

        protected Object[] ListaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            ListaCola = new object[MAXTAMQ];
        }

        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }

        //operaciones para trabajar con datos en la cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                ListaCola[++fin] = elemento;
                sizee++;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //quitar elemento de la cola
        public Object quitar()
        {
            if (!colaVacia())
            {
                sizee--;
                return ListaCola[frente++];               
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return ListaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        public Object finalcolaLineal()
        {
            if (!colaVacia())
            {
                return ListaCola[fin];
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
