using System.Net.WebSockets;
using tabuleiro;
using Xadrez_console.tabuleiro;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Posicao ps = new Posicao(3, 4);

            Tabuleiro tb = new Tabuleiro(8, 8);
            
            Tela.ImprimirTabuleiro(tb);

            //Console.WriteLine(ps);
        }
    }
}