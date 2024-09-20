using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    public class Tarea<T>
    {
        public string NombreTarea { get; set; }
        public int Dificultad { get; set; }
        public T Recompensa { get; set; }

        public Tarea(string nombre, int dificultad, T recompensa)
        {
            NombreTarea = nombre;
            Dificultad = dificultad;
            Recompensa = recompensa;
        }
    }
}
