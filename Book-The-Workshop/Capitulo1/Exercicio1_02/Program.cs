namespace Exercicio1_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Este é o meu primeiro programa em C#.\nQual o seu nome?");
            Console.WriteLine("-------------------------------------------------------");
            
            var name = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Olá {name}, É um prazer te conhecer.\nTeremos uma grande jornada pela frente!");
        }
    }
}
