using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    public class Sistema
    {
        public Jugador jugador;
        public Dictionary<string, Asignatura> asignaturas;

        public Sistema(Jugador jugador)
        {
            this.jugador = jugador;
            asignaturas = new Dictionary<string, Asignatura>();
        }

        public void AgregarAsignatura(Asignatura asignatura)
        {
            asignaturas[asignatura.NombreAsignatura] = asignatura;
        }

        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas disponibles:");
            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine($"- {asignatura.Key}");
            }
        }

        public void Jugar()
        {
            while (true)
            {
                Console.WriteLine("\n¿Qué deseas hacer?");
                Console.WriteLine("1. Ver asignaturas");
                Console.WriteLine("2. Ver estado del jugador");
                Console.WriteLine("3. Salir del juego");

                string input = Console.ReadLine();

                
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Por favor, ingresa una opción válida.");
                    continue; 
                }

                
                if (!int.TryParse(input, out int opcion))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
                    continue; 
                }

                switch (opcion)
                {
                    case 1:
                        MostrarAsignaturas();
                        Console.WriteLine("Elige una asignatura:");
                        string asignaturaElegida = Console.ReadLine();
                        if (asignaturas.ContainsKey(asignaturaElegida))
                        {
                            Asignatura asignatura = asignaturas[asignaturaElegida];
                            asignatura.MostrarTareas();
                            Console.WriteLine("Selecciona una tarea:");
                            int tareaIndex;
                            if (int.TryParse(Console.ReadLine(), out tareaIndex) && tareaIndex > 0)
                            {
                                Tarea<int> tarea = asignatura.SeleccionarTarea(tareaIndex - 1);
                                if (tarea != null)
                                {
                                    Console.WriteLine($"Completaste la tarea: {tarea.NombreTarea}");
                                    jugador.GanarExperiencia(tarea.Recompensa);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Asignatura no encontrada.");
                        }
                        break;

                    case 2:
                        Console.WriteLine($"\nJugador: {jugador.Nombre}");
                        Console.WriteLine($"Nivel: {jugador.Nivel}");
                        Console.WriteLine($"Experiencia: {jugador.Experiencia}/{jugador.ProximaExperiencia}");
                        break;

                    case 3:
                        Console.WriteLine("¡Gracias por jugar!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }


}
