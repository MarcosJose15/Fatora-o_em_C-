// See https://aka.ms/new-console-template for more information

namespace fatorar
{
    public static class Extensions
    {
        public static int ToInt32(string value)
        {
            try { return Convert.ToInt32(value); }
            catch { return 0; }
        }
    }

    public class Program
    {
        private string[] arguments;

        public Program(string[] arguments)
        { this.arguments = arguments; }

        private string ReadLine(string Message)
        { 
            Console.WriteLine(Message);
            return Console.ReadLine() ?? string.Empty;
        }

        private int ReadLineInt32(string Message)
        {
            try
            { return Convert.ToInt32(this.ReadLine(Message: Message)); } 

            catch (FormatException error)
            {
                Console.Clear();
                Console.WriteLine(error.Message);
                Console.WriteLine("Valor Invalido, informe um valor numerico valido");

                return this.ReadLineInt32(Message: Message);
            }
        }

        private void Main()
        {
            // O VALOR NUMERO SEMPRE VAI SER UM INTEIRO VALIDO
            // POIS O SISTEMA BLOQUEIA ENTRADA INCORRETA DE INTEIRO
            // PORÉM PODE SER DE NEGATIVO OU POSITIVO INCLUINDO 0
            int num = this.ReadLineInt32(Message: "Digite um número e exibirei o resultado de sua fatoração:");
            int fatorial = 1;

            for (int item = 1; item < (num + 1); item++)
            {
                // fatorial *= item;
                fatorial = (fatorial * item);
                Console.WriteLine($"{item}x: {fatorial}");
            }
        }

        public static void Main(string[] arguments)
        {
            Program programa = new Program(arguments: arguments);
            programa.Main();
        }
    }
}