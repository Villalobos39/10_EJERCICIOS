using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\t>>> EJERCICIO 7:   <<<\n");
            //MANDO A LLAMAR AL METODO IMPRIMIR 

             Imprime imprime = new Imprime();

            imprime.Arbol();
            Console.ReadKey();
        }
    }
}
