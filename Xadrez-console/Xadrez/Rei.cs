﻿
using Xadrez_console.tabuleiro;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro ) :base(cor, tabuleiro)
        {

        }
        public override string ToString()
        {
            return "R";
        }

    }
}