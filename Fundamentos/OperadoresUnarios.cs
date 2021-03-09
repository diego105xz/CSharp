using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valoresNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var boleano = true;

            Console.WriteLine(-valoresNegativo);
            Console.WriteLine(!boleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            /* Decrementação do numero2 será prioridade, logo em seguida será feita a
             * comparação entre o numero1 e numero2 dando resultado true.
             * Depois será feita a incrementação do numero1.
             * Isso acontece por que --numero2 é prioridade neste caso.
             * numero1++ não é prioridade, pois o sinal na frente influencia no resultado.
             * Exemplo:
                ++x  1ºExecução
                ==   2ºExecução
                x++  3ºExecução*/
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
