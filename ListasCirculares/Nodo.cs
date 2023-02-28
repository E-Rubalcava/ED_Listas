using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Nodo
    {
        public Nodo Referencia { get; set; }
        public string Texto { get; set; }

        public Nodo(string texto, Nodo referencia = null)
        {
            Texto = texto;
            Referencia = referencia;
        }
    }
}
