using Part2.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal inicial = 0;
decimal precoHora = 0;


Console.WriteLine("Bem-vindo ao sistema de estacionamento...");
Console.WriteLine("informe o preço inicial:");
inicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora informe qual o preço por hora.");
precoHora = Convert.ToDecimal(Console.ReadLine());

Est es = new Est(inicial, precoHora);

string opcao = string.Empty;
bool Menu = true;

while(Menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma dessa opções válidas...");
    Console.WriteLine("1 - Adcionar um Veículo.");
    Console.WriteLine("2 - Remover um Veículo.");
    Console.WriteLine("3 - Listar um Veículo.");
    Console.WriteLine("4 - Fechar a aplicação.");
    Console.WriteLine("Aperte qualquer tecla para continuar...");

    switch(Console.ReadLine())
    {
        case "1":
            es.Adiocionar();
            break;

        case "2":
            Console.WriteLine("esse é remover");
            break;

        case "3":
            es.listar();
            break;

        case "4":
            Console.WriteLine("Encerrando o programa...\n Aperte uma tecla para continuar...");
            Menu = false;
            break;

        default:
            Console.WriteLine("opções inválidas...");
            break;

    }
}
