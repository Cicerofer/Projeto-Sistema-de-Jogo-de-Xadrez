using System;
using System.Collections.Generic;
using System.Linq;
using tabuleiro;
using System;
using xadrez;

namespace xadres_console
{
    class Program
    {
      static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Laranja), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
