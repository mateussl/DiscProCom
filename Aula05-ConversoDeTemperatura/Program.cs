namespace Aula05_ConversoDeTemperatura
{
     class Program
    {
        static void Main(string[] args)
        {
            //dotnet run
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Informe qual a temperatura");
                float temperatura = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite C para converter em Celsius ou F para Fahrenheit ");
                string opcao = Console.ReadLine().ToLower().Substring(0, 1);
                
                if (opcao == "f")
                {
                    var result = temperatura * 1.8 + 32;
                    Console.WriteLine($"{result}F");
                }
                else if (opcao == "c")
                {
                    var result = (temperatura - 32) / 1.8;
                    Console.WriteLine($"{result}C");
                }
                else
                {
                    Console.WriteLine("Nenhuma opção selecionada");
                }
                Console.WriteLine("Deseja realizar outra conversão S ou N ?");
                var executarOpcao = Console.ReadLine().ToLower().Substring(0, 1);
                continuar = executarOpcao=="s" ? true :false;

            }
        }
    }
}