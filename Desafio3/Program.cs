using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    class Program
    {
        static List<string> tareas = new List<string>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("=== Lista de Tareas ===");
                Console.WriteLine("1. Mostrar tareas");
                Console.WriteLine("2. Agregar tarea");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            MostrarTareas();
                            break;
                        case 2:
                            AgregarTarea();
                            break;
                        case 3:
                            EliminarTarea();
                            break;
                        case 4:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Inténtalo de nuevo.");
                }
            }
        }

        static void MostrarTareas()
        {
            Console.WriteLine("=== Tareas por realizar ===");
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas en la lista.");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }
        }

        static void AgregarTarea()
        {
            Console.Write("Introduce la nueva tarea: ");
            string nuevaTarea = Console.ReadLine();
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada correctamente.");
        }

        static void EliminarTarea()
        {
            MostrarTareas();
            Console.Write("Selecciona el número de la tarea que deseas eliminar: ");
            int indice;
            if (int.TryParse(Console.ReadLine(), out indice) && indice >= 1 && indice <= tareas.Count)
            {
                tareas.RemoveAt(indice - 1);
                Console.WriteLine("Tarea eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Número de tarea no válido. Inténtalo de nuevo.");
            }
        }
    }
}
