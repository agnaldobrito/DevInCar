using DevInCar.Models;
using DevInCar.Enums;
using DevInCar.Menu;
using DevInCar.Dapper;



Console.WriteLine(" ===== Bem vind ao DevInCar =====\n\n");

while (true)
{
    Console.WriteLine("Selecione o tipo do veículo\n");
    Console.ForegroundColor = ConsoleColor.Yellow;
    MenuTipoVeiculo.ExibirMenuTipoVeiculo();
    Console.ForegroundColor = ConsoleColor.White;


    bool opcaoValida = int.TryParse(Console.ReadLine(), out int opcaoSelecionada);
    Console.WriteLine("----------------------------------\n");
    if (!opcaoValida || opcaoSelecionada < 1 || opcaoSelecionada > 4)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n ==== ERROR: Opção inválida ====\n\n");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }


    switch (opcaoSelecionada)
    {
        case (int)EOpcoesVeiculos.MotosOuTriciclos:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MenuVeiculoOpcoesInfo.MostrarMenuMotoTriciclo();
            Console.ForegroundColor = ConsoleColor.White;

            bool motoOpcaoInfoValida = int.TryParse(Console.ReadLine(), out int motoOpcaoInfoSelecionada);
            if (!motoOpcaoInfoValida || motoOpcaoInfoSelecionada < 1 || motoOpcaoInfoSelecionada > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n --> ERROR: Opção inválida\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                continue;
            }
            Console.WriteLine("\n==================================\n");
            DataFilter.FiltrarMotos(motoOpcaoInfoSelecionada);
            Console.WriteLine("\n==================================\n");


            break;

        case (int)EOpcoesVeiculos.Carros:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MenuVeiculoOpcoesInfo.MostrarMenuCarros();
            Console.ForegroundColor = ConsoleColor.White;

            bool carroOpcaoInfoValida = int.TryParse(Console.ReadLine(), out int carroOpcaoInfoSelecionada);
            if (!carroOpcaoInfoValida || carroOpcaoInfoSelecionada < 1 || carroOpcaoInfoSelecionada > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n --> ERROR: Opção inválida\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                continue;
            }
            Console.WriteLine("\n==================================\n");
            DataFilter.FiltrarCarros(carroOpcaoInfoSelecionada);
            Console.WriteLine("\n==================================\n");

            break;

        case (int)EOpcoesVeiculos.Caminhonetes:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MenuVeiculoOpcoesInfo.MostrarMenuCaminhonetes();
            Console.ForegroundColor = ConsoleColor.White;

            bool caminhoneteOpcaoInfoValida = int.TryParse(Console.ReadLine(), out int caminhoneteOpcaoInfoSelecionada);
            if (!caminhoneteOpcaoInfoValida || caminhoneteOpcaoInfoSelecionada < 1 || caminhoneteOpcaoInfoSelecionada > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n --> ERROR: Opção inválida\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                continue;
            }
            Console.WriteLine("\n==================================\n");
            DataFilter.FiltrarCaminhonetes(caminhoneteOpcaoInfoSelecionada);
            Console.WriteLine("\n==================================\n");

            break;

        case (int)EOpcoesVeiculos.Todos:
            Console.Clear();
            MenuVeiculoOpcoesInfo.MostrarMenuTodosVeiculos();

            Console.WriteLine("\n==================================\n");
            foreach (var veiculo in Data.veiculos)
            {
                Console.WriteLine(veiculo.ListarInfo());
            }
            Console.WriteLine("\n==================================\n");

            break;



    }
    

}