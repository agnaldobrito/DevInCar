using DevInCar.Models;
using DevInCar.Enums;

List<Carro> carros = new()
{
    new Carro ( totalPortas: 4,tipoCombustivel: ECombustiveis.Flex, nome: "Toyota - Etios",
                valor: 69.999m, cor: ECores.Preto, potencia: 92 ),
    new Carro ( 2, ECombustiveis.Gasolina, "Mazda - RX7", 189.999m, ECores.Vermelho, 143 ),
    new Carro ( 2, ECombustiveis.Gasolina, "Nissan - NSX 2000", 210.000m, ECores.Azul, 273 ),
    new Carro ( 2, ECombustiveis.Gasolina, "Mitsubishi - Lancer EVO V", 215.999m, ECores.Branco, 298 )
};