using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cero");

            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Buscando Cero");
            Nodo busqueda = lista.Buscar("Cero");
            if (busqueda != null)
                Console.WriteLine(busqueda.Texto);
            else
                Console.WriteLine("No se ha encontrado");

            Console.WriteLine("Eliminando Tres");
            lista.EliminarNodo("Tres");
            Console.WriteLine(lista.RecorrerLista());

            Console.ReadKey();
        }
    }
}
