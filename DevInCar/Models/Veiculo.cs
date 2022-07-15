using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Enums;

namespace DevInCar.Models
{
    public abstract class Veiculo
    {
        public string Nome { get; protected set; }
        public string Placa { get; private set; }
        public decimal Valor { get; protected set; }
        public ECores Cor { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string NumeroChassi { get; private set; }
        public string CpfComprador { get; private set; }
        public int Potencia { get; set; }
        public bool VeiculoVendido { get; set; }

        public Veiculo(string nome,decimal valor,ECores cor,int potencia)
        {
            Nome = nome;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
            VeiculoVendido = false;
            CpfComprador = "";
        }

        public void VenderVeiculo()
        {
            VeiculoVendido = true;
        }

        public void ListarInfo()
        {

        }

        public virtual ECores AlterarCor(ECores cor)
        {
            return Cor = cor;
        }
        private string GerarNumeroChassi()
        {
            Random random = new Random();
            string digitosPossiveis = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(
                Enumerable.Repeat(digitosPossiveis, 17)
                .Select(digito =>
                digito[random.Next(digito.Length)])
                .ToArray()
                );
        }
    }
}
