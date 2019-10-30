/*
    Autoria dos Alunos: Hilton Neto, Felipe Bonato, Euller Silva, Vanderlei Dultra
*/
using System;

namespace CSharp_Exemplos {
     class ExemploForEach {
        public static void ExemplosForEach() {
            // Exemplo 1 de foreach
            string[] nomes = new string[]{"João","José","Maria"};
​
            foreach(string nome in nomes) {
                Console.WriteLine(nome);
            }
​
            // Exemplo 2 de foreach
            int[] numeros = new int[]{1,2,3,4,5};
​
            foreach(int numero in numeros) {
                Console.WriteLine(numero);
            }
​
            // Exemplo 3 de foreach/while
            int[] exemplo3Array = new int[3];
            
            bool continuarLoop = true;
            Console.WriteLine("Digite 3 números");
                while(continuarLoop) {
                    for(int i = 0; i < exemplo3Array.Length;i++) {
                        exemplo3Array[i] = Convert.ToInt32(Console.ReadLine());
​
                    }
                    continuarLoop = false;
                }
​
            foreach(int num3 in exemplo3Array) {
                Console.WriteLine("Seus números foram {0}",num3);
            }
        }
    }
}
