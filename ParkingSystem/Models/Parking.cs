namespace ParkingSystem.Models
{
    public class Parking
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Parking(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa;

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();

            if(placa.Length == 0 || placa == null)
            {
                Console.WriteLine("Placa com valor nulo nao e valido");
                return;
            }

            veiculos.Add(placa);
            Console.WriteLine("Veiculo cadastrado!");
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas;
                decimal valorTotal;

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Int32.Parse(Console.ReadLine());

                valorTotal =  precoInicial + horas*precoPorHora;
                

                veiculos = veiculos.FindAll(pv => pv != placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veículo in veiculos)
                {
                    Console.WriteLine(veículo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}