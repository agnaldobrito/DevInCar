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
            string nome, decimal valor, ECores cor, int potencia

            ) : base(nome,valor,cor,potencia)
        {
            TotalPortas = totalPortas;
            TipoCombustivel = tipoCombustivel;
        }
    }
}
