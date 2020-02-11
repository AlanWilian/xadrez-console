﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.xadrez {
    class PosicaoXadrez {

        public int coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(int coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString() {
            return "" + coluna + linha;
        }

        public Posicao toPosicao() {
            return "" + coluna + linha;
        }
    }
}
