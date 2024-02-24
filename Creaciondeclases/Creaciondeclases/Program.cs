using System;

class Persona
{
    // Atributos de la clase Persona
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }

    // Constructor de la clase Persona
    public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion)
    {
        // Validar la información en el constructor
        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || fechaNacimiento == DateTime.MinValue ||
            string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion))
        {
            throw new ArgumentException("La información proporcionada no es válida.");
        }

        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Telefono = telefono;
        Direccion = direccion;
    }
}

class Alumno : Persona
{
    // Atributos adicionales de la clase Alumno
    public string Carnet { get; set; }
    public DateTime FechaIngreso { get; set; }

    // Constructor de la clase Alumno
    public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string carnet, DateTime fechaIngreso)
        : base(nombre, apellido, fechaNacimiento, telefono, direccion)
    {
        Carnet = carnet;
        FechaIngreso = fechaIngreso;
    }
}

class Profesor : Persona
{
    // Atributos adicionales de la clase Profesor
    public string Titulo { get; set; }

    // Método adicional de la clase Profesor
    public void AsignarCalificacion()
    {
        // Lógica para asignar calificación
    }

    // Constructor de la clase Profesor
    public Profesor(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string titulo)
        : base(nombre, apellido, fechaNacimiento, telefono, direccion)
    {
        Titulo = titulo;
    }
}

class Program
{
    static void Main()
    {
        // Crear instancias para probar las clases
        Persona persona = new Persona("Max", "Perez", new DateTime(2001, 10, 24), "646559798", "Zona 1 Mataquescuintla");

        Alumno alumno = new Alumno("Sara", "Lopez", new DateTime(2003, 7, 10), "32669585", "Calle 3, colonia bartolome", "A12345", DateTime.Now);
        Profesor profesor = new Profesor("Ing.Marco", "Tulio", new DateTime(1990, 5, 11), "46623248", "Canton Elena", "Ing en sistemas");

        // Ejecutar métodos o realizar acciones con las instancias creadas
        profesor.AsignarCalificacion();

        // Definir clases adicionales para una institución educativa
        // - Clase Curso
        // - Clase Asignatura
        // - Clase Aula
        // - Clase Horario
    }
}

