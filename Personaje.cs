using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Nivel { get; protected set; }
        public int Experiencia { get; protected set; }
        public int ProximaExperiencia { get; protected set; }

        public Personaje(string nombre)
        {
            Nombre = nombre;
            Nivel = 1;
            Experiencia = 0;
            ProximaExperiencia = 100;
        }

        public abstract void SubirNivel();
        public void GanarExperiencia(int cantidad)
        {
            Experiencia += cantidad;
            Console.WriteLine($"{Nombre} ha ganado {cantidad} puntos de experiencia.");
            if (Experiencia >= ProximaExperiencia)
            {
                SubirNivel();
            }
        }
    }

}
