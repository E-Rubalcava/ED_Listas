using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public string Texto { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(string texto, Nodo izquierda = null, Nodo derecha = null)
        {
            Texto = texto;
            Izquierda = izquierda;
            Derecha = derecha;
        }
    }
}
