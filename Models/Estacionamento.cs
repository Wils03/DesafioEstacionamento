
namespace DesafioFundamentos.Models
{
    class Estacionamento
    {
         private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculos(){
            Console.WriteLine("Digite a placdo veiculo: (xxx-xxx)");
            string placa = Console.ReadLine().ToUpper();
            if (placa.Count() == 7){
                 this.veiculos.Add(placa);
            }else{
                Console.WriteLine("Placa inválida. \n"+"Digite a placdo veiculo: (xxx-xxx)");
            };

        }
        public void RemoverVeiculo (){
            Console.WriteLine("Digite qul placa do veiculo deseja remover:");
            string placa = Console.ReadLine().ToUpper();
            if ( this.veiculos.Contains(placa)){
                this.veiculos.Remove(placa);
            };
            decimal valorTotal = CalculoValorEstacionamento();
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R${Math.Round(valorTotal, 2)}.");
        }

        private decimal CalculoValorEstacionamento()
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            decimal horas = Convert.ToDecimal(Console.ReadLine());
            return horas * this.precoPorHora + this.precoInicial;
        }

        public void ListarVeiculos(){
            foreach (string veiculo in this.veiculos){
                Console.WriteLine(veiculo, "\n");
            }
        }

    }
}