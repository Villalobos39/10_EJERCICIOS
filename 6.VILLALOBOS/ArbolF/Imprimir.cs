using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolF
{
    class Imprimir
    {
        Arbol arbol = new Arbol();
        public void Imprime()
        {
            // CREAMOS CADA NODO DEL ARBOL 
            arbol.Crear("-E"); arbol.Crear("-L");
            arbol.Crear("->");
            arbol.Crear("-R"); arbol.Crear("-A");
            arbol.Crear("-P"); arbol.Crear("-I");
            arbol.Crear("-D"); arbol.Crear("-O");
            arbol.Crear("->");
            arbol.Crear("-Z"); arbol.Crear("-O");
            arbol.Crear("-R"); arbol.Crear("-R");
            arbol.Crear("-O");
            arbol.Crear("->");
            arbol.Crear("-M"); arbol.Crear("-A"); arbol.Crear("-R");
            arbol.Crear("-R"); arbol.Crear("-O"); arbol.Crear("-N");
            arbol.Crear("->");
            arbol.Crear("-S"); arbol.Crear("-A"); arbol.Crear("-L");
            arbol.Crear("-T"); arbol.Crear("-A");
            arbol.Crear("->");
            arbol.Crear("-S"); arbol.Crear("-O"); arbol.Crear("-B");
            arbol.Crear("-R"); arbol.Crear("-E");
            arbol.Crear("->");
            arbol.Crear("-E"); arbol.Crear("-L");
            arbol.Crear("->");
            arbol.Crear("-P"); arbol.Crear("-E"); arbol.Crear("-R");
            arbol.Crear("-R"); arbol.Crear("-O");
            arbol.Crear("->");
            arbol.Crear("-P"); arbol.Crear("-E"); arbol.Crear("-R");
            arbol.Crear("-E"); arbol.Crear("-E"); arbol.Crear("-Z");
            arbol.Crear("-O"); arbol.Crear("-Z"); arbol.Crear("-O");

            Console.WriteLine("EL RAPIDO ZORRO MARRON SALTA SOBRE EL PERRO PEREZOSO  ");
            arbol.Imprimir();


        }
    }
}

