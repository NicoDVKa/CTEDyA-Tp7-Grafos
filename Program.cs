using System;
using System.Collections;
using System.Collections.Generic;

namespace Grafo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice<int> vertice1 = new Vertice<int>(1);
            Vertice<int> vertice2 = new Vertice<int>(2);
            Vertice<int> vertice3 = new Vertice<int>(3);
            Vertice<int> vertice4 = new Vertice<int>(4);
            Vertice<int> vertice5 = new Vertice<int>(5);
            Vertice<int> vertice6 = new Vertice<int>(6);
            Vertice<int> vertice7 = new Vertice<int>(7);
            Vertice<int> vertice8 = new Vertice<int>(8);

            Grafo<int> grafo = new Grafo<int>();

            grafo.conectar(vertice1,vertice5,0);
            grafo.conectar(vertice2, vertice1, 0);
            grafo.conectar(vertice2, vertice3, 0);
            grafo.conectar(vertice3, vertice7, 0);
            grafo.conectar(vertice4, vertice1, 0); 
            grafo.conectar(vertice4, vertice2, 0);
            grafo.conectar(vertice4, vertice8, 0);
            grafo.conectar(vertice5, vertice6, 0);
            grafo.conectar(vertice6, vertice8, 0);
            grafo.conectar(vertice8, vertice7, 0);

            grafo.DFS(vertice4);

            Console.ReadKey(true);
        }
    }
}
