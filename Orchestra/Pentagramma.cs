using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public class Pentagramma : List<Nota>
    {
        public Pentagramma() { }

        public Pentagramma Tablatura(Nota nota)
        {
            var listaNote = new Pentagramma()
            {
                new Nota("Do"),
                new Nota("Re"),
                new Nota("Mi"),
                new Nota("Fa"),
                new Nota("Sol"),
                new Nota("La"),
                new Nota("Si"),
            };

            var tablatura = new Pentagramma();

            var notaTrovata = listaNote.Find(x => x.Note.ToLower() == nota.Note.ToLower());
            var indexOfToned = listaNote.IndexOf(notaTrovata);

            for (int i = indexOfToned; i < listaNote.Count(); i++)
            {
                var note = listaNote[i];
                tablatura.Add(note);
            }

            for (int i = 0; i < indexOfToned; i++)
            {
                var note = listaNote[i];
                tablatura.Add(note);
            }

            return tablatura;
        }
    }
}
