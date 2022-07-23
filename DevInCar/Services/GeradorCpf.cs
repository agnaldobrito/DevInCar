using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInCar.Services
{
    public class GeradorCpf
    {
        public static string GerarCpf()
        {
            var random = new Random();

            int soma = 0;
            int resto = 0;
            int[] multiplicadores = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpf;

            do
            {
                cpf = random.Next(1, 999999999).ToString().PadLeft(9, '0');
            }
            while (
                cpf == "000000000"
                || cpf == "111111111"
                || cpf == "222222222"
                || cpf == "333333333"
                || cpf == "444444444"
                || cpf == "555555555"
                || cpf == "666666666"
                || cpf == "777777777"
                || cpf == "888888888"
                || cpf == "999999999"
            );

            for (int i = 1; i < multiplicadores.Count(); i++)
                soma += int.Parse(cpf[i - 1].ToString()) * multiplicadores[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            cpf += resto;
            soma = 0;

            for (int i = 0; i < multiplicadores.Count(); i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            cpf = cpf + resto;

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
    }
}
