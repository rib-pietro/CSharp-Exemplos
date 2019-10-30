/*
    Autoria dos Alunos: Hilton Neto, Felipe Bonato, Euller Silva, Vanderlei Dultra
*/
using System;

namespace CSharp_Exemplos {
    class ExemploFor {
        public static void ExemplosFor() {
            Console.WriteLine("Exemplos de for");
​
            /* Exemplo for (contagem até 10) */
            for(int i=0; i <= 10;i++) {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            /* Exemplo 2 de for */
            Console.WriteLine("Insira sua idade");
            var idade = Convert.ToInt32(Console.ReadLine());
            /* Convertendo uma string em número inteiro */
​
            for (int i = 0; i < 1; i++) {
                if(idade >= 18) {
                    Console.WriteLine("Maior de idade");
                } else {
                    Console.WriteLine("Menor de idade");
                }
            }
            Console.ReadKey();

            // Exemplo 3 de for com pares e impares
            for(int i = 0; i <= 10; i++) {
                if(i % 2 == 0) {
                Console.WriteLine("O número é par {0}", i);
                } else {
                    Console.WriteLine("O número é impar {0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}