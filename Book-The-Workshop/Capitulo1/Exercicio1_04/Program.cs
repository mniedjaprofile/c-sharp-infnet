namespace Exercicio1_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================== Vamos Calcular =====================");
            Console.WriteLine("Informe o primeiro valor : ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe o segundo valor :  ");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine($"O primeiro valor informado foi {a} e o segundo valor é {b}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Soma: {a + b}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Multiplicação: {a * b}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Subtração : {a - b}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Divisão : {a / b}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("=========================== Fim ===========================");
        }
    }
}
