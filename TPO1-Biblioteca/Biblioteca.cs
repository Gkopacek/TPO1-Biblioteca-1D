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

        public Biblioteca()
        {
            this.libros = new List<Libro>();
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
    }
}
