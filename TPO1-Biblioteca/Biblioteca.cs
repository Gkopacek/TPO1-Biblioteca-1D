using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO1_Biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
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

            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
            {
                i++;
            }
            if (i != libros.Count)
            {
                librobuscado = libros[i];
            }
            return librobuscado;
        }

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
           bool seAgrego = false;
            
            if (buscarLibro(titulo) == null)
            {
               Libro nuevoLibro = new Libro(titulo, autor, editorial);
               libros.Add(nuevoLibro);
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
                libros.Remove(libro);
                eliminar = true;
            }

            return eliminar;
        }

        public void listarLibros()
        {
            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro);
            }

        }

        public Lector altaLector(string nombre, string dni)
        {
            foreach (Lector lector in lectores)
            {
                if (lector.getNombre().Equals(nombre) && lector.getDni().Equals(dni))
                {
                    Console.WriteLine("Ya existe un lector con ese nombre y DNI.");
                    return null;
                }
            }

            Lector lectorNuevo = new Lector(nombre, dni);
            this.lectores.Add(lectorNuevo);
            return lectorNuevo;
        }
    }
}
