using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Enums;

namespace DevInCar.Models
{
    public class Caminhonete : Veiculo
    {
        public decimal CapacidadeCarga { get; set; }
        public int TotalPortas { get; set; }
        public ECombustiveis TipoCombustivel { get; set; }

        

        public Caminhonete(

            decimal capacidadeCarga, int totalPortas, ECombustiveis tipoCombustivel,
            string nome, double valor, ECores cor, int potencia, bool veiculoVendido

            ) : base(nome, valor, cor, potencia, veiculoVendido)
        {
            TipoVeiculo = EOpcoesVeiculos.Caminhonetes;
            Cor = ECores.Roxo;
            CapacidadeCarga = capacidadeCarga;
            TotalPortas = totalPortas;
            if (tipoCombustivel != ECombustiveis.Flex)
            {
                TipoCombustivel = tipoCombustivel;
            }
        }

        public override ECores AlterarCor(ECores cor)
        {
            if(cor != ECores.Roxo)
            {
                Console.WriteLine("Desculpe, só há a cor Roxo disponível para caminhonetes");
                return Cor = ECores.Roxo;
            }
            else
            {
                return Cor = ECores.Roxo;
            }
        }
    }
}
