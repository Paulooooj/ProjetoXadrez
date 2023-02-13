using System.Net.WebSockets;
using tabuleiro;
using Xadrez_console.tabuleiro;
using Xadrez;
using Xadrez_console.Xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {




            PosicaoXadrez px = new PosicaoXadrez('c', 7);

            Console.WriteLine(px.ToPosicao());
            
            
            
            
            
            
            
            //Posicao ps = new Posicao(3, 4);

           /* try
            {


                Tabuleiro tb = new Tabuleiro(8, 8);

                tb.ColocarPeca(new Torre(Cor.Preta, tb), new Posicao(0, 0));
                tb.ColocarPeca(new Torre(Cor.Preta, tb), new Posicao(1, 3));
                tb.ColocarPeca(new Rei(Cor.Preta, tb), new Posicao(2, 4));
                tb.ColocarPeca(new Rei(Cor.Preta, tb), new Posicao(0, 0));



                Tela.ImprimirTabuleiro(tb);

            }
            catch(TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
           */
           
        }
    }
}