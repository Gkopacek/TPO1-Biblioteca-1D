using System;
using TPO1_Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        bool encendido = true;
        int opcion;

        Biblioteca biblioteca = new Biblioteca();
        
        while (encendido)

        {
            // Mostrar el menú
            Console.WriteLine("\n--- Menú de Gestión de Libros ---");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Agregar libro");
            Console.WriteLine("3. Borrar libro");
            Console.WriteLine("4. Listar libros");
            Console.WriteLine("0. Salir");
            Console.Write("\nIngrese el número de opción: ");

            // Leer la entrada del usuario y convertirla a entero
            string input = Console.ReadLine();
            if (!int.TryParse(input, out opcion))
            {
                Console.WriteLine("Opción no válida. Por favor ingrese un número.");
                continue;
            }

            // Estructura de control switch para disparar los métodos
            
            switch (opcion)
            {
                case 1:
                    // BuscarLibro();
                    Console.Write("Cual es el titulo del libro que estas buscando?: ");
                    string tituloLibro = Console.ReadLine();
                    Libro libroEncontrado = biblioteca.obtenerLibro(tituloLibro);

                    if (libroEncontrado != null)
                    {
                        Console.WriteLine($"Se encontró el libro: Título - {libroEncontrado.getTitulo()}, Autor - {libroEncontrado.getEditorial}, Editorial - {libroEncontrado.getEditorial}");
                    }
                    else
                    {
                        Console.WriteLine($"No se encontró ningún libro con el título '{tituloLibro}'.");
                    }

                    break;

                case 2:
                    // AgregarLibro();

                    string titulo, autor, editorial;

                    Console.Write("\nIngrese el título del libro: ");
                    titulo = Console.ReadLine();

                    Console.Write("Ingrese el autor del libro: ");
                    autor = Console.ReadLine();

                    Console.Write("Ingrese la editorial del libro: ");
                    editorial = Console.ReadLine();

                    bool respuestaAgregar = biblioteca.agregarLibro(titulo, autor, editorial);

                    if (respuestaAgregar)
                    {
                        Console.WriteLine($"El libro '{titulo}' de {autor} publicado por {editorial} se agregó con éxito.");
                    }
                    else
                    {
                        Console.WriteLine($"Ya existe un libro con el título '{titulo}'.");
                    }

                    break;

                case 3:
                    // BorrarLibro();

                    Console.Write("Indique el titulo del libro que quiere borrar de la base de datos: ");
                    string tituloEliminar = Console.ReadLine();
                    bool respuestaEliminar = biblioteca.eliminarLibro(tituloEliminar);

                    if (respuestaEliminar)
                    {
                        Console.WriteLine($"El libro '{tituloEliminar}' se eliminó con éxito.");
                    }
                    else
                    {
                        Console.WriteLine($"No existe ningún libro con el título '{tituloEliminar}'.");
                    }

                    break;

                case 4:
                    // ListarLibro();
                    biblioteca.listarLibros();
                    break;

                case 0:
                    encendido = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

}
