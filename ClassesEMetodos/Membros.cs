using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Reanto";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} Tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var ApresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(ApresentacaoDoFulano.Length);
            Console.WriteLine(ApresentacaoDoFulano);
        }
    }
}