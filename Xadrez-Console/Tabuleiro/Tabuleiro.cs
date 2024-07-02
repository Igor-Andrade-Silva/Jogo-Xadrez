using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linhas, int colunas)
        {
            return Pecas[linhas, colunas];
        }

        public void ColocarPeca(Peca p, Posicao pos) 
        {
            Pecas[pos.Linha, pos.Coluna] = p;    
            p.Posicao = pos;
        }
    }
}
