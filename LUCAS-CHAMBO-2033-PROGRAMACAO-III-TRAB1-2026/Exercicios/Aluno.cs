using System;

namespace ExerciciosConsole.Exercicios
{
    public class Aluno
    {
        private const int TotalDeAulas = 40;
        private const double PercentualLimiteDeFaltas = 0.4;
        private const double PesoNotaProva = 0.7;
        private const double PesoNotaTrabalho = 0.3;
        private const double MediaMinimaAprovacao = 7.0;

        public string Nome { get; set; } = string.Empty;
        public string RA { get; set; } = string.Empty;
        public double NotaProva { get; set; }
        public double NotaTrabalho { get; set; }
        public int Faltas { get; set; }

        public double CalcularMedia()
        {
            return (NotaProva * PesoNotaProva) + (NotaTrabalho * PesoNotaTrabalho);
        }

        public bool FoiAprovadoPorFrequencia()
        {
            int limiteDeFaltas = (int)(PercentualLimiteDeFaltas * TotalDeAulas);
            return Faltas <= limiteDeFaltas;
        }

        public void Imprimir()
        {
            double media = CalcularMedia();
            bool aprovadoPorFrequencia = FoiAprovadoPorFrequencia();
            bool aprovadoPorMedia = media >= MediaMinimaAprovacao;

            Console.WriteLine("\n----- Dados do Aluno -----");
            Console.WriteLine($"Nome:                {Nome}");
            Console.WriteLine($"R.A.:                {RA}");
            Console.WriteLine($"Nota da prova:       {NotaProva}");
            Console.WriteLine($"Nota do trabalho:    {NotaTrabalho}");
            Console.WriteLine($"Faltas:              {Faltas} de {TotalDeAulas} aulas");
            Console.WriteLine($"Média ponderada:     {media:F2} (mínimo para aprovação: {MediaMinimaAprovacao})");
            Console.WriteLine($"Situação pela média: {(aprovadoPorMedia ? "Aprovado" : "Reprovado")}");
            Console.WriteLine($"Situação por faltas: {(aprovadoPorFrequencia ? "Aprovado" : "Reprovado")}");
        }
    }
}
