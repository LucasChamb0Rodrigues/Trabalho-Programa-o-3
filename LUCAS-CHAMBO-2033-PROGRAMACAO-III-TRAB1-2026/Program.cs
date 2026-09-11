using System;
using ExerciciosConsole.Exercicios;

namespace ExerciciosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuarExecutando = true;

            while (continuarExecutando)
            {
                ExibirMenu();

                string opcao = Console.ReadLine() ?? string.Empty;

                switch (opcao)
                {
                    case "1":
                        new Exercicio1Calculadora().Executar();
                        AguardarTecla();
                        break;

                    case "2":
                        new Exercicio2ContarVogais().Executar();
                        AguardarTecla();
                        break;

                    case "3":
                        new Exercicio3ImprimirVogais().Executar();
                        AguardarTecla();
                        break;

                    case "4":
                        new Exercicio4ImprimirConsoantes().Executar();
                        AguardarTecla();
                        break;

                    case "5":
                        new Exercicio5FaixaEtaria().Executar();
                        AguardarTecla();
                        break;

                    case "6":
                        new Exercicio6CadastroLivro().Executar();
                        AguardarTecla();
                        break;

                    case "7":
                        new Exercicio7CadastroAluno().Executar();
                        AguardarTecla();
                        break;

                    case "0":
                        continuarExecutando = false;
                        Console.WriteLine("\nEncerrando a aplicação...");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("           MENU DE EXERCÍCIOS           ");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Contar vogais de uma string");
            Console.WriteLine("3 - Imprimir apenas as vogais");
            Console.WriteLine("4 - Imprimir apenas as consoantes");
            Console.WriteLine("5 - Informar faixa etária pela idade");
            Console.WriteLine("6 - Cadastro de Livro");
            Console.WriteLine("7 - Cadastro de Aluno");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("========================================");
            Console.Write("Escolha uma opção: ");
        }

        private static void AguardarTecla()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
