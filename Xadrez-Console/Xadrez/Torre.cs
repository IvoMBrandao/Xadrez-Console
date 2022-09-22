
using Tabuleiro;

namespace Xadrez_Console.Xadrez
{
    internal class Torre : Peca 
    {
        public Torre(board tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
    