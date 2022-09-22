using System;
using Tabuleiro;
using Xadrez;
using xadrez_console;
using Xadrez_Console.Xadrez;

namespace xadrez_console
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partida.Tab);

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab);
                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerposicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerposicaoXadrez().ToPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch(TabuleiroExeption ex)
            {
               Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}