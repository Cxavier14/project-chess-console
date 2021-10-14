﻿using System;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
    }
}
