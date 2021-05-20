﻿using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.ColaArreglo
{
    class ColaCircular
    {
        private static int fin;
        private static int MAXTAMQ = 999;
        protected int frente;
        public int sizee;

        protected Object[] ListaCola;

        //avanza una posicion
        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        //Constructor
        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            ListaCola = new object[MAXTAMQ];
        }

        //validaciones
        public bool colaVacia()
        {
            return frente == siguiente(fin);
        }

        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));
        }

        //operaciones de modificacion de cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                fin = siguiente(fin);
                ListaCola[fin] = elemento;
                sizee++;
            }
            else
            {
                throw new Exception("OverFlow de la cola");
            }
        }

        //quitar elemento
        public Object quitar()
        {
            if (!colaVacia())
            {
                Object tm = ListaCola[frente];
                frente = siguiente(frente);
                sizee--;
                return tm;
                
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        public void borrarCola()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
        }

        //obtener el valor de frente
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

        public Object finalcolaCircular()
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
