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
        public board tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtemovimentos, board tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qtemovimentos = 0;
            this. tab = tab;
        }
    }
}
