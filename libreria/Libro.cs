using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    internal class Libro
    {
        public string titolo {  get; set; }
        public Autore Autore { get; set; }
        public string SBN { get; set; }
        public DateTime Data {  get; set; }
        public Libro()
        {
        
        }
    }
}
