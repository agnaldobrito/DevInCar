using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Models;
using DevInCar.Enums;


namespace DevInCar.Dapper
{
    public static class Data
    {
        public static List<Veiculo> veiculos = new()
        {
                new Carro ( totalPortas: 4, tipoCombustivel: ECombustiveis.Flex, nome: "Toyota - Etios",
                valor: 69999, cor: ECores.Preto, potencia: 92, veiculoVendido: true ),
                new Carro ( 2, ECombustiveis.Gasolina, "Mazda - RX7", 189999, ECores.Vermelho, 143, true ),
                new Carro ( 2, ECombustiveis.Gasolina, "Nissan - NSX 2000", 210000, ECores.Azul, 273, false ),
                new Carro ( 4, ECombustiveis.Gasolina, "Mitsubishi - Lancer EVO V", 215999, ECores.Branco, 298, false ),

                new MotoTriciclo( totalRodas: 2, nome: "Suzuki - Hayabusa", valor: 120000, cor:ECores.Amarelo, potencia:175, false ),
                new MotoTriciclo( 3, "Tuk-tuk", 23500, ECores.Laranja, 107, true),
                new MotoTriciclo( 2, "Suzuki - GSX-R1000R", 60500, ECores.Branco, 107, true),
                new MotoTriciclo( 2, "Honda - CG 160", 45500, ECores.Cinza, 107, false),

                new Caminhonete( capacidadeCarga: 220.5m, totalPortas: 4,ECombustiveis.Diesel, nome: "Toyota - Hylux",
                                 valor:189999, ECores.Roxo, potencia: 277, veiculoVendido: true ),
                new Caminhonete(215, 2, ECombustiveis.Diesel, "Mitsubishi - L200", 130500, ECores.Roxo, 239, false)
        };
        
    }
}
