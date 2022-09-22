using System;
using Tabuleiro;
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
                board tab = new board(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 5));

                Tela.imprimirTabuleiro(tab);

               
            }
            catch(TabuleiroExeption ex)
            {
               Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}