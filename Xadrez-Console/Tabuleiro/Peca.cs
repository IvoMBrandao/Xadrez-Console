using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtemovimentos { get;protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtemovimentos, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qtemovimentos = qtemovimentos;
            this. tab = tab;
        }
    }
}
