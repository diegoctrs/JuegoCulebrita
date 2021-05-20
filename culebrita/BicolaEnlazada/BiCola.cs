using culebrita.Cola_Lista;
using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.BicolaEnlazada
{
    class BiCola : ColaConLista
    {
        // insertar por el final de la bicola
        public void ponerFinal(Object elemento)
        {
            insertar(elemento);
        }

        //insertar al frente
        public void ponerFrente(Object elemento)
        {
            Nodo a;
            a = new Nodo(elemento);
            if (colaVacia())
            {
                fin = a;
            }
            a.siguiente = frente;
            frente = a;
        }

        //quitar elemento
        public Object quitarFrente()
        {
            return quitar();
        }

        //retirar elemento al final
        //metodo propio de bicola
        //Es necesario hacer una iteracion de la bicola para
        //llegar del nodo anterior al final, para despues enlazar y ajustar 
        //la cola
        public Object quitarFinal()
        {
            Object aux;
            if (!colaVacia())
            {
                if (frente == fin) //la bicola solo tiene un nodo
                {
                    aux = quitar();
                }
                else
                {
                    //como no tiene elementos vamos a iterar
                    Nodo a = frente;
                    while (a.siguiente != fin)
                    {
                        a = a.siguiente;

                    }
                    //siguiente del nodo anterior lo vamos a poner en null
                    a.siguiente = null;
                    aux = fin.elemento;
                    fin = a;
                }
            }
            else
            {
                throw new Exception("la cola esta vacia");
            }
            return aux;
        }

        //retorna el valor que se encuentra en el primer elemento o frente de la cola
        public Object frenteBicola()
        {
            return frenteCola();
        }

        //devolver el final de la cola
        public Object finalBicola()
        {
            if (colaVacia())
            {
                throw new Exception("Cola vacia");
            }
            return (fin.elemento);
        }

        //retorna si esta vacia la cola
        public bool biColaVacia()
        {
            return colaVacia();
        }

        //borra la bicola
        public void borrarCola()
        {
            borrarCola();
        }

        //conteo de elementos
        public int numElementosBicola()
        {
            int n;
            Nodo a = frente;
            if (biColaVacia())
            {
                n = 0;
            }
            else
            {
                n = 1;
                while (a != fin)
                {
                    n++;
                    a = a.siguiente;
                }
            }
            return n;
        }
    }
}
