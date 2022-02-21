using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(new Livro() { id = 1, autoId = 2, Titulo = "Amor amado" });
            listaLivro.Add(new Livro() { id = 2, autoId = 2, Titulo = "Bem amado" });
            listaLivro.Add(new Livro() { id = 3, autoId = 3, Titulo = "Um Espiao em Wahington" });
            listaLivro.Add(new Livro() { id = 4, autoId = 1, Titulo = "A  vida na terra" });


            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add ( new Autor() { id = 1, nome = "Maria Maria" });
            listaAutor.Add (new Autor() { id = 1, nome = "Joseph" });
            listaAutor.Add ( new Autor() { id = 1, nome = "Leonardo" });


            var ListaJoin = from Livros in listaLivro join autor in listaAutor on Livros.autoId equals autor.id select new { Livros, autor };

            foreach (var item in ListaJoin)
            {
                Console.WriteLine("livro: " + item.Livros.Titulo + "- Autor: " + item.autor.nome);
            }
        }
       
    }
}
