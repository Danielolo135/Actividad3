using System;
using System.Reflection;

class Profesor
{
    public string Nombre;
    public Profesor(string nombre) { Nombre = nombre; }
    public void Mostrar() { Console.WriteLine("Profesor: " + Nombre); }
}

class Alumno
{
    public string Nombre;
    public Alumno(string nombre) { Nombre = nombre; }
    public void Mostrar() { Console.WriteLine("Alumno: " + Nombre); }
}

class Modulo
{
    public string Nombre;
    public Modulo(string nombre) { Nombre = nombre; }
    public void Mostrar() { Console.WriteLine("Módulo: " + Nombre); }
}

class Program
{
    static Profesor profesor;
    static Alumno alumno;
    static Modulo modulo;

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Crear profesor");
            Console.WriteLine("2. Crear alumno");
            Console.WriteLine("3. Crear módulo");
            Console.WriteLine("4. Mostrar todo");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre del profesor: ");
                    profesor = new Profesor(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Nombre del alumno: ");
                    alumno = new Alumno(Console.ReadLine());
                    break;

                case 3:
                    Console.Write("Nombre del módulo: ");
                    modulo = new Modulo(Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine("\n--- DATOS ---");
                    profesor?.Mostrar();
                    alumno?.Mostrar();
                    modulo?.Mostrar();
                    break;
            }

        } while (opcion != 0);
    }
}
