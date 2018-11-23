using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolE
{
    class Program
    {
        static void Main(string[] args)
        {
            // MANDAMOS A LLAMAR AL METODO DE LA CLASE 
            Imprimir imprimir = new Imprimir();
            Console.Write("\n\tPALABRAS DEL ARBOL\n\n");
            imprimir.Imprime();
            imprimir.A2();
            imprimir.A4();
            imprimir.A1();
            imprimir.A6();
            imprimir.A3();
            imprimir.A4();
            imprimir.A8();
            Console.ReadKey();

        }
    }
}
