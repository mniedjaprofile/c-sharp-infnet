namespace Exercicio1_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaração de nivel superior, devem ser usadas acima das classes e struct 
            var aGolden = new GoldenRetriever() { Name = "Aspen" };
            var anotherGolden = new GoldenRetriever() { Name = "Aspen" };

            var aBorder = new BorderCollie() { Name = "Aspen" };
            var anotherBorder = new BorderCollie() { Name = "Aspen" };

            var aBernese = new Bernese() { Name = "Aspen" };
            var anotherBernese = new Bernese() { Name = "Aspen" };

            //ternários
            var goldenComparison = aGolden.Equals(anotherGolden) ? "Os cachorros Golden retrievers tem o mesmo nome." :  "Os cachorros tem nomes diferentes.";

            var borderComparison = aBorder.Equals(anotherBorder) ? "Os cachorros Border Collies possuem o mesmo nome." : "Esses Border Collies possuem nomes diferentes.";

            var berneseComparison = aBernese.Equals(anotherBernese) ? "Os cachorros Bernese possuem o nome igual." : "Esses Bernese possuem nomes diferentes.";

            Console.WriteLine(goldenComparison);

            Console.WriteLine(borderComparison);

            Console.WriteLine(berneseComparison);
        }

        struct GoldenRetriever
        {
            public string Name { get; set; }
        }

        class BorderCollie
        {
            public string Name { get; set; }
        }
        class Bernese
        {
            public string Name { get; set; }

            public override bool Equals(object obj)
            {
                if (obj is Bernese borderCollie && obj != null)
                {
                    return this.Name == borderCollie.Name;
                }

                return false;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
    }
}
