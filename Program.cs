using System;

class Desafio
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        string presentes = Console.ReadLine();
        string saida = "Farei hoje!";

        string[] stringTempoPresentes = presentes.Split(" ");
        int[] tempoPresentes = Array.ConvertAll<string, int>(stringTempoPresentes, int.Parse);

        if (tempoPresentes[0] + tempoPresentes[1] > N)
        {
            saida = "Deixa para amanha!";
        }

        System.Console.WriteLine(saida);

    }
}