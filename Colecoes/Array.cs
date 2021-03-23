using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            
            double somatoria = 0;
            double[] notas = { 3.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas)
            {
                somatoria += nota;
            }

            double media = somatoria / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
