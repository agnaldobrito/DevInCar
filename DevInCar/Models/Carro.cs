using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Enums;
namespace DevInCar.Models
{
    public class Carro : Veiculo
    {
        public int TotalPortas { get; set; }
        public ECombustiveis TipoCombustivel { get; set; }

        

        public Carro(

            int totalPortas, ECombustiveis tipoCombustivel,
            string nome, double valor, ECores cor, int potencia, bool veiculoVendido

            ) : base(nome, valor, cor, potencia,veiculoVendido)
        {
            TipoVeiculo = EOpcoesVeiculos.Carros;
            TotalPortas = totalPortas;

            if (tipoCombustivel != ECombustiveis.Diesel)
            {
                TipoCombustivel = tipoCombustivel;

            }
            else
            {

            }
        }


    }
}
