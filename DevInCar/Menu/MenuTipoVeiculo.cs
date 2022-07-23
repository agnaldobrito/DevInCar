using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Enums;
namespace DevInCar.Menu
{
    public static class MenuTipoVeiculo
    {
        public static void ExibirMenuTipoVeiculo()
        {
            foreach(int index in Enum.GetValues(typeof(EOpcoesVeiculos)))
            {
                Console.WriteLine($" {index} -> {Enum.GetName(typeof(EOpcoesVeiculos),index)}");
            }
        }
    }
}
