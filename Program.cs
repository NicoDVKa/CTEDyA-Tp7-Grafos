using System;
using System.Collections;
using System.Collections.Generic;

namespace Grafo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo los vertices
            Vertice<string> vertice1 = new Vertice<string>("A");
            Vertice<string> vertice2 = new Vertice<string>("B");
            Vertice<string> vertice3 = new Vertice<string>("C");
            Vertice<string> vertice4 = new Vertice<string>("D");

            //Creo el grafo
            Grafo<string> grafo = new Grafo<string>();

            //Agrego los vertices en el grafo
            grafo.agregarVertice(vertice1);
            grafo.agregarVertice(vertice2);
            grafo.agregarVertice(vertice3);
            grafo.agregarVertice(vertice4);

            //Agrego las aristas
            grafo.conectar(vertice1,vertice2,0);
            grafo.conectar(vertice2, vertice3, 0);
            grafo.conectar(vertice3, vertice4, 0);
            grafo.conectar(vertice4, vertice1, 0);


            //Chequeo metodos del grafo
            Console.WriteLine("==========================================================================");
            List<Vertice<string>> vertices = grafo.getVertices();
            foreach (Vertice<string> x in vertices){
                Console.WriteLine(x.getDato());
            }
            Console.WriteLine("==========================================================================");
            for (int i = 0; i < grafo.getVertices().Count; i++) {
                Console.WriteLine(grafo.vertice(i).getDato());
            }

            //Chequeo metodos de los vertices
            Console.WriteLine("==========================================================================");
            Console.WriteLine(vertice1.getPosicion());
            Console.WriteLine(vertice2.getPosicion());
            Console.WriteLine(vertice3.getPosicion());
            Console.WriteLine(vertice4.getPosicion());


            //Chequeo metodos de las aristas
            Console.WriteLine("==========================================================================");
            List<Arista<string>> vertices1 = vertice1.getAdyacentes();
            foreach (Arista<string> x in vertices1)
            {
                Console.WriteLine(x.getDestino().getDato());
                Console.WriteLine(x.getPeso());
            }


            Console.ReadKey(true);
        }
    }
}
