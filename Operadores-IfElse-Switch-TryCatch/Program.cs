/*
    Autoria dos alunos: Victor Hamuche, Alessandro Hamuche, Fabiana Felicissimo, José Euclides
*/
using System;

namespace ExemplosOperadorGit
{
    class Program
    {
        public static string callConsole() {
            System.Console.Write("> ");
            return Console.ReadLine();
        }

        public static void nextLine(){
            Console.ReadLine();
        }

        public static void endProgram(){
            System.Console.WriteLine("Parabens! Voce chegou no fim do programa de exemplos");
        }

        public static void saluteProgram() {
            System.Console.WriteLine("Bem-vindo ao nosso programa de exemplos de operadores logicos");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
            saluteProgram();
            System.Console.WriteLine("Vamos mostrar o que eh um 'char'");
            char caracter = 'a';
            // Vamos imprimir
            nextLine();
            System.Console.WriteLine("Nosso char: " + caracter);
            nextLine();            
            System.Console.WriteLine("Vamos ver o que eh um 'string'"); 
            string texto = "abcde1234";
            nextLine();
            System.Console.WriteLine("Nosso string: " + texto);
            // Um string nada mais eh do que um vetor de char.
            // Para comprovar isto vamos imprimir separadamente cada elemento da string.
            nextLine();
            System.Console.Write("Nosso string separado por char:");
            for (int i = 0; i < texto.Length; i++) {
                System.Console.Write(" " + texto[i]);
            }
            System.Console.WriteLine("");
            nextLine();
            System.Console.WriteLine("Temos diferentes formas de representar numeros reais.");
            nextLine();
            // Vamos investigar as diferencas de precisao entre formas basicas: float, double e decimal.
            float pifloat = (float)Math.PI;
            double pidouble = Math.PI;
            decimal pidecimal = (decimal)Math.PI;
            System.Console.WriteLine("Este eh o float: " + pifloat);
            nextLine();
            System.Console.WriteLine("Este eh o double: " + pidouble);
            nextLine();
            System.Console.WriteLine("Este eh o decimal: " + pidecimal);
            nextLine();
            System.Console.WriteLine("Teste de comparação");
            nextLine();
            double acumPiDouble = 0;
            decimal acumPiDecimal = 0;
            int totsoma = 10000000;
            for(int i = 0; i < totsoma; i++){
                acumPiDouble += pidouble;
                acumPiDecimal += pidecimal;
            }
            decimal dif = (decimal)acumPiDouble - acumPiDecimal;
            Console.WriteLine("A diferença em uma soma de {0} vezes é de apenas {1}", totsoma, dif);
            nextLine();
            System.Console.WriteLine("Vamos ver as diferencas entre operadores de comparacao");
            System.Console.WriteLine("Teste pifloat = pidouble?: " + (bool)(pifloat == pidouble));
            System.Console.WriteLine("Teste pifloat > pidouble?: " + (bool)(pifloat > pidouble));
            System.Console.WriteLine("Teste pifloat < pidouble?: " + (bool)(pifloat < pidouble));
            System.Console.WriteLine("Teste pifloat != pidouble?: " + (bool)(pifloat != pidouble));
            
            nextLine();
            System.Console.WriteLine("Operadores logicos && e || (E e OU)");
            nextLine();
            System.Console.WriteLine("Vamos fazer os testes usando && \"E\"");
            bool teste1 = true && true;
            bool teste2 = true && false;
            bool teste3 = false && false;
            System.Console.WriteLine("true && true = " + teste1);
            
            System.Console.WriteLine("true && false = " + teste2);
            
            System.Console.WriteLine("false && false = " + teste3);
            nextLine();
            System.Console.WriteLine("Vamos fazer os testes usando || \"OR\"");
            teste1 = true || true;
            teste2 = true || false;
            teste3 = false || false;
            System.Console.WriteLine("true || true = " + teste1);
            System.Console.WriteLine("true || false = " + teste2);
            System.Console.WriteLine("false || false = " + teste3);
            nextLine();
            System.Console.WriteLine("Exemplos de if/else com try/catch");
            System.Console.WriteLine("Por favor, digite um numero pro if/else: ");
            string aString = callConsole();
            try {
                int a = Convert.ToInt32(aString);
                    if (a == 1) {
                    System.Console.WriteLine("a = " + a);
                } else if (a == 2) {
                    System.Console.WriteLine("10 * a = " + 10*a);
                } else {
                    System.Console.WriteLine("100 * a = " + 100*a);
                }
            } catch (Exception e) {
                System.Console.WriteLine("Deu Erro! Voce nao digitou um numero!!!");
            }
            nextLine();
            System.Console.WriteLine("Exemplos de switch com try/catch");
            System.Console.WriteLine("Por favor, digite um numero pro switch: ");
            aString = callConsole();
            try {
                int a = Convert.ToInt32(aString);
                switch (a) {
                    case 1:
                        System.Console.WriteLine("a = " + a);
                        break;
                    case 2:
                        System.Console.WriteLine("10 * a = " + 10*a);
                        break;
                    default:    
                        System.Console.WriteLine("100 * a = " + 100*a);
                        break;
                }
            } catch (Exception e) {
                System.Console.WriteLine("Deu Erro! Você nao digitou um numero!!!");
            }
            endProgram();
        }
    }
}