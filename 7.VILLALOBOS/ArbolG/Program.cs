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

            Console.Write("A (0,0,0)");
            Console.Write("E (0,0,1)");
            Console.Write("I (0,1)");
            Console.Write("K (1,1,0,0)");
            Console.Write("O (1,1,0,1)");
            Console.Write("K (1,1,1,1,0)");
            Console.ReadKey();
        }
    }
}
