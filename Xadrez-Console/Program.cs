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
                        Tela.ImprimirPartida(Partida);
                        

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
                Console.Clear();
                Tela.ImprimirPartida(Partida);
                
               
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }
    }
}