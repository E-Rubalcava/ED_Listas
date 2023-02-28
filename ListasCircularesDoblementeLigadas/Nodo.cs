using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDoblementeLigadas
{
    internal class Nodo
    {
        public string Texto;
        public Nodo Izquierda;
        public Nodo Derecha;

        public Nodo(string texto, Nodo izquierda = null, Nodo derecha = null)
        {
            Texto = texto;
            Izquierda = izquierda;
            Derecha = derecha;
        }
    }
}
