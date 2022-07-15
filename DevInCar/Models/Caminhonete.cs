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

        public Caminhonete(

            decimal capacidadeCarga, int totalPortas,
            string nome, decimal valor, ECores cor, int potencia

            ) : base(nome,valor,cor,potencia)
        {
            CapacidadeCarga = capacidadeCarga;
            TotalPortas = totalPortas;
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
