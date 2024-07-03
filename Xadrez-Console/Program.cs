using tabuleiro;
using Xadrez_Console;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez Partida = new PartidaDeXadrez();

                while (!Partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(Partida.Tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + Partida.Turno);
                        Console.WriteLine("Aguardando jogada: " + Partida.JogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao Origem = Tela.LerPosicaoXadrez().ToPosicao();
                        Partida.ValidarPosicaoDeOrigem(Origem);

                        bool[,] PosicoesPossiveis = Partida.Tab.Peca(Origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(Partida.Tab, PosicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino ");
                        Posicao Destino = Tela.LerPosicaoXadrez().ToPosicao();
                        Partida.ValidarPosicaoDeDestino(Origem, Destino);

                        Partida.RealizaJogada(Origem, Destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                
               
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }
    }
}