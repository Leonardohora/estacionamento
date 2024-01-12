using System.Diagnostics.Contracts;

namespace estacionamentoconfig.models
{
    public class Est
    {
        private decimal Inicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculo = new List<string>();

        public Est (decimal Inicial, decimal precoHora)
        {
            this.Inicial = Inicial;
            this.precoHora = precoHora;
        }
        public void Adicionar()
        {
            Console.WriteLine("Diga qual a placa do veiculo:");
            string placa = Console.ReadLine();
            veiculo.Add(placa);
            Console.WriteLine("Veículo adicionado...\n Aperte ENTER para continuar...");
            Console.ReadLine();
        }
        public void Remover()
        {
            Console.WriteLine("Ok, vamos tirar do sistema o veiculo.\n Digite aqui qual a placa do veiculo:\n");
            string remover = Console.ReadLine();

            if(veiculo.Any(remover => remover.ToUpper() == remover.ToUpper()))
            {
                Console.WriteLine("Informe quantas horas excedentes, o veiculo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = horas * precoHora + Inicial;
                veiculo.Remove(remover);
                Console.WriteLine($"O veículo {remover} foi removido.\nPreço a pagar R$ {precoTotal}. \nAperte ENTER para continuar...");
                Console.ReadLine();

            }
            else
            {
             Console.WriteLine("Placa inexistente. \n Aperte ENTER para continuar...");
             Console.ReadLine();

            }
        }
        public void listar()
        {
            if (veiculo.Any())
            {
               int cont = 0;
            Console.WriteLine("Veiculos cadrastrados...\n");
            foreach (string i in veiculo)
            {
                cont++;
                Console.WriteLine($"{cont}° - {i}");
            }
            Console.WriteLine("\nlista feita... Aperte ENTER para continuar...");
            Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("\n ESTACIONAMENTO VAZIO...\n Aperte ENTER para continuar...");
                Console.ReadLine();
            }
            
        }

    }
}