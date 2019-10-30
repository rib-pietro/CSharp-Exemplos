/*
    Autoria dos alunos: Waldir Rugno Filho, Cleberson Nascimento, Paulo Ilarde, Everton Souza
*/
namespace Exemplo_de_classes_veiculos
{
    class Veiculo
    {
        public Veiculo(string modeloVeiculo, int anoVeiculo, double precoVeiculo) // esse é o metodo? ou declaracao dos atributos?
        {
            this.modelo = modeloVeiculo;
            this.ano = anoVeiculo;
            this.preco = precoVeiculo;
        }
        private string modelo;
        public void setModelo(string modeloVeiculo)
        {
            this.modelo = modeloVeiculo;
        }
        public string getModeloVeiculo()
        {
            return this.modelo;
        }
        private int ano;
        public void setAno(int anoVeiculo)
        {
            this.ano = anoVeiculo;
        }
        public int getanoVeiculo()
        {
            return this.ano;
        }
        private double preco;
        public void setPreco(double precoVeiculo)
        {
            this.preco = precoVeiculo;
        }
        public double getprecoVeiculo()
        {
            return this.preco;
        }
    }
}