using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Área da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true; // Verdadeiro ou Falso
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; // 1 Byte 0 a 256
            Console.WriteLine("idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // -128 a 127, inteiro com sinal
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue; // 2 byte
            Console.WriteLine("Saláro " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos Inteiros!
            Console.WriteLine("Menor Inteiro " + menorValorInt);

            uint populacaoBrasileira = 200_600_000; // 4 Byte, inteiro sem sinal
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // 8 Byte
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // logn sem sinal
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f; // 4 byte de armazenamento
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais. o Dobro do float
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // Valores muito grandes
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b'; // Unica letra
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!"; // Conjunto de letras
            Console.WriteLine(texto);

        }

    }
}
