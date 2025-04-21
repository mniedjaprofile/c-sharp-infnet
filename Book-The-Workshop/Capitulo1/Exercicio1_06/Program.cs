namespace Exercicio1_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um nome de usuário. Ele deve conter pelo menos 6 caracteres : ");
            var username = Console.ReadLine();

            if (username.Length < 6)
            {
                Console.WriteLine($"O nome de usuário inserido {username} não é válido.\nInsira um nome de usuário com mais de 6 caracteres.");
            } else {
                Console.WriteLine($"Agora, insira uma senha. Ela deve conter no minimo 6 caracteres e um número : ");
                var password = Console.ReadLine();

                if (password.Length < 6 ){
                    Console.WriteLine("A senha deve conter ao menos 6 caracteres.");
                }else if (!password.Any(c => char.IsDigit(c))) {
                    Console.WriteLine("A senha deve conter pelo menos um numero e/ou caracter!");
                }
                else
                {
                    Console.WriteLine("Usuário criado com sucesso!!");
                }
            }
        }
    }
}
