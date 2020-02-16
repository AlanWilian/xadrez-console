using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada) {

                    try {
                        Console.Clear();
                        Tela.imprimirPartida(partida);
                        //Tela.imprimirTabuleiro(partida.tab);

                        //Console.WriteLine();
                        //Console.WriteLine("Turno: " + partida.turno);
                        //Console.WriteLine("Aguardando Jogada: " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.Peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);
                                               
                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    Console.Clear();
                    Tela.imprimirPartida(partida);
                }
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}
