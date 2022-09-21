using System;
using Tabuleiro;

namespace xadrez_console
{
    class program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4); 

            Console.WriteLine("Posião " + P.ToString());
        }
    }
}