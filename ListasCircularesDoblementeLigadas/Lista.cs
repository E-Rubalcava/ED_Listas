using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDoblementeLigadas
{
    internal class Lista
    {
        Nodo Inicio;

        public Lista()
        {
            Inicio = null;
        }

        public void LimpiarLista()
        {
            Inicio = null;
        }

        public bool EstaVacia()
        {
            if (Inicio == null)
                return true;
            return false;
        }

        public void AgregarNodo(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (EstaVacia())
            {
                Inicio = nuevo;
                Inicio.Derecha = Inicio;
                Inicio.Izquierda = Inicio;
                return;
            }
            if (ReferenceEquals(Inicio, Inicio.Derecha) && ReferenceEquals(Inicio, Inicio.Izquierda))
            {
                Inicio.Derecha = nuevo;
                Inicio.Izquierda = nuevo;
                nuevo.Derecha = Inicio;
                nuevo.Izquierda = Inicio;
                return;
            }
            Nodo actual = Inicio.Derecha;
            while (!ReferenceEquals(actual.Derecha, Inicio))
            {
                actual = actual.Derecha;
            }
            nuevo.Izquierda = actual;
            nuevo.Derecha = Inicio;
            actual.Derecha = nuevo;
            Inicio.Izquierda = nuevo;
        }

        public void EliminarNodo(string valor)
        {
            if (EstaVacia()) return;
            if (ReferenceEquals(Inicio, Inicio.Derecha) && ReferenceEquals(Inicio, Inicio.Izquierda))
            {
                LimpiarLista();
            }
            Nodo actual = Inicio;
            while (!ReferenceEquals(actual.Derecha, Inicio))
            {
                if (actual.Texto == valor)
                {
                    actual.Izquierda.Derecha = actual.Derecha;
                    actual.Derecha.Izquierda = actual.Izquierda;
                    if (ReferenceEquals(actual, Inicio))
                    {
                        Inicio = Inicio.Derecha;
                    }
                    return;
                }
                actual = Inicio.Derecha;
            }
        }

        public Nodo Buscar(string valor)
        {
            if (EstaVacia()) return null;
            Nodo actual = Inicio;

            if(ReferenceEquals(Inicio, Inicio.Derecha) && ReferenceEquals(Inicio, Inicio.Izquierda))
            {
                if (actual.Texto == valor)
                {
                    return actual;
                }
                return null;
            }
            actual = Inicio.Derecha;
            while (!ReferenceEquals(actual, Inicio))
            {
                if (actual.Texto == valor)
                {
                    return actual;
                }
                actual = actual.Derecha;
            }
            return null;
        }

        public string RecorrerLista()
        {
            StringBuilder cadena = new StringBuilder();
            Nodo actual = Inicio;
            while (!ReferenceEquals(actual.Derecha, Inicio) && actual != null)
            {
                cadena.Append(actual.Texto + "\n");
                actual = actual.Derecha;
            }
            cadena.Append(actual.Texto + "\n");
            return cadena.ToString();
        }
    }
}
