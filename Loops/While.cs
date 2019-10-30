/*
    Autoria dos Alunos: Hilton Neto, Felipe Bonato, Euller Silva, Vanderlei Dultra
*/
using System;

namespace CSharp_Exemplos {
        class ExemploWhile {
            public static void ExemplosWhile() {
                // Exemplo 1 de  while
                int contador = 0;

                while(contador  <= 10) {
                    Console.WriteLine(contador);
                    contador++;
                }

                // Exemplo 2 de while
                var continuarloop = true;
                
                while(continuarloop) {
                    Console.WriteLine("Insira um número");
                    Console.WriteLine();
    ​
                    int numeroExemplo2 = Convert.ToInt32(Console.ReadLine());
    ​
                    if (numeroExemplo2 % 2 == 0) {
                        Console.WriteLine("O número {0} é par", numeroExemplo2);
                    } else {
                        Console.WriteLine("O número {0} é impar", numeroExemplo2);
                        continuarloop = false;
                    }
                }
    ​
                // Exemplo 3 de While
                int[] numerosExemplo3 = new int[5];
                
                bool continuarLoopExemplo3 = true;
                Console.WriteLine("Digite 5 números");
    ​
                while(continuarLoopExemplo3) {
                    for(int i = 0; i < numerosExemplo3.Length;i++) {
    ​
                        numerosExemplo3[i] = Convert.ToInt32(Console.ReadLine());
                        
                    }
                    Console.WriteLine("Seu números foram {0},{1},{2},{3},{4}",array1[0],array1[1],array1[2],array1[3], array1[4]);
                    continuarLoopExemplo3 = false;
                }
            }
    }
}