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
    }
}
