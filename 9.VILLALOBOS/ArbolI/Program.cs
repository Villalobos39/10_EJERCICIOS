﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolI
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo imprimir = new Grafo(); // creo el objeto y mando a llamar a la clase 
            imprimir.Imrpime();
            imprimir.Imrpime2();
            Console.ReadKey();
        }
    }
}
