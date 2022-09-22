using Tabuleiro;


namespace Xadrez_Console.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(board tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
