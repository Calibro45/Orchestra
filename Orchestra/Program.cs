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

            foreach (var item in listaStrumenti)
            {
                var message = listaStrumenti.Sinfony(item, item.Tab);
                Console.WriteLine(message);
            }
        }
    }
}
