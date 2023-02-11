using System.Net.WebSockets;
using tabuleiro;
using Xadrez_console.tabuleiro;
using Xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Posicao ps = new Posicao(3, 4);

            Tabuleiro tb = new Tabuleiro(8, 8);

            tb.ColocarPeca(new Torre(Cor.Preta, tb), new Posicao(0, 0));
            tb.ColocarPeca(new Torre(Cor.Preta, tb), new Posicao(1, 3));
            tb.ColocarPeca(new Rei(Cor.Preta, tb), new Posicao(2, 4));


            Tela.ImprimirTabuleiro(tb);
        }
    }
}