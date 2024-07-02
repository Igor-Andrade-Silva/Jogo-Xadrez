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
                    Console.Clear();
                    Tela.ImprimirTabuleiro(Partida.Tab);

                    Console.Write("Origem: ");
                    Posicao Origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino ");
                    Posicao Destino = Tela.LerPosicaoXadrez().ToPosicao();

                    Partida.ExecutaMovimento(Origem, Destino);
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