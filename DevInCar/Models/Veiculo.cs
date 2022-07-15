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
        public DateTime DataTransferencia { get; private set; }
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
            NumeroChassi =  GerarNumeroChassi();
            DataTransferencia = DataRegistrada();
        }
        public Veiculo(string nome, decimal valor, ECores cor, int potencia,bool veiculoVendido)
        {
            Nome = nome;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
            VeiculoVendido = veiculoVendido;
            CpfComprador = "";
            NumeroChassi = GerarNumeroChassi();
            DataTransferencia = DataRegistrada();
        }

        public void VenderVeiculo()
        {
            if (VeiculoVendido == true)
            Console.WriteLine("Error: O veiculo ja foi vendido");
            else
            VeiculoVendido = true;
        }

        public void ListarInfo()
        {

        }

        public virtual ECores AlterarCor(ECores cor)
        {
            return Cor = cor;
        }
        public  decimal  AlterarValor(decimal valor)
        {
            if(Valor > 0)
            {

            return Valor = valor;
            }
            else
            {
                return Valor;
            }
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

        private DateTime DataRegistrada()
        {
            Random random = new Random();
            DateTime dataInicial = new DateTime(2018,1,1);
            int tempoPercorrido = (DateTime.Today - dataInicial).Days;
            return dataInicial.AddDays(random.Next(tempoPercorrido))
                              .AddHours(random.Next(0, 24))
                              .AddMinutes(random.Next(0, 60));
        }

        
    }
}
