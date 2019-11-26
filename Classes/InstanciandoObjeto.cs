/*
    Autoria dos alunos: Waldir Rugno Filho, Cleberson Nascimento, Paulo Ilarde, Everton Souza
*/
using System; //importação do pacote system. 

namespace Exemplo_de_classes_veiculos
{
    class InstanciaObjeto
    {
        static void InstanciandoObjeto()
        {
​
            Vendedor vend1 = new Vendedor("Paulo", 5500.00, 100);  
            Vendedor vend2 = new Vendedor("Waldir", 6500.00, 100);
            Vendedor vend3 = new Vendedor ("Everton", 6000.00, 150);
​
            Cliente cliente1 = new Cliente("Cleberson", 30000.00, "Arquiteto de software");
            Cliente cliente2 = new Cliente("João", 20000.00, "Empresário" );
            Cliente cliente3 = new Cliente("Pedro", 25000.00, "Genrente de contas");           
            
            Veiculo veic1 = new Veiculo("Gla 2000 Amg", 2019, 300000);
            Veiculo veic2 = new Veiculo("Fusca", 1977, 250000);
​
            Console.WriteLine("Bem vindo ao sistema da agência de carro!!!!");
            Console.WriteLine("Vendedor do mês: " + vend1.getNome());
            Console.WriteLine("Cliente Vip: " + cliente1.getNome());
            Console.WriteLine("Carro comprado: " + veic1.getModeloVeiculo());
        }
    }
}