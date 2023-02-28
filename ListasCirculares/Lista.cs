using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
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

        public string RecorrerLista()
        {
            string cadena = "";
            Nodo actual = Inicio;
            while (!ReferenceEquals(actual.Referencia, Inicio) && actual != null)
            {
                cadena += actual.Texto + "\n";
                actual = actual.Referencia;
            }
            cadena += actual.Texto + "\n";
            return cadena;
        }

        public void AgregarNodo(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            Nodo actual = Inicio;
            if (EstaVacia())
            {
                // Primer elemento
                Inicio = nuevo;
                Inicio.Referencia = Inicio;
                return;
            }
            else if (ReferenceEquals(actual.Referencia, Inicio))
            {
                // Segundo elemento
                Inicio.Referencia = nuevo;
                nuevo.Referencia = Inicio;
            }
            else
            {
                // Cualquier otro elemento
                while (!ReferenceEquals(actual.Referencia, Inicio))
                {
                    actual = actual.Referencia;
                }
                actual.Referencia = nuevo;
                nuevo.Referencia = Inicio;
            }
        }

        public Nodo Buscar(string valor)
        {
            if (EstaVacia())
            {
                return null;
            }
            Nodo actual = Inicio;
            // Solo hay un elemento
            if (actual.Referencia == Inicio)
            {
                return actual;
            }
            actual = actual.Referencia;
            while (!ReferenceEquals(actual, Inicio))
            {
                if (actual.Texto == valor)
                {
                    return actual;
                }
                actual = actual.Referencia;
            }
            return null;

        }

        public void EliminarNodo(string valor)
        {
            Nodo actual = Inicio;

            // Lista vacia
            if (EstaVacia())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            // Solo hay un elemento
            if (actual.Referencia == Inicio)
            {
                LimpiarLista();
            }
            while (!ReferenceEquals(actual.Referencia, Inicio))
            {
                if (actual.Referencia.Texto == valor)
                {
                    actual.Referencia = actual.Referencia.Referencia;
                    if (ReferenceEquals(actual, Inicio))
                        Inicio = Inicio.Referencia;
                    return;
                }
                actual = actual.Referencia;
            }
            Console.WriteLine("El nodo no existe");
        }

    }
}
