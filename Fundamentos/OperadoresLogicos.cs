using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {

            /* Se trabalhar 1 vez compra TV de 32" e compra sorvete.
             Se trabalhar 2 vezes compra TV de 32" e comrpa sorvete.
             Se não trabalhar não compra TV e nem sorvete, porem ficará mais saudavel sem açucar rs.*/
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o Sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais Saudável? {0}", !comprouSorvete);
        }
    }
}
