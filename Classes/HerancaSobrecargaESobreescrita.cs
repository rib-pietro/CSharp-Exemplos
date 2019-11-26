using System;
using System.Collections.Generic;

namespace herancaEpolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
			Veiculo veiculoExemplo = new Veiculo();
			veiculoExemplo.acelerar();

			Motocicleta moto = new Motocicleta();
			moto.acelerar();
			
			// Olha que curioso, você pode adicionar numa lista de veiculos, uma moto! Ela herda de veiculo, por isso pode estar na lista.
			List<Veiculo> listaVeiculos = new List<Veiculo>();
			listaVeiculos.Add(moto);

        }
    }

	public class Veiculo {
		protected int numeroRodas = 4;
		protected string cor;
		protected string motor;
		protected string ambiente;

		public Veiculo() {
			this.cor = "Preto";
			this.motor = "1.3";
			this.ambiente = "terra";
		}

		// Exemplo de sobrecarga: método com mesmo nome, porém parâmetros diferentes.
		public Veiculo(int numeroRodas, string cor, string motor, string ambiente) {
			this.numeroRodas = numeroRodas;
			this.cor = cor;
			this.motor = motor;
			this.ambiente = ambiente;
		}

		// Exemplo de método virtual: que pode ser sobrescrito pelas classes 'filhas'
		public virtual void acelerar() {
			Console.WriteLine("vrummmm");
		} 

		public virtual void acelerar(double ganhoDePotencia) {
			Console.WriteLine($"vrummmm a {ganhoDePotencia} por hora");
		} 
	}

	public class Motocicleta : Veiculo {
		protected string combustivel;

		public Motocicleta() {
			this.numeroRodas = 2;
			this.motor = "250cc";
			this.cor = "Vermelho";
			this.combustivel = "gasolina";
		}

		// Método sobrescrito
		public override void acelerar() {
			Console.WriteLine("Virando a manopla");
		}
	}
}
