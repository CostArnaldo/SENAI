using System;

namespace OOP

{
    class Program
    {
        static void Main(string[] args)
        {
            var livros = new List<Livro>()
            {
                new Livro() { Id=1, Titulo= "Do mil ao milhão", Preco=12},
                new Livro() {Id=2, Titulo="O Poder do Agora", Preco=12},
                new Livro() {ID=3, Titulo= "Comece pelo porque", Preco=12},
                new Livro() {Id=4, Titulo= "Breves Respostas Para Grandes Questões", Preco=12}
            };
            // obtém a quantidade de itens
            Console.WriteLine(livros.Count); //4
            //pecorrendo a lista de livros, e para cada item, imprimindo o título no console
            livros.ForEach(livros =>Console.WriteLine(livros.Titulo));
            {
                
            }
        }
        
    }
}