using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    public class Jugador : Personaje
    {
        public Jugador(string nombre) : base(nombre) { }

        public override void SubirNivel()
        {
            Nivel++;
            Experiencia = 0;
            ProximaExperiencia += 50;
            Console.WriteLine($"{Nombre} ha subido al nivel {Nivel}!");
        }
    }
}
