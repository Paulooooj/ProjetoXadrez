
using tabuleiro;

namespace Xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, Colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public void ColocarPeca(Peca p, Posicao ps)
        {
            pecas[ps.Linha, ps.Coluna] = p;
            p.Posicao = ps;
        }
    }
}
