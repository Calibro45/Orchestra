using System.Collections.Immutable;

namespace Orchestra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            var listaStrumenti = new Orchestra()
            {
                new Piano(new Nota("Do")),
                new Chitarra(new Nota("La")),
                new Violino(new Nota("Sol"))
            };

            foreach (var strumento in listaStrumenti)
            {
                Console.WriteLine(strumento.Play() + "\n");
            }

        }
    }
}
