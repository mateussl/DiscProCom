namespace Aula08_DesafioIMC
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Cálculo de IMC ***");

            Console.WriteLine("Qual seu nome ?");
            string nome =  Console.ReadLine();
            Console.WriteLine("Qual seu peso em kg ?");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura? Cm ?");
            float altura = float.Parse(Console.ReadLine());

            float imc = calcularIMC(altura,peso);
            Console.WriteLine($"{nome} Você está com um IMC =`{imc}");
            imprimirmensagemIMC(imc);
            
            
        }
        static float calcularIMC(float altura, float peso)
        {
            return peso /(altura*altura);
        }

        static void imprimirmensagemIMC(float imc)
        {
             switch (imc)
            {
                case float imcExtraido when (imcExtraido < 18.5):
                    Console.WriteLine($"Abaixo do peso");
                    break;
                case float imcExtraido when (imcExtraido >= 18.5 && imcExtraido <= 24.9):
                    Console.WriteLine($"Peso normal");
                    break;
                case float imcExtraido when (imcExtraido >= 25 && imcExtraido <= 29.9):
                    Console.WriteLine($"Sobrepeso");
                    break;
                case float imcExtraido when (imcExtraido >= 30 && imcExtraido <= 34.9):
                    Console.WriteLine($"Obesidade grau 1");
                    break;
                case float imcExtraido when (imcExtraido >= 35 && imcExtraido <= 39.9):
                    Console.WriteLine($"Obesidade grau 2");
                    break;
                case float imcExtraido when (imcExtraido >= 40):
                    Console.WriteLine($"Obesidade grau 3");
                    break;

            };
        }
    }
}