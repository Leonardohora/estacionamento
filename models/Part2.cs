using System.Diagnostics.Contracts;

namespace Part2.models
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
        public void Adiocionar()
        {
            Console.WriteLine("Diga qual a placa do veiculo:");
            string placa = Console.ReadLine();
            veiculo.Add(placa);
        }
        public void Remover()
        {
            Console.WriteLine("Ok, vamos tirar do sistema o veiculo.\n Digite aqui qual a placa do veiculo:\n");
            Console.ReadLine();
            string placa1 = "";

            if(veiculo.Any(x => x.ToUpper() == placa1.ToUpper()))
            {
                Console.WriteLine("Informe quantas horas o veiculo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                
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
            Console.WriteLine("lista feita... aperte qualque tecla para continuar.");
            Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("\n Estacionamento vazio.");
            }
            
        }

    }
}