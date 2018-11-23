using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolD
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir Imprime = new Imprimir();
            string si; // CREAMOS EL OBJETO DE LA CLASE 
            do
            {
                Console.Write("\n\tQUE DESEA IMPRIMIR 1)B-M-M 2)P-C-P : ");
                int opcion = int.Parse(Console.ReadLine());
                // LE PREGUNTAMOS AL USUARIO QUE DESEA VER PRIMERO 
                if (opcion == 1)
                { Imprime.Arbol4(); Imprime.Arbol5(); Imprime.Arbol6(); }
                else if (opcion == 2)
                { Imprime.Arbol7(); Imprime.Arbol8(); Imprime.Arbol10(); }
                // SE DESPLEGAN DE 3 ARBOLES POR OPCION 
              Console.Write("\n\tCONTINUAR S N : ");
              si = Console.ReadLine();
              // EL CICLO SE TERMINA CUANDO EL USUARIO LO INDIQUE 
            }
            while (si == "s"|| si == "S");
            Console.ReadKey();

        }
    }
}

