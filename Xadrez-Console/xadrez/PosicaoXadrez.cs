﻿using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.tabuleiro;


namespace Xadrez_Console.xadrez {
    class PosicaoXadrez {
        public char coluna;
        public int linha;

        public PosicaoXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString() {
            return "" + coluna + linha;
        }

        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a');
        }
        
    }
}