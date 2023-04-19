using ListasClassEFuncoes.Modelo;

namespace ListasClassEFuncoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var continuarExecutando = true;
            Console.WriteLine("Digite Seu Nome e Email");
            var nome = Console.ReadLine();
            var email = Console.ReadLine();

            var cliente = new Cliente(nome, email);
            Console.WriteLine($"Bem vindo! {nome}");
            while (continuarExecutando)
            {
                Menu();
                var opcao = Console.ReadLine();
                if( opcao == "1")
                {
                    Console.WriteLine("Informe qual Produto, Valor e Quantidade");
                    var nomeProduto=Console.ReadLine();
                    var Valor = float.Parse( Console.ReadLine());
                    var quantidade= int.Parse( Console.ReadLine());

                    var pedido = new Pedido(nomeProduto, Valor, quantidade);
                    cliente.AdicionarPedido(pedido);
                    Console.WriteLine($"Total.......{cliente.TotalPedido}");
                }
                else
                if (opcao == "2")
                {
                ListarPedidos(cliente.Pedidos);
                Console.WriteLine($"Total.......{cliente.TotalPedido}");
                }
                else {
                    Console.WriteLine($"{cliente.Nome}, o total do seu pedido foi {cliente.TotalPedido}");
                    continuarExecutando = false;
                }
            }
           
        }

        public static void Menu()
        {
            Console.WriteLine($"---------------");
            Console.WriteLine($"1 - Adicionar Pedido");
            Console.WriteLine($"2 - Consultar Pedido");
            Console.WriteLine($"3 - Fechar Pedido");
            Console.WriteLine($"---------------");
        }
        public static void ListarPedidos(List<Pedido> pedidos)
        {
            Console.WriteLine($"Pedidos até {DateTime.Now}");
            foreach (Pedido pedido in pedidos)
            {
                int count= 1;
                Console.WriteLine($"{count} - {pedido.Produto}........{pedido.Total}");
                count++;
            }           
        }
    }
}