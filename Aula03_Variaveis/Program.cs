namespace Aula03_Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome = "Mateus";
            idade = 10;
            DateTime dataN = DateTime.Now;
            DateTime? dataMatricula = null;
            const string token = "xpo";

            
            Pessoa pessoaAluno = new Pessoa("Fulano de Tal",26);
            

            Console.WriteLine("Pessoa Nome "+ pessoaAluno.Nome);
            Console.WriteLine("Pessoa Idade " + pessoaAluno.Idade);


        }

    }

    public class Pessoa 
    {
        public string Nome { get; private set; }
        public int Idade { get; set; }
        public int AnoN { get; set; }
        public DateTime? DataMatricula { get; set; }

        public Pessoa(string nome,int idade)
        {
            Nome = nome;
            Idade = idade;
            CalcularAnoN();

        }

        private void CalcularAnoN()
        {
            int anoAtual= DateTime.Now.Year;
            AnoN= anoAtual-Idade;
        }
       
    }
}