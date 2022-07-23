using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevInCar.Models;
using DevInCar.Enums;

namespace DevInCar.Dapper
{
    public class DataFilter
    {
        public static void FiltrarMotos(int opcao)
        {
            

            if (opcao == 1)
            {
                

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLista de motos ou triciclos disponíveis\n");
                Console.ForegroundColor = ConsoleColor.White;

                var motosOuTriciclos =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.MotosOuTriciclos)
                    && veiculo.VeiculoVendido != true);

                foreach (var motoOuTricilo in motosOuTriciclos)
                {
                    Console.WriteLine(motoOuTricilo.ListarInfo());
                }
            }
            if (opcao == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLista de motos ou triciclos vendidos\n");
                Console.ForegroundColor = ConsoleColor.White;
                var motosOuTriciclos =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.MotosOuTriciclos)
                    && veiculo.VeiculoVendido == true);

                foreach (var motoOuTricilo in motosOuTriciclos)
                {
                    Console.WriteLine(motoOuTricilo.ListarInfo());
                }
            }
            if (opcao == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nMoto ou triciclo com o MAIOR preço\n");
                Console.ForegroundColor = ConsoleColor.White;
                var motosOuTriciclos =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.MotosOuTriciclos)
                    && veiculo.VeiculoVendido == true);

                var maiorPreco = motosOuTriciclos.OrderByDescending(maisCaro => maisCaro.Valor).First();

                Console.WriteLine(maiorPreco.ListarInfo());
            }
            if (opcao == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nMoto ou triciclo com o MENOR preço\n");
                Console.ForegroundColor = ConsoleColor.White;

                var motosOuTriciclos =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.MotosOuTriciclos)
                    && veiculo.VeiculoVendido == true);

                var menorPreco = motosOuTriciclos.OrderBy(maisBarato => maisBarato.Valor).First();

                Console.WriteLine(menorPreco.ListarInfo());
            }
            if(opcao == 5)
            {
                Console.Clear();
            }
            
        }
        public static void FiltrarCarros(int opcao)
        {

            if (opcao == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLista de carros disponíveis\n");
                Console.ForegroundColor = ConsoleColor.White;

                var carros =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Carros)
                    && veiculo.VeiculoVendido != true);

                foreach (var carro in carros)
                {
                    Console.WriteLine(carro.ListarInfo());
                }
            }
            if (opcao == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLista de carros vendidos\n");
                Console.ForegroundColor = ConsoleColor.White;

                var carros =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Carros)
                    && veiculo.VeiculoVendido == true);

                foreach (var carro in carros)
                {
                    Console.WriteLine(carro.ListarInfo());
                }
            }
            if (opcao == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nCarro com o MAIOR preço\n");
                Console.ForegroundColor = ConsoleColor.White;

                var carros =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Carros)
                    && veiculo.VeiculoVendido == true);

                var maiorPreco = carros.OrderBy(maisCaro => maisCaro.Valor).First();

                Console.WriteLine(maiorPreco.ListarInfo());


            }
            if (opcao == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nCarro com o MENOR preço\n");
                Console.ForegroundColor = ConsoleColor.White;
                var carros =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Carros)
                    && veiculo.VeiculoVendido == true);

                var menorPreco = carros.OrderByDescending(maisBarato => maisBarato.Valor).First();

                Console.WriteLine(menorPreco.ListarInfo());


            }
            if (opcao == 5)
            {
                Console.Clear();
            }
        }
        public static void FiltrarCaminhonetes(int opcao)
        {

            if (opcao == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLista de caminhonetes disponíveis\n");
                Console.ForegroundColor = ConsoleColor.White;

                var caminhonetes =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Caminhonetes)
                    && veiculo.VeiculoVendido != true);

                foreach (var caminhonete in caminhonetes)
                {
                    Console.WriteLine(caminhonete.ListarInfo());
                }
            }
            if (opcao == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLista de caminhonetes vendidas\n");
                Console.ForegroundColor = ConsoleColor.White;

                var caminhonetes =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Caminhonetes)
                    && veiculo.VeiculoVendido == true);

                foreach (var caminhonete in caminhonetes)
                {
                    Console.WriteLine(caminhonete.ListarInfo());
                }
            }
            if (opcao == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nCaminhonete com o MAIOR preço\n");
                Console.ForegroundColor = ConsoleColor.White;

                var caminhonetes =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Caminhonetes)
                    && veiculo.VeiculoVendido == true);

                var maiorPreco = caminhonetes.OrderBy(maisCaro => maisCaro.Valor).First();

                Console.WriteLine(maiorPreco.ListarInfo());


            }
            if (opcao == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nCaminhonete com o MENOR preço\n");
                Console.ForegroundColor = ConsoleColor.White;
                var caminhonetes =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Caminhonetes)
                    && veiculo.VeiculoVendido == true);

                var menorPreco = caminhonetes.OrderByDescending(maisBarato => maisBarato.Valor).First();

                Console.WriteLine(menorPreco.ListarInfo());


            }
            if (opcao == 5)
            {
                Console.Clear();
            }
        }
    }
}
