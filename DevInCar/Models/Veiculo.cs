using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Enums;
using DevInCar.Services;
namespace DevInCar.Models
{
    public abstract class Veiculo
    {
        public EOpcoesVeiculos TipoVeiculo { get; set; }
        public string Nome { get; private set; }
        public string Placa { get; private set; }
        public double Valor { get; protected set; }
        public ECores Cor { get; protected set; }
        public DateTime DataFabricacao { get; private set; }
        public DateTime DataCompra { get; private set; }
        public string NumeroChassi { get; private set; }
        public string CpfComprador { get; private set; }
        public int Potencia { get; private set; }
        public bool VeiculoVendido { get; private set; }


        public Veiculo(string nome, double valor, ECores cor, int potencia, bool veiculoVendido)
        {

            Nome = nome;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
            VeiculoVendido = veiculoVendido;
            CpfComprador = "0";

            if (veiculoVendido == true)
            {
                Random random = new Random();
                CpfComprador = CapturarCpfComprador();
                DataCompra = DateTime.Now;
            }

            Placa = CapturarPlacaVeiculo();
            NumeroChassi = CapturarNumeroChassi();
            DataFabricacao = CapturarDataHora();
        }

        public void VenderVeiculo()
        {
            Random random = new Random();
            if (VeiculoVendido == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n --> ERROR: O veiculo ja foi vendido\n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                VeiculoVendido = true;
                CpfComprador = CapturarCpfComprador();
                DataCompra = DateTime.Now;

            }
        }

        public string ListarInfo()
        {
            if (VeiculoVendido == false)
            {
                return $"Nome: {Nome}\nPlaca: {Placa}\nCor: {Cor}\nData de fabricação: {DataFabricacao}\n"+
                       $"\n------------------\n";

            }
            else
            {
                return $"Nome: {Nome}\nPlaca: {Placa}\nCor: {Cor}\nData de fabricação: {DataFabricacao}\n" +
                       $"Cpf do comprador: {CpfComprador}\n" +
                       $"Valor: {Valor}\n" +
                       $"Data da compra : {DataCompra}\n"+
                       $"\n------------------\n";
            }
        }

        public virtual ECores AlterarCor(ECores cor)
        {
            return Cor = cor;
        }
        public double AlterarValor(double valor)
        {
            if (Valor > 0)
            {
                return Valor = valor;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n --> ERROR: O valor não pode ser nulo\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                return Valor;
            }
        }

        private string CapturarNumeroChassi()
        {
            return GeradorNumeroChassi.GerarNumeroChassi();

        }
        private string CapturarCpfComprador()
        {
            return GeradorCpf.GerarCpf();
        }
        private DateTime CapturarDataHora()
        {
            return GeradorDeData.GerarData();
        }
        private string CapturarPlacaVeiculo()
        {
            return GeradorPlaca.GerarPlaca();
        }

    }
}
