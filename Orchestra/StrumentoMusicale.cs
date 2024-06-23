using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public abstract class StrumentoMusicale : Pentagramma
    {
        public Nota Note { get; set; }
        public Pentagramma Tab {  get; set; } 
        public StrumentoMusicale(Nota nota) 
        {
            Note = nota;
            Tab = new Pentagramma().Tablatura(Note);
        }

        public string Play()
        {
            var strumento = GetType().Name;
            var message = $"Il {strumento}, sta suonando la scala di {Note.Note}: ";

            Tab.ForEach(x =>
                message += x.Note + " "
            );

            return message;
        }
    }
}
