using System.Net.WebSockets;
using tabuleiro;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao ps = new Posicao(3, 4);


            Console.WriteLine(ps);
        }
    }
}