using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolH
{
    class Imprime
    {
        Arbol arbol = new Arbol();
        // SE CREA UN OBJETO DE LA CLASE ARBOL 
        public void Arbol()
        {
            Nodo raiz =  arbol.InsertarNodo("00", null); //RAIZ 
            Nodo BRaiz = arbol.InsertarNodo("I 0", raiz); // B1 IZQUIERDO 
                         arbol.InsertarNodo("D 1", BRaiz); // I
            Nodo DRaiz = arbol.InsertarNodo("I 0", BRaiz);
                         arbol.InsertarNodo("D 1", DRaiz);
                         arbol.InsertarNodo("I 0", DRaiz); //A 
                         arbol.InsertarNodo("D 1", BRaiz); //E
            Nodo CRaiz = arbol.InsertarNodo("D 1", raiz); // B1 DERECHO
            Nodo GRaiz = arbol.InsertarNodo("D 1", CRaiz);
            Nodo HRaiz = arbol.InsertarNodo("I 0", GRaiz);
                         arbol.InsertarNodo("I 0", HRaiz);//K
                         arbol.InsertarNodo("D 0", HRaiz);//O
            Nodo IRaiz = arbol.InsertarNodo("D 1", GRaiz);
                         arbol.InsertarNodo("I 0", IRaiz);//P
                         arbol.InsertarNodo("D 1", IRaiz);//U 
            Console.WriteLine(); arbol.Preorden(raiz);
            arbol.PreordenLineal(raiz); Console.WriteLine();
            //UNA VEZ INCERTADOS Y CREADOS LOS NODOS 
            arbol.PreOrden(raiz); arbol.PreordenLineal(BRaiz);
            Console.Write("\n\nCAMINOS O RUTAS A-E-I-K-O-P-U\n");
            //COMENZAMOS A LLAMAR A LOS METODOS PARA RECORRELOS
            Console.Write("\nA (0,0,0)\n"); arbol.PreOrden(HRaiz);
            Console.WriteLine(); arbol.PreordenLineal(DRaiz);
        
            Console.Write("\nE (0,0,1)\n"); arbol.PreOrden(GRaiz);
            Console.WriteLine();  

            Console.Write("\nI (0,1)\n"); arbol.PreOrden(BRaiz);
            Console.WriteLine();  

            Console.Write("\nK (1,1,0,0)\n"); arbol.PreOrden(CRaiz);
            Console.WriteLine(); arbol.PreordenLineal(HRaiz);

            Console.Write("\nO (1,1,0,1)\n"); arbol.PreOrden(GRaiz);
            Console.WriteLine(); arbol.PreordenLineal(IRaiz);

            Console.Write("\nP (1,1,1,1,0)\n"); arbol.PreOrden(IRaiz);
            arbol.PreordenLineal(GRaiz);  Console.WriteLine();

            Console.Write("\nP (1,1,1,1,1)\n"); arbol.PreordenLineal(CRaiz);
            Console.WriteLine();
        }
    }
}
