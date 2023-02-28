using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarNodo("A");
            lista.AgregarNodo("D");
            lista.AgregarNodo("B");
            lista.AgregarNodo("Z");

            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Eliminando A");
            lista.EliminarNodo("A");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Buscando Z");
            Nodo busqueda = lista.Buscar("Z");
            if (busqueda != null)
            {
                Console.WriteLine(busqueda.Texto);
            }
            else
            {
                Console.WriteLine("No existe el nodo");
            }
            Console.ReadKey();

        }
    }
}
