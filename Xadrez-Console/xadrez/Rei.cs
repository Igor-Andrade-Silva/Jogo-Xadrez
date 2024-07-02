using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {            
        }
        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca P = Tab.Peca(pos);
            return P == null || P.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao Pos = new Posicao(0,0);

            // Acima
            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos)){
                mat[Pos.Linha, Pos.Coluna] = true;
            }
            // Diagonal cima direita
            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
            }
            // Direita
            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
            }
            // Digonal baixo direita
            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
            }
            // Abaixo
            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
            }
            //Diagonal baixo esquerda
            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
            }
            // Esquerda
            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
            }
            // Diagonal cima esquerda
            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
            }
            return mat;
        }
    }
}
