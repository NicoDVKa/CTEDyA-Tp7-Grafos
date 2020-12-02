using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Grafo
{
	public class Grafo<T>
	{
		public Grafo()
		{
		}

		private List<Vertice<T>> vertices = new List<Vertice<T>>();

		private Hashtable visitados = new Hashtable();

		public void agregarVertice(Vertice<T> v)
		{
			v.setPosicion(vertices.Count + 1);
			vertices.Add(v);
		}

		public void eliminarVertice(Vertice<T> v)
		{
			vertices.Remove(v);
		}

		public void conectar(Vertice<T> origen, Vertice<T> destino, int peso)
		{
			origen.getAdyacentes().Add(new Arista<T>(destino, peso));
		}

		public void desConectar(Vertice<T> origen, Vertice<T> destino)
		{
			Arista<T> arista = origen.getAdyacentes().Find(a => a.getDestino().Equals(destino));
			origen.getAdyacentes().Remove(arista);
		}


		public List<Vertice<T>> getVertices()
		{
			return vertices;
		}


		public Vertice<T> vertice(int posicion)
		{
			return this.vertices[posicion];
		}


		public void DFS(Vertice<T> origen)
		{

			if (!this.visitar(origen)) //Verifico que U no este visitado
			{
				Console.Write(origen.getDato()+ " "); //Muestro el dato

				List<Arista<T>> vecinos = origen.getAdyacentes(); //Vecinos de U

				foreach (Arista<T> arista in vecinos) //Verifico que U tenga vecinos
				{
					this.DFS(arista.getDestino()); //Recursivamente aplicamos DFS
				}
			}
		}

		public void BFS(Vertice<T> origen)
		{
			this.visitar(origen); //Visito U
			Cola<Vertice<T>> cola = new Cola<Vertice<T>>();
			cola.encolar(origen);//Encolo U
			while (!cola.esVacia()) {
				Vertice<T> vertice = cola.desencolar();//Desencolo U
				Console.Write(vertice.getDato()+" ");//Muestro el dato de U
				if (vertice.getAdyacentes().Count != 0)//Verifico que tenga vecinos 
				{
					List<Arista<T>> vecinos = vertice.getAdyacentes();
					foreach (Arista<T> arista in vecinos)
					{
						if (!this.visitar(arista.getDestino())){

							cola.encolar(arista.getDestino()); //Encolos los vecinos de U que no fueron visitados
						}
					}
				}
			}
		}

		public void resetVisitas()
        {
			visitados = new Hashtable();
        }
		

		public bool visitar(Vertice<T> nodo) {
			
			if (visitados.ContainsKey(nodo))
			{
				return true; //Si U ya fue visitado
			}
			else 
			{
				visitados.Add(nodo,true);
				return false;   //Si U no fue visitado
			}
		}

	}
}
