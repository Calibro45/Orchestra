using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public class Orchestra : List<StrumentoMusicale>
    {
        public Orchestra() { }

        public string Sinfony(StrumentoMusicale s, Pentagramma tab)
        {
            var strumento = s.GetType().Name;
            var message = $"{strumento}, sta suonando la scala di {s.Note.Note}:\n";

            tab.ForEach(t =>
                message += t.Note + " "
            );

            return message;
        }

    }
}
