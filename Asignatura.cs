using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    public class Asignatura
    {
        public string NombreAsignatura { get; set; }
        public List<Tarea<int>> Tareas { get; set; }

        public Asignatura(string nombre)
        {
            NombreAsignatura = nombre;
            Tareas = new List<Tarea<int>>();
        }

        public void AgregarTarea(Tarea<int> tarea)
        {
            Tareas.Add(tarea);
        }

        public void MostrarTareas()
        {
            Console.WriteLine($"Tareas de {NombreAsignatura}:");
            for (int i = 0; i < Tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Tareas[i].NombreTarea} - Dificultad: {Tareas[i].Dificultad}");
            }
        }

        public Tarea<int> SeleccionarTarea(int index)
        {
            if (index >= 0 && index < Tareas.Count)
            {
                return Tareas[index];
            }
            else
            {
                Console.WriteLine("Índice inválido.");
                return null;
            }
        }
    }

}
