using System;
using System.Collections.Generic;
using System.Linq;

namespace KevinPillajoRecuperacionP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();
            arbol.insertar(1);
            arbol.insertar(2);
            arbol.insertar(3);
            arbol.insertar(4);
            arbol.insertar(5);
            arbol.insertar(6);
            arbol.insertar(7);
            arbol.insertar(8);
            arbol.insertar(9);

            Console.WriteLine("recorrido en orden");
            arbol.EnOrden(arbol.raiz);
            Console.WriteLine("");

            Console.WriteLine("recorrido en Postorden");
            arbol.PostOrden(arbol.raiz);
            Console.WriteLine("");
            
            
            //METODO DE ORDENADO
            Console.WriteLine("recorrido en Preorden");
            arbol.PreOrden(arbol.raiz);
            Console.WriteLine("");

        }
    }
    public class Nodo
    {
        public Nodo HijoI;
        public Nodo HijoD;
        public int valor;
        public Nodo()
        {
            HijoD = null;
            HijoI = null;
            valor = 0;
        }
    }

    public class ArbolBinarioBusqueda
    {
        public Nodo raiz;
        public ArbolBinarioBusqueda()
        {
            raiz = null;
        }
        public void insertar(int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.valor = valor;
            }
            else
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                nuevo.HijoD= null;
                nuevo.HijoI = null;

                Nodo anterior = null, recorrer;
                recorrer = raiz;
                while (recorrer != null)
                {
                    anterior = recorrer;
                    if (valor<recorrer.valor)
                    {
                        recorrer = recorrer.HijoD;
                    }
                    else
                    {
                        recorrer = recorrer.HijoI;
                    }
                }
                if (valor<anterior.valor)
                {
                    anterior.HijoD = nuevo;
                }
                else
                {
                    anterior.HijoI = nuevo;
                }
            }
        }
        //MOSTRAR  EL ARBOL PREORDEN
        public void PreOrden(Nodo raiz) {
        Console.WriteLine(raiz.valor);
            if (raiz.HijoI != null)
                PreOrden(raiz.HijoI);
            if (raiz.HijoD != null)
                PreOrden(raiz.HijoD);
        }
        //MOSTRAR  ORDEN
        public void EnOrden (Nodo raiz){
            if (raiz.HijoI != null)
                EnOrden(raiz.HijoI);
            Console.WriteLine(raiz.valor);
            if (raiz.HijoD != null)
                EnOrden(raiz.HijoD);
        }

        //MOSTRAR EL METODO POSORDEN
        public void PostOrden(Nodo raiz)
        {
            if (raiz.HijoI != null)
                PostOrden(raiz.HijoI);
            Console.WriteLine(raiz.valor);
            if (raiz.HijoD != null)
                PostOrden(raiz.HijoD);
            Console.WriteLine(raiz.valor);
        }
    }
}