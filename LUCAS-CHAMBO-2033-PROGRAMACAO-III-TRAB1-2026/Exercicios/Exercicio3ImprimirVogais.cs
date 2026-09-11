using System;
using System.Text;

namespace ExerciciosConsole.Exercicios
{
    public class Exercicio3ImprimirVogais
    {
        private const string Vogais = "AEIOUaeiou";

        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("===== Exercício 3 - Imprimir Vogais =====\n");

            Console.Write("Digite uma string: ");
            string texto = Console.ReadLine() ?? string.Empty;

            StringBuilder vogaisEncontradas = new StringBuilder();

            foreach (char caractere in texto)
            {
                if (Vogais.Contains(caractere))
                {
                    vogaisEncontradas.Append(caractere);
                }
            }

            Console.WriteLine($"\nVogais encontradas: {vogaisEncontradas}");
        }
    }
}
