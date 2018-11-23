using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolG
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir imprimir = new Imprimir();
            Console.WriteLine("\n\tARBOL ");
            imprimir.Imprime();
            Console.WriteLine("\n\n\tARBOL \n");
            imprimir.Imprime2();
            Console.ReadKey();
        }
    }
}
