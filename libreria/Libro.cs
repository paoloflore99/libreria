using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    internal class Libro
    {
        public string Titolo {  get; set; }
        public Autore Autore { get; set; }
        public string ISBN { get; set; }
        public DateTime Data {  get; set; }
        public Libro(string  titolo , Autore autore , string isbn , DateTime data)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.ISBN = isbn;
            this.Data = data;
        }

        public override string ToString()
        {
            return $"{Titolo}, di {Autore.Nome} {Autore.Cognome}, ISBN: {ISBN}, Pubblicato il: {Data.ToShortDateString()}";
        }
    }
}
