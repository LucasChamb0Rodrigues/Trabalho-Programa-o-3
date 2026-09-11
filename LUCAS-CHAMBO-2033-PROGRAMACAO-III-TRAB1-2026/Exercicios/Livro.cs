using System;

namespace ExerciciosConsole.Exercicios
{
    public class Livro
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public decimal Valor { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("\n----- Dados do Livro -----");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor:  {Autor}");
            Console.WriteLine($"Valor:  {Valor:C2}");
        }
    }
}
