using tabuleiro;
using Xadrez_Console;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.WriteLine();
        }
    }
}