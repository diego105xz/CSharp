using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá ".ToUpper().Insert(3, " world!")
                .Replace("world!", "Mundo!");

            Console.WriteLine(saudacao);

                //Length conta as letras
            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
           
    }
}
