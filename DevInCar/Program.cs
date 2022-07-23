using DevInCar.Models;
using DevInCar.Enums;
using DevInCar.Menu;
using DevInCar.Dapper;



Console.WriteLine(" ===== Bem vind ao DevInCar =====\n\n");

while (true)
{

    MenuTipoVeiculo.ExibirMenuTipoVeiculo();

    bool opcaoValida = int.TryParse(Console.ReadLine(), out int opcaoSelecionada);
    Console.WriteLine("----------------------------------");
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
            MenuVeiculoOpcoesInfo.MostrarMenuMotoTriciclo();

            bool motoOpcaoInfoValida = int.TryParse(Console.ReadLine(), out int motoOpcaoInfoSelecionada);
            if (!motoOpcaoInfoValida || motoOpcaoInfoSelecionada < 1 || motoOpcaoInfoSelecionada > 4)
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
            MenuVeiculoOpcoesInfo.MostrarMenuCarros();

            bool carroOpcaoInfoValida = int.TryParse(Console.ReadLine(), out int carroOpcaoInfoSelecionada);
            if (!carroOpcaoInfoValida || carroOpcaoInfoSelecionada < 1 || carroOpcaoInfoSelecionada > 4)
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
            MenuVeiculoOpcoesInfo.MostrarMenuCaminhonetes();

            bool caminhoneteOpcaoInfoValida = int.TryParse(Console.ReadLine(), out int caminhoneteOpcaoInfoSelecionada);
            if (!caminhoneteOpcaoInfoValida || caminhoneteOpcaoInfoSelecionada < 1 || caminhoneteOpcaoInfoSelecionada > 4)
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