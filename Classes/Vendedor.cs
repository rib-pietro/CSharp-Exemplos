/*
    Autoria dos alunos: Waldir Rugno Filho, Cleberson Nascimento, Paulo Ilarde, Everton Souza
*/
namespace Exemplo_de_classes_veiculos
{
    class Vendedor
    {
        public Vendedor(/* parametro*/string nomeVendedor, double salarioVendedor, int qtdVeiculosVendedor) //construtor;
        {
            this.nome = nomeVendedor;
            this.salario = salarioVendedor;
            this.qtdVeiculos = qtdVeiculosVendedor;

        }
        private string nome; //criando atributo
        public void setNome(string nomeVendedor)
        {
            this.nome = nomeVendedor; // o que o metodo faz
        }
        public string getNome() 
        {
            return this.nome; 
        }
        private double salario;
        public void setSalario(double salarioVendedor)
        {
            this.salario = salarioVendedor;
        }
        public double getSalario()
        {
            return this.salario;
        }
        private int qtdVeiculos;
        public void setQtdVeiculos(int qtdVeiculosVendedor)
        {
            this.qtdVeiculos = qtdVeiculosVendedor;
        }
        public int getQtdveiculos()
        {
            return this.qtdVeiculos;
        }
    }
}