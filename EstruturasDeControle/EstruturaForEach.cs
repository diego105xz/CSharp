﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {   // Foreach serve pra pecorrer do primeiro ao ultimo elemento sem necessidade de criar uma variavel.
            var palavra = "Opa!";
            
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
