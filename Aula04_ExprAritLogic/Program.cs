namespace Aula04_ExprAritLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Qual seu Nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("Qual sua Idade?");
           
            try
            {
                int idade = int.Parse(Console.ReadLine());
                if(idade>=30) { throw new Exception("A idade deverá ser menor que 30"); }
                Console.WriteLine($"Seu nome é {nome} sua idade é: " + idade);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Você Digitou o valor errado!!! Motivo: {ex.Message}");
            }

            //Exemplo 2
            Console.WriteLine("Exemplo 02");
            Pessoa Fulano = new Pessoa("Fulano de Tal", 35);
            Pessoa Sicrano = new Pessoa("Sicrano de Tal", 24);
            Pessoa Beltrano = new Pessoa("Beltrado de Tal", 43);

            Pessoa[] pessoas = new Pessoa[] { Fulano, Sicrano, Beltrano };
           
            foreach(var pessoa in pessoas) {
                Console.WriteLine(pessoa.ToString());
                if (pessoa.Idade == 24)
                {
                    Console.WriteLine("Pessoa Encontrada no laço "+pessoa.ToString());
                }
            }
            

            

        }
        public class Pessoa
        {
            public Pessoa(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }

            public string Nome { get; set; }

            public int Idade { get; set; }

            public override string ToString()
            {
                return $"Nome: {Nome} e idade {Idade}.";
            }

        }
    }
}