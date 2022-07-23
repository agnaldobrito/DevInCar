using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInCar.Services
{
    internal class GeradorPlaca
    {
        public static string GerarPlaca()
        {
            Random random = new Random();
            string digitosPossiveis = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(
                Enumerable.Repeat(digitosPossiveis, 7)
                .Select(digito =>
                digito[random.Next(digito.Length)])
                .ToArray()
                );
        }
    }
}
