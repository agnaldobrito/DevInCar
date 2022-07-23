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
                var motosOuTriciclos =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.MotosOuTriciclos)
                    && veiculo.VeiculoVendido == true);

                var menorPreco = motosOuTriciclos.OrderBy(maisBarato => maisBarato.Valor).First();

                Console.WriteLine(menorPreco.ListarInfo());
            }
        }
        public static void FiltrarCarros(int opcao)
        {

            if (opcao == 1)
            {
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
                var carros =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Carros)
                    && veiculo.VeiculoVendido == true);

                var menorPreco = carros.OrderByDescending(maisBarato => maisBarato.Valor).First();

                Console.WriteLine(menorPreco.ListarInfo());


            }
        }
        public static void FiltrarCaminhonetes(int opcao)
        {

            if (opcao == 1)
            {
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
                var caminhonetes =
                Data.veiculos.Where(
                    veiculo =>
                    veiculo.TipoVeiculo.Equals(EOpcoesVeiculos.Carros)
                    && veiculo.VeiculoVendido == true);

                var menorPreco = caminhonetes.OrderByDescending(maisBarato => maisBarato.Valor).First();

                Console.WriteLine(menorPreco.ListarInfo());


            }
        }
    }
}
