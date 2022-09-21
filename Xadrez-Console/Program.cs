using System;
using Tabuleiro;
using xadrez_console;

namespace xadrez_console
{
    class program
    {
        static void Main(string[] args)
        {
            Tabuleiro.board tab = new board(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();
        }
    }
}