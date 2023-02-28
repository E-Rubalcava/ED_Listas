using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarAlFinal("Uno");
            lista.AgregarAlFinal("Dos");
            lista.AgregarAlInicio("Tres");
            lista.AgregarAlFinal("Cuatro");
            lista.AgregarAlInicio("Cero");

            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Busqueda por indice");
            Nodo busquedaPorIndice = lista.Buscar("Dos");
            if (busquedaPorIndice != null)
                Console.WriteLine(busquedaPorIndice.Texto);
            else
                Console.WriteLine("No encontrado");

            Console.WriteLine("Eliminando Uno");
            lista.Eliminar("Uno");
            Console.WriteLine(lista.RecorrerLista());
            Console.ReadKey();
        }
    }
}
