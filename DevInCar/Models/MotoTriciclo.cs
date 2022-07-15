using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Enums;
namespace DevInCar.Models
{
    public class MotoTriciclo : Veiculo
    {
        public int TotalRodas { get; set; }
        public MotoTriciclo(

            int totalRodas,
            string nome, decimal valor, ECores cor,int potencia

            ) : base(nome,valor,cor,potencia)
        {
            TotalRodas = totalRodas;
        }
        public MotoTriciclo(

            int totalRodas,
            string nome, decimal valor, ECores cor, int potencia,
            bool veiculoVendido

            ) : base(nome, valor, cor, potencia, veiculoVendido)
        {
            TotalRodas = totalRodas;
        }

    }
}
