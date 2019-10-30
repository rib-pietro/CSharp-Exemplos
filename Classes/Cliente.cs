/*
    Autoria dos alunos: Waldir Rugno Filho, Cleberson Nascimento, Paulo Ilarde, Everton Souza
*/
namespace Exemplo_de_classes_veiculos
{
    class Cliente
    {
        public Cliente(string nomeCliente, double rendaCliente, string ocupacaoCliente)
        {   // atributos de classe
            this.nome = nomeCliente;
            this.renda = rendaCliente;
            this.ocupacao = ocupacaoCliente;
        }
        private string nome;
        public void setNome(string nomeCliente)
        {
            this.nome = nomeCliente;
        }
        public string getNome()
        {
            return this.nome;
        }
        private double renda;
        public void setRenda(double rendaCliente)
        {
            this.renda = rendaCliente;
        }
        public double getRenda()
        {
            return this.renda;
        }
        private string ocupacao;
        public void setOcupacao(string ocupacaoCliente)
        {
            this.ocupacao = ocupacaoCliente;
        }
        public string getOcupacao()
        {
            return this.ocupacao;
        }
    }
}