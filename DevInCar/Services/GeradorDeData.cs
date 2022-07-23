using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInCar.Services
{
    public class GeradorDeData
    {
        public static DateTime GerarData()
        {
            Random random = new Random();
            DateTime dataInicial = new DateTime(2020, 1, 1);
            int tempoPercorrido = (DateTime.Today - dataInicial).Days;
            return dataInicial.AddDays(random.Next(tempoPercorrido))
                              .AddHours(random.Next(0, 24))
                              .AddMinutes(random.Next(0, 60));
        }
    }
}
