using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO1_Biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> librosDisponibles;

        private List<Lector> lectores;

        public Biblioteca()
        {
            this.librosDisponibles = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        public Libro obtenerLibro(string nombreDelLibro)
        {
            Libro libro;
            libro = buscarLibro(nombreDelLibro);
            return libro;
        }

        private Libro buscarLibro(string titulo)
        {
            Libro librobuscado = null;

            int i = 0;

            while (i < this.librosDisponibles.Count && !librosDisponibles[i].getTitulo().Equals(titulo) )
            {
                i++;
            }
            if (i != this.librosDisponibles.Count)
            {
                librobuscado = librosDisponibles[i];
            }
            return librobuscado;
        }

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
           bool seAgrego = false;
            
            if (buscarLibro(titulo) == null)
            {
               Libro nuevoLibro = new Libro(titulo, autor, editorial);
               this.librosDisponibles.Add(nuevoLibro);
                seAgrego = true;
                System.Console.WriteLine("Se agrego el nuevo libro");
            }

            return seAgrego;
        }

        public bool eliminarLibro(string titulo)
        {
            bool eliminar = false;
            Libro libro;
            libro = buscarLibro(titulo);

            if (libro != null)
            {
                librosDisponibles.Remove(libro);
                eliminar = true;
            }

            return eliminar;
        }

        public void listarLibros()
        {
            if (this.librosDisponibles.Count > 0){ 
                foreach (Libro libro in this.librosDisponibles)
                {
                    Console.WriteLine(libro.ToString());
                }
            }else{ 
                Console.WriteLine("No hay libros disponibles");
            }
        }

        public Lector altaLector(string nombre, string dni)
        {
            foreach (Lector lector in this.lectores)
            {
                if (lector.nombre.Equals(nombre) && lector.dni.Equals(dni))
                {
                    Console.WriteLine("Ya existe un lector con ese nombre y DNI.");
                    return null;
                }
            }

            Lector lectorNuevo = new Lector(nombre, dni);
            this.lectores.Add(lectorNuevo);
            return lectorNuevo;
        }

        public String prestarLibro(String titulo, String dni) {
        // Buscar el lector
        Lector lector = buscarLectorPorDni(dni);
        if (lector == null) {
            return "LECTOR INEXISTENTE";
        }

        // Verificar si el lector ya tiene 3 libros
        if (lector.TieneTresLibros() ) {
            return "TOPE DE PRESTAMO ALCAZADO";
        }

        // Buscar el libro por título
        Libro libro = buscarLibroPorTitulo(titulo);
        if (libro == null) {
            return "LIBRO INEXISTENTE";
        }

            // Realizar el préstamo
            //librosDisponibles.Remove(libro);
            libro.prestado = true;
            lector.prestarLibro(libro);

            return "PRESTAMO EXITOSO";
        }

        private Lector buscarLectorPorDni(String dni) {
            foreach (Lector lector in lectores) {
                if (lector.dni == dni) {
                    return lector;
                }
            }
            return null;
        }

        private Libro buscarLibroPorTitulo(String titulo) {
            foreach (Libro libro in librosDisponibles) {
                if (libro.getTitulo() == titulo) {
                    return libro;
                }
            }
            return null;
        }
    }
}
