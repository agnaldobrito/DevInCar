using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Models;
using DevInCar.Enums;

namespace DevInCar.Menu
{
    
    public static class MenuVeiculoOpcoesInfo
    {
        public static void MostrarMenuMotoTriciclo()
        {
            Console.WriteLine(" 1 --> Motos/Tricilos disponíveis");
            Console.WriteLine(" 2 --> Motos/Tricilos vendidos");
            Console.WriteLine(" 3 --> Moto/Tricilo vendido com o maior preço");
            Console.WriteLine(" 4 --> Moto/Tricilo vendido com o menor preço");
        }
        public static void MostrarMenuCarros()
        {
            Console.WriteLine(" 1 --> Carros disponíveis");
            Console.WriteLine(" 2 --> Carros vendidos");
            Console.WriteLine(" 3 --> Carro vendido com o maior preço");
            Console.WriteLine(" 4 --> Carro vendido com o menor preço");
        }
        public static void MostrarMenuCaminhonetes()
        {
            Console.WriteLine(" 1 --> Caminhonetes disponíveis");
            Console.WriteLine(" 2 --> Caminhonetes vendidos");
            Console.WriteLine(" 3 --> Caminhonete vendido com o maior preço");
            Console.WriteLine(" 4 --> Caminhonete vendido com o menor preço");
        }
        public static void MostrarMenuTodosVeiculos()
        {
            Console.WriteLine(" 1 --> Todos os veículos disponíveis");
            Console.WriteLine(" 2 --> Todos os veículos vendidos");
            Console.WriteLine(" 3 --> Veículo vendido com o maior preço");
            Console.WriteLine(" 4 --> Veículo vendido com o menor preço");
        }

        
    }
}
