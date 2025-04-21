namespace Exercicio1_03
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            static void FormatandoString(string stringFormat)
            {
               stringFormat = stringFormat.Replace("Terráqueos", "Marciano");
               Console.WriteLine("Exibindo a mensagem após o replace : " +stringFormat);
               Console.WriteLine("-----------------------------------------------");
               
                //lidando com a imutabilidade (não fazia parte do capitulo mas não estava
               //funcional)
            }

            static string RetornoFormatado(string stringFormat)
            {
                return stringFormat.Replace("Terra", "Marte");
            }
            
            var saudacao = "Bom diaaa Terráqueos!!";
            
            Console.WriteLine("Mensagem antes do replace : " +saudacao);
            Console.WriteLine("-----------------------------------------------");

            FormatandoString(saudacao);

            var outraSaudacao = "Olá Terra!";
            Console.WriteLine("Mensagem original : " + outraSaudacao);
            Console.WriteLine("-----------------------------------------------");


            Console.WriteLine("Mensagem tratada : " +RetornoFormatado(outraSaudacao));
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
