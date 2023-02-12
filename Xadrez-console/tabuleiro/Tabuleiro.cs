
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

        public Peca Peca (Posicao ps)
        {
            return pecas[ps.Linha, ps.Coluna];
        }
        public bool ExistePeca(Posicao ps)
        {
            ValidarPosicao(ps);
            return Peca(ps) != null;
        }
        public void ColocarPeca(Peca p, Posicao ps)
        {
            if (ExistePeca(ps)) {

                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[ps.Linha, ps.Coluna] = p;
            p.Posicao = ps;
        }
        public bool PosicaoValida(Posicao ps)
        {
            if (ps.Linha <  0 || ps.Linha >= Linhas || ps.Coluna < 0 || ps.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posicao ps)
        {
            if (!PosicaoValida(ps))
            {
                throw new TabuleiroException("Posição inválida!");
            }

        }
    }
}
