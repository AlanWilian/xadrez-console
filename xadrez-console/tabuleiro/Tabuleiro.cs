﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class Tabuleiro {

        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linha, int coluna) {
            return pecas[linha, coluna];

        }

        public Peca Peca(Posicao pos) {
            return pecas[pos.linha, pos.coluna];

        }

        public void colocarPeca(Peca p, Posicao pos) {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;    
        }

        public bool posicaoValida(Posicao pos) {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna>=colunas) {
                return false;
            }
            return true;
        }
    }





}
