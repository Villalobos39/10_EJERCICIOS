using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolF
{
    class Program
    {
        static void Main(string[] args)
        {
            // MANDAMOS A LLAMAR AL METODO DE LA CLASE 
            Imprimir imprimir = new Imprimir();
            Console.Write("\n\tPALABRAS DEL ARBOL\n\n");
            imprimir.Imprime();
            Console.ReadKey();

        }
    }
}
