using ExamenIndividual;

class Program
{
    static void Main(string[] args)
    {
        
        Jugador jugador = new Jugador("Tanaka");

        
        Asignatura matematicas = new Asignatura("Matemáticas");
        matematicas.AgregarTarea(new Tarea<int>("Resolver problemas de álgebra", 2, 50));
        matematicas.AgregarTarea(new Tarea<int>("Resolver ecuaciones", 3, 80));

        Asignatura historia = new Asignatura("Historia");
        historia.AgregarTarea(new Tarea<int>("Leer sobre la Revolución Francesa", 1, 30));
        historia.AgregarTarea(new Tarea<int>("Escribir un ensayo", 3, 90));

        
        Sistema sistema = new Sistema(jugador);
        sistema.AgregarAsignatura(matematicas);
        sistema.AgregarAsignatura(historia);

        
        sistema.Jugar();
    }
}

