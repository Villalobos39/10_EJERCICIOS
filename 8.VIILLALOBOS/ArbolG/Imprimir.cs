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
            Nodo raiz = arbol.Crear(3, null);
            // AL INSERTAR LOS NODOS SE EVALUAN       
            arbol.Crear(-1,raiz);
            arbol.Crear(0,raiz);
            arbol.Crear(2,raiz);
            arbol.Crear(-2,raiz);
            arbol.Crear(3,raiz);
            arbol.Crear(6,raiz);
            arbol.Crear(-3,raiz);
            arbol.Crear(5,raiz);
            arbol.Crear(1,raiz);
            arbol.Crear(4,raiz);
            Console.WriteLine("\nINORDEN -1,0,2,-2," +
                "3,6,-3,5,1,4\n");
            arbol.Imprimir(raiz);
            arbol.Orden(raiz);
            Console.Write("\n");
           
        }

        public void Imprime2()
        {
            arbol = new Arbol();
            Nodo raiz = arbol.Crear(5, null);
            arbol = new Arbol();
            arbol.Crear(-1,raiz);
            arbol.Crear(7,raiz);
            arbol.Crear(4,raiz);
            arbol.Crear(11,raiz);
            arbol.Crear(5,raiz);
            arbol.Crear(-8,raiz);
            arbol.Crear(15,raiz);
            arbol.Crear(-3,raiz);
            arbol.Crear(-2,raiz);
            arbol.Crear(6,raiz);
            arbol.Crear(10,raiz);
            arbol.Crear(3,raiz);
            Console.WriteLine("\nINORDEN  " +
                "-1,7,4,11,5,-8,15,-3,-2,6,10,3\n");
            arbol.Imprimir(raiz);
            arbol.Orden(raiz);
            Console.Write("\n");
            
           
        }
    }
}
