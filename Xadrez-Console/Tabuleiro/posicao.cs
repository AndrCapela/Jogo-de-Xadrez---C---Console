﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.tabuleiro {
    class Posicao {
        public int linha;
        public int coluna;

        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }
        public override string ToString() {
            return linha + ", " + coluna;
        }
        public void definirValores(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

    }
}
