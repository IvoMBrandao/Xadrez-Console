using System;

namespace Tabuleiro
{
    internal class board
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public board(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; 
        }

        public Peca peca(int linhas,int colunas)
        {
            return pecas[linhas, colunas];
        }
    }
}
