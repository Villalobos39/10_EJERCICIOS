using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolD
{
    class Imprimir
    {
        public Imprimir() { }

        Arbol arbol = new Arbol();
        // CREAMOS CADA NODO DEL ARBOL 
        public void Arbol4()
        {
            arbol.Crear("-B"); arbol.Crear("-A");
            arbol.Crear("-N"); arbol.Crear("-A");
            arbol.Crear("-N"); arbol.Crear("-A");
            arbol.Crear("-->");
            Console.WriteLine("\n\tBANANA ");
            arbol.Imprimir();
            // MANDAMOS A LLAMAR EL METODO IMPRIMIR       
        }
        // PARA DESPEGAR EL ARBO DE FORMA ORDENADA DEPENDIENDO DE LOS NODO
        public void Arbol5()
        {
            arbol.Crear("-M"); arbol.Crear("-E");
            arbol.Crear("-L"); arbol.Crear("-O");
            arbol.Crear("-C"); arbol.Crear("-O");
            arbol.Crear("-T"); arbol.Crear("-O");
            arbol.Crear("-N"); arbol.Crear("-->");
            Console.Write("\n\tMELOCOTON ");
            arbol.Imprimir();
        }

        public void Arbol6()
        {
         // EL ARBOL DESPEGARA TODOS LOS RECORRIDOS 
            arbol.Crear("-M"); arbol.Crear("-A");
            arbol.Crear("-N"); arbol.Crear("-Z");
            arbol.Crear("-A"); arbol.Crear("-N");
            arbol.Crear("-A"); arbol.Crear("-->");
            Console.Write("\n\tMANZANA ");
            arbol.Imprimir();

        }
        public void Arbol7()
        { // DESDE EL PRIMERO HATA EL ULTIMO 
            arbol.Crear("-P"); arbol.Crear("-E");
            arbol.Crear("-R"); arbol.Crear("-A");
            arbol.Crear("-->");
            Console.Write("\n\tPERA ");
            arbol.Imprimir();

        }

        public void Arbol8()
        {
            arbol.Crear("-C"); arbol.Crear("-O");
            arbol.Crear("-C"); arbol.Crear("-O");
            Console.Write("\n\tCOCO ");
            arbol.Imprimir();
        }
        // ESTOS METODOS LLEVAN A CABO LA MISMA FUNCION QUE ES
        public void Arbol9()
        {
            arbol.Crear("-M"); arbol.Crear("-A");
            arbol.Crear("-N"); arbol.Crear("-G");
            arbol.Crear("-O");
            Console.Write("\n\tMANGO ");
            arbol.Imprimir();

        }
        // CREAR NUEVOS NODOS 
        public void Arbol10() 
        {
            arbol.Crear("-P"); arbol.Crear("-A");
            arbol.Crear("-P"); arbol.Crear("-A");
            arbol.Crear("-Y"); arbol.Crear("-A");
            Console.WriteLine("\n\tPAPAYA ");
            arbol.Imprimir();
      
        }
    }
}


