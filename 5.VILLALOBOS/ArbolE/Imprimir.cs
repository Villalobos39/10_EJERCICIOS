using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolE
{
    class Imprimir
    {
        Arbol arbol = new Arbol();
        public void Imprime()
        {
            // CREAMOS CADA NODO DEL ARBOL 
            arbol.Crear("-E");arbol.Crear("-N");
            arbol.Crear("-O"); arbol.Crear("-L");
            arbol.Crear("-O"); arbol.Crear("-G");
            arbol.Crear("-I");  arbol.Crear("-A");
            Console.WriteLine("ENOLOGIA ");
            arbol.Imprimir();
       
            
        }
        public void A1()
        {
            arbol = new Arbol();
            arbol.Crear("-F"); arbol.Crear("-R");
            arbol.Crear("-E"); arbol.Crear("-N");
            arbol.Crear("-O"); arbol.Crear("-L");
            arbol.Crear("-O"); arbol.Crear("-G");
            arbol.Crear("-I"); arbol.Crear("-A");
            Console.WriteLine("\n\nFRENOLOGIA  ");
            arbol.Imprimir();
          
            // MANDAMOS A LLAMAR EL METODO IMPRIMIR       
        }
        // PARA DESPEGAR EL ARBO DE FORMA ORDENADA DEPENDIENDO DE LOS NODO
        public void A2()
        {
            arbol = new Arbol();
            arbol.Crear("-C"); arbol.Crear("-A");
            arbol.Crear("-M"); arbol.Crear("-P");
            arbol.Crear("-A"); arbol.Crear("-N");
            arbol.Crear("-O"); arbol.Crear("-L");
            arbol.Crear("-O"); arbol.Crear("-G");
            arbol.Crear("-I"); arbol.Crear("-A");
            Console.WriteLine("\n\nCAMPANOLOGIA \n  ");
            arbol.Imprimir();
            
        }
        public void A3()
        {
            arbol = new Arbol();
            arbol.Crear("-O"); arbol.Crear("-R");
            arbol.Crear("-N"); arbol.Crear("-I");
            arbol.Crear("-T"); arbol.Crear("-O");
            arbol.Crear("-L"); arbol.Crear("-O");
            arbol.Crear("-G"); arbol.Crear("-I");
            arbol.Crear("-A");
            Console.WriteLine("\n\nORNITOLOGIA \n ");
            arbol.Imprimir();
          
         
        }
        public void A4()
        {
            arbol = new Arbol();
            arbol.Crear("-I"); arbol.Crear("-C");
            arbol.Crear("-T"); arbol.Crear("-I");
            arbol.Crear("-O"); arbol.Crear("-L");
            arbol.Crear("-O"); arbol.Crear("-G");
            arbol.Crear("-I"); arbol.Crear("-A");
            Console.WriteLine("\n\nICTIOLOGIA \n ");
            arbol.Imprimir();
           
        }
        public void A6()
        {
            arbol = new Arbol();
            arbol.Crear("-L"); arbol.Crear("-I");
            arbol.Crear("-M"); arbol.Crear("-N");
            arbol.Crear("-O"); arbol.Crear("-L");
            arbol.Crear("-O"); arbol.Crear("-G");
            arbol.Crear("-I"); arbol.Crear("-A");
            Console.WriteLine("\n\nALIMNOLOGIA \n ");
            arbol.Imprimir();
            
            //Console.Clear();
        }
        // ESTOS METODOS LLEVAN A CABO LA MISMA FUNCION QUE ES
       
        public void A7()
        {
            arbol = new Arbol();
            arbol.Crear("-A"); arbol.Crear("-L");
            arbol.Crear("-Q"); arbol.Crear("-U");
            arbol.Crear("-I"); arbol.Crear("-M");
            arbol.Crear("-I"); arbol.Crear("-A");
            Console.WriteLine("\n\n ALQUIMIA  \n");
            arbol.Imprimir();
          
        }
        public void A8()
        {
            arbol = new Arbol();
            arbol.Crear("-A"); arbol.Crear("-S");
            arbol.Crear("-T"); arbol.Crear("-R");
            arbol.Crear("-O"); arbol.Crear("-L");
            arbol.Crear("-O"); arbol.Crear("-G");
            arbol.Crear("-I"); arbol.Crear("-A");
            Console.WriteLine("\n\nASTROLOGIA  \n");
            arbol.Imprimir();
           
            //Console.Clear();
        }

    }
}

