using System.Security.Cryptography.X509Certificates;

namespace Exercicio1_05
{
    internal class Program
    {
       public class Person
        {
            public Person() { }
            public Person(string name, int idade) { 
                this.name = name;
                this.idade = idade;
            }
            public string name { get; set; }
            public int idade { get; set; }

            public void GetInfo(){
                Console.WriteLine($"Nome: {name} - É criança? {IsChild()}");
            }

            public bool IsChild()
            {
                return idade < 12;
            }
        }

        static void Main(string[] args)
        {
            var adulto = new Person("Mayara Araujo", 30);
            adulto.GetInfo();

            var crianca = new Person("Ana Alice", 10);
            crianca.GetInfo();
        }
    }
}
