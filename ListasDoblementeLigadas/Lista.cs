using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        Nodo Inicio;
        Nodo Final;

        public Lista() 
        {
            Inicio = null;
            Final = null;
        }

        public void LimpiarLista()
        {
            Inicio = null;
            Final = null;
        }

        public bool EstaVacia()
        {
            if (Inicio == null && Final == null)
                return true;
            return false;
        }

        public void AgregarAlFinal(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (EstaVacia())
            {
                Inicio = nuevo;
                Final = nuevo;
            }
            else
            {
                nuevo.Izquierda = Final;
                Final.Derecha = nuevo;
                Final = nuevo;
            }
        }

        public void AgregarAlInicio(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (EstaVacia())
            {
                Inicio = nuevo;
                Final = nuevo;
            }
            else
            {
                nuevo.Derecha = Inicio;
                Inicio.Izquierda = nuevo;
                Inicio = nuevo;
            }
        }

        public string RecorrerLista()
        {
            string valores = "";
            Nodo actual = Inicio;
            while (actual != null)
            {
                valores += actual.Texto + "\n";
                actual = actual.Derecha;
            }
            return valores.ToString();
        }

        public Nodo Buscar(string valor)
        {
            if (EstaVacia())
                return null;
            Nodo actual = Inicio;
            while (actual != null)
            {
                if (actual.Texto == valor)
                {
                    return actual;
                }
                actual = actual.Derecha;
            }
            return null;
        }

        public void Eliminar(string valor)
        {
            if (EstaVacia())
                Console.WriteLine("La lista no tiene elementos");

            Nodo actual = Inicio;
            while (actual != null && actual.Texto != valor)
            {
                actual = actual.Derecha;
            }
            if (actual == null)
            {
                Console.WriteLine("El valor no existe en la lista");
                return;
            }

            // Revisa si es el inicio
            if (actual.Izquierda == null)
            {
                Inicio = Inicio.Derecha;
            }
            else
            {
                actual.Izquierda.Derecha = actual.Derecha;
            }

            // revisa si es el final
            if (actual.Derecha == null)
            {
                Final = Final.Izquierda;
            }
            else
            {
                actual.Derecha.Izquierda = actual.Izquierda;
            }
        }
    }
}
