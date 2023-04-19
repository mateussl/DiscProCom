namespace VetoreMultDimensionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


    }
    public class Pessoa{
        public Pessoa()
        {
            Telefone = new string[3];   
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string[] Telefone { get; set; }
    }
}