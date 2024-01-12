using estacionamentoconfig.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal inicial = 0;
decimal precoHora = 0;


Console.WriteLine("Bem-vindo ao sistema de estacionamento...");
Console.WriteLine("informe o preço inicial:");
inicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora, informe qual o preço por hora excedida.");
precoHora = Convert.ToDecimal(Console.ReadLine());

Est es = new Est(inicial, precoHora);

string opcao = string.Empty;
bool Menu = true;

while(Menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma dessa opções válidas...");
    Console.WriteLine("1 - Adicionar um Veículo.");
    Console.WriteLine("2 - Remover um Veículo.");
    Console.WriteLine("3 - Listar um Veículo.");
    Console.WriteLine("4 - Fechar a aplicação.");
    Console.WriteLine("Aperte qualquer tecla para continuar...");

    switch(Console.ReadLine())
    {
        case "1":
            es.Adicionar();
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Veja e depois digite, qual placa gostaria de remover...");
            es.listar();
            es.Remover();
            break;

        case "3":
            Console.Clear();
            es.listar();
            break;

        case "4":
            Console.WriteLine("Encerrando o programa...\n Aperte ENTER para continuar...");
            Menu = false;
            break;

        default:
            Console.WriteLine("Opções inválidas...\n Aperte ENTER para continuar...");
            Console.ReadLine();
            break;

    }
}
