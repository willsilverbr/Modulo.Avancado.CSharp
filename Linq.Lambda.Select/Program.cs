﻿using System;
using System.Linq;

namespace Linq.Lambda.Select
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq e Lambda
            //Lambda = (Entrada => (expressao)
            int[] lista = { 2, 9, 3, 4, 5, 6, 56, 3, 6, 7, 43, 223, 443 };

            //var ListaFiltrada =  lista.where(a=> a>10).Select(a=>a);
            var ListaFiltrada =  lista.Where(a=> a > 10).OrderBy(a=>a).Select(a=>a);
            

            foreach(var item in ListaFiltrada)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
