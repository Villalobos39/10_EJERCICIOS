using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolG
{
    class Imprimir
    {
        Arbol arbol = new Arbol();
        public void Imprime()
        {
            Nodo raiz = arbol.Crear(1, null);
            // AL INSERTAR LOS NODOS SE EVALUAN       
            arbol.Crear(0, raiz);
            arbol.Crear(1, raiz);
            arbol.Crear(0, raiz);
            arbol.Crear(1, raiz);
            arbol.Crear(2, raiz);
            arbol.Crear(1, raiz);
            arbol.Crear(3, raiz);
            arbol.Crear(4, raiz);
            arbol.Crear(2, raiz);
            arbol.Crear(0, raiz);
            Console.WriteLine("\nINORDEN 0,1,0,1,0-" +
                "0,0,0,1,1,\n");
            arbol.Imprimir(raiz);
            arbol.Orden(raiz);
            Console.Write("\n");

        }
    }
}
