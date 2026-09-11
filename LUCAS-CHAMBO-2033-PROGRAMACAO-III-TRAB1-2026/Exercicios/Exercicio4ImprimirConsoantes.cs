using System;
using System.Text;

namespace ExerciciosConsole.Exercicios
{
    public class Exercicio4ImprimirConsoantes
    {
        private const string Vogais = "AEIOUaeiou";

        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("===== Exercício 4 - Imprimir Consoantes =====\n");

            Console.Write("Digite uma string: ");
            string texto = Console.ReadLine() ?? string.Empty;

            StringBuilder consoantesEncontradas = new StringBuilder();

            foreach (char caractere in texto)
            {
                if (char.IsLetter(caractere) && !Vogais.Contains(caractere))
                {
                    consoantesEncontradas.Append(caractere);
                }
            }

            Console.WriteLine($"\nConsoantes encontradas: {consoantesEncontradas}");
        }
    }
}
