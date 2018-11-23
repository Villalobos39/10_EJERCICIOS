using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolF
{
    class Arbol
    {
        Nodo raiz;

        public Arbol() { raiz = null; }
        // HACEMOS UN CONSTRUCTOR PARA LA CLASE ARBOL 
        public void Crear(string Dato)
        { // EL METODO CREAR 
            Nodo nuevo = new Nodo
            {
                dato = Dato,
                izq = null,
                der = null
            };
            // INSERTA TODOS LOS NODOS PRINCIPALES Y LOS ORDENA 

            if (raiz == null) raiz = nuevo;

            else
            { // CUMPLIENDO CON LAS CONDICCIONES ESTABOLECIDAD 
                Nodo nodoA = null, Raiz;
                Raiz = raiz;
                // COMO SE ENVIAN CARACTERES LA EVALUACION DEL NODO
                while (Raiz != null)
                { // SE REALIZA CON UNA CONVERSION A SU NUMERO POR 
                    nodoA = Raiz;
                    if ((int)(Dato[0]) < (int)(Raiz.dato[0]))
                        Raiz = Raiz.izq;
                    else
                        Raiz = Raiz.der;
                } // DEFECCTO QUE ES ASIGNADO DESDE EL PROGRAMA
                if ((int)(Dato[0]) < (int)(nodoA.dato[0]))
                    nodoA.izq = nuevo;
                else
                    nodoA.der = nuevo;
            }
        }
        // EL NODO SE IMPRIME EN PREORDEN
        private void Preorden(Nodo nodo)
        {
            if (nodo != null)
            {

                Console.Write(nodo.dato + "  ");
                Preorden(nodo.izq);
                Preorden(nodo.der);

                // RAIZ IZQUIERDA  A DERECHA 
            }
        }
        private void Inorden(Nodo nodo)
        {
            if (nodo != null)
            {
                Inorden(nodo.der);
                Inorden(nodo.izq);
                Console.Write(nodo.dato + "  ");
                // RAIZ IZQUIERDA  A DERECHA 
            }
        }

        public void Preorden()
        {
            Console.Write("\nPOSTORDEN   : ");
            Inorden(raiz);
            Console.Write("\n\n");
            Console.Write("\nORDDEN : ");
            Preorden(raiz);
            Console.Write("  ");
        }

        public void Imprimir()
        {
            Preorden();
        }
    }
}
