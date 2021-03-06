﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolI
{
    class Grafo
    {
        private bool[] VertRecorrido;
        public List<int>[] Ggrafo { get; }
        // lista de grafos 
        private List<int>[] GetGrafo()
        { return Ggrafo; }
        // en son 8 cordenadas en total

        public Grafo()
        {// para catrurar cada una de las posiciones 
            Ggrafo = new List<int>[8];
            for (int posicion = 0; posicion < 8; posicion++)
            {
                Ggrafo[posicion] = new List<int>();
            }
        }
        // los parametros que se piden para el metodo arista 

        public void Aristas(int vert, int cvert)
        { // son las coordenadas de los vertices (v1,v2)
            GetGrafo()[vert].Add(cvert);
        }  // se añaden a la lista grafo por cada posicion principal 

        public void Recorrido(int Vertice)
        { // la pila guarda los vertices y cada vez que se recorran y pasen por 
            Stack<int> stack = new Stack<int>();
            VertRecorrido = new bool[8]; VertRecorrido[Vertice] = !false;
            stack.Push(Vertice); // ese vertice se quita de la pila 
            while (stack.Count > 0)
            { // cuando la pila tine un valor diferencte a 0 el ciclo continua 
                Vertice = stack.Pop(); // se van mostrando la posicion del recorrido 
                Console.Write(" || " + Vertice);
                foreach (int vertice in GetGrafo()[Vertice])
                { // se imprime, de forma en que el recorrido de vertices sea diferente al 
                    if (!VertRecorrido[vertice])
                    { // valor total de vertices inicial 
                        VertRecorrido[vertice] = !false; stack.Push(vertice);
                    } // y asi los vertices se van imprimiendo 
                }
            }

        }
       
        public void Trayectorias(int Vertice)
        { // cada vez que vicitamos a un vertice lo agregaos a la pila y lo quitamos 
            Stack<int> stack = new Stack<int>();
            VertRecorrido = new bool[8]; VertRecorrido[Vertice] = !false;
            stack.Push(Vertice); // ese vertice se quita de la pila 
            while (stack.Count > 0)
            { // cuando la pila tine un valor diferencte a 0 el ciclo continua 
                Vertice = stack.Pop();
                if (Vertice != 3)
                {  // se van mostrando la posicion del recorrido 
                    Console.Write(" || " + Vertice);
                    foreach (int vertice in GetGrafo()[Vertice])
                    { // se imprime, de forma en que el recorrido de vertices sea diferente al 
                        if (!VertRecorrido[vertice])
                        { // valor total de vertices inicial 
                            VertRecorrido[vertice] = !false; stack.Push(vertice);
                        } // y asi los vertices se van imprimiendo 
                    }
                }
            }
        }

        

        public void Imrpime()
        { // aqui asigno los valores del los vertices para formar el grafo 
            Console.Write("\n 9.GRAFO\n\tRECORRIDO DE PROFUNDIDAD O TRAYCETORIAS SIMPLES \n\n");
            Aristas(2,1); Aristas(1,5); Aristas(5,2); Aristas(2,3);
            Aristas(4,2); Aristas(4,5); Aristas(4,3); Recorrido(1);
            // por cada coordenada cuando se repiten los valores indica 
            Console.Write("\n || A || E || B || C \n\n");
            Trayectorias(1);
            Console.Write("\n || A || E || B \n\n");
            Console.Write("\n || 1 || 5 || 2 || 1 ");
            Console.Write("\n || A || E || B || A \n\n");

            // la conecion entre aristas del grafo 
        }
        public void Trayectoria(int Vertice)
        { // cada vez que vicitamos a un vertice lo agregaos a la pila y lo quitamos 
            Stack<int> stack = new Stack<int>();
            VertRecorrido = new bool[8]; VertRecorrido[Vertice] = !false;
            stack.Push(Vertice); // ese vertice se quita de la pila 
            while (stack.Count > 0)
            { // cuando la pila tine un valor diferencte a 0 el ciclo continua 
                Vertice = stack.Pop();
                if (Vertice != 1&& Vertice != 6)
                {  // se van mostrando la posicion del recorrido 
                    Console.Write(" || " + Vertice);
                    foreach (int vertice in GetGrafo()[Vertice])
                    { // se imprime, de forma en que el recorrido de vertices sea diferente al 
                        if (!VertRecorrido[vertice])
                        { // valor total de vertices inicial 
                            VertRecorrido[vertice] = !false; stack.Push(vertice);
                        } // y asi los vertices se van imprimiendo 
                    }
                }
            }
        }
        public void Recorrido2(int Vertice)
        { // la pila guarda los vertices y cada vez que se recorran y pasen por 
            Stack<int> stack = new Stack<int>();
            VertRecorrido = new bool[8]; VertRecorrido[Vertice] = !false;
            stack.Push(Vertice); // ese vertice se quita de la pila 
            while (stack.Count > 0)
            { // cuando la pila tine un valor diferencte a 0 el ciclo continua 
                Vertice = stack.Pop(); // se van mostrando la posicion del recorrido 
                Console.Write(" || " + Vertice);
                foreach (int vertice in GetGrafo()[Vertice])
                { // se imprime, de forma en que el recorrido de vertices sea diferente al 
                    if (!VertRecorrido[vertice])
                    { // valor total de vertices inicial 
                        VertRecorrido[vertice] = !false; stack.Push(vertice);
                    } // y asi los vertices se van imprimiendo 
                }
            }

        }
        public void Trayectoria3(int Vertice)
        { // cada vez que vicitamos a un vertice lo agregaos a la pila y lo quitamos 
            Stack<int> stack = new Stack<int>();
            VertRecorrido = new bool[8]; VertRecorrido[Vertice] = !false;
            stack.Push(Vertice); // ese vertice se quita de la pila 
            while (stack.Count > 0)
            { // cuando la pila tine un valor diferencte a 0 el ciclo continua 
                Vertice = stack.Pop();
                if (Vertice != 1 && Vertice != 6 && Vertice != 2)
                {  // se van mostrando la posicion del recorrido 
                    Console.Write(" || " + Vertice);
                    foreach (int vertice in GetGrafo()[Vertice])
                    { // se imprime, de forma en que el recorrido de vertices sea diferente al 
                        if (!VertRecorrido[vertice])
                        { // valor total de vertices inicial 
                            VertRecorrido[vertice] = !false; stack.Push(vertice);
                        } // y asi los vertices se van imprimiendo 
                    }
                }
            }
        }
        public void Imrpime2()
        { // aqui asigno los valores del los vertices para formar el grafo 
            Console.Write("\n 9.GRAFO\n\tRECORRIDO DE PROFUNDIDAD O TRAYCETORIAS SIMPLES \n\n");
            Aristas(1, 6); Aristas(2, 1); Aristas(3,2); Aristas(5,3);
            Aristas(4,5); Aristas(5,2); Aristas(5,6); Recorrido2(3);
            // por cada coordenada cuando se repiten los valores indica 
            Console.Write("\n || C || B || A || F || E \n\n");
            Trayectoria(3); Console.Write(" || 5");
            Console.Write("\n || C || B || E \n\n");
            Trayectoria3(3); Console.Write(" || 4 || 5 ");
            Console.Write("\n || C || D || E  \n\n");

            // la conecion entre aristas del grafo 
        }
    }
}
