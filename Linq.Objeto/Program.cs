using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario() { nome = "José", Email = "Jose@gmail.com" });
            lista.Add(new Usuario() { nome = "Maria", Email = "maria@hotmail.com" });
            lista.Add(new Usuario() { nome = "João", Email = "joao@ig.com" });
            lista.Add(new Usuario() { nome = "felipe", Email = "felipe@gmail.com" });
            lista.Add(new Usuario() { nome = "Elias", Email = "elias@gmail.com" });

            //Lista que capta apenas os emails Gmail ordenada por letra em alfabeto
            var listaFiltrada = lista.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a => a.nome).Select(a => a); 
                
             foreach(var item in listaFiltrada)
            {
                Console.WriteLine(item.nome + "_" + item.Email);
            }
        }
    }
}
