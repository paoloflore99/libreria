using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    internal class Autore
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }

        public Autore(string nome , string cognome)
        { 
            this.Nome = nome;
            this.Cognome = cognome;
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}";
        }
    }
}
