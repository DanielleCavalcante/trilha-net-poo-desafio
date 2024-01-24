using DesafioPOO.Models;

    Console.WriteLine("Escolha o tipo de telefone:");
    Console.WriteLine("1 - iPhone");
    Console.WriteLine("2 - Nokia");
    Console.Write("Digite o número correspondente ao telefone desejado: ");
    string escolha = Console.ReadLine();

    Smartphone telefone = null;

    switch (escolha)
    {
        case "1":
        telefone = new Iphone("123456789", "iPhone 15", "IMEI123", 256);
        break;

        case "2":
        telefone = new Nokia("987654321", "Nokia 3030", "IMEI321", 128);
        break;

        default:
        Console.WriteLine("Opção inválida!");
        return;
    }

    bool exibirMenu = true;

    while (exibirMenu)
    {
        Console.Clear();
        Console.WriteLine("--- Menu de opções ---\n");
        Console.WriteLine("1 - Ligar");
        Console.WriteLine("2 - Receber ligação");
        Console.WriteLine("3 - Instalar aplicativo");
        Console.WriteLine("4 - Exibir informações");
        Console.WriteLine("5 - Sair");
        Console.Write("\nDigite a sua opção: ");

        switch (Console.ReadLine())
        {
            case "1":
                telefone.Ligar();
                break;

            case "2":
                telefone.ReceberLigacao();
                break;

            case "3":
                Console.Write("\nDigite o aplicativo que deseja instalar: ");
                string appInstalar = Console.ReadLine();
                telefone.InstalarAplicativo(appInstalar);
                break;

            case "4":
                telefone.ExibirInformacoes();
                break;
            
            case "5":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.Write("\nPressione qualquer tecla para continuar: ");
        Console.ReadLine();
    }

    Console.WriteLine("\nO programa se encerrou!");