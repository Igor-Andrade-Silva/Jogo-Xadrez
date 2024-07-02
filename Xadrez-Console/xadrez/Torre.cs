using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "T";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca P = Tab.Peca(pos);
            return P == null || P.Cor != Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao Pos = new Posicao(0, 0);

            // Acima
            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.Linha -= 1;
            }
            // Abaixo
            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.Linha += 1;
            }
            //Direita
            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
                while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
                {
                    mat[Pos.Linha, Pos.Coluna] = true;
                    if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                    {
                        break;
                    }
                    Pos.Coluna += 1;
                }
                //Esquerda
                Pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
                while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
                {
                    mat[Pos.Linha, Pos.Coluna] = true;
                    if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                    {
                        break;
                    }
                    Pos.Coluna -= 1;
                }
            return mat;
        }
            
        
    }
}
