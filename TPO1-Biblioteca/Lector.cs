using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO1_Biblioteca
{
    public class Lector
    {
        public string nombre{ get; set; }
        public string dni { get; set; }

        List<Libro> librosPrestados { get; set;}
        

        public Lector (string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            librosPrestados = new List<Libro>();
        }

        public bool TieneTresLibros(){ 
            return librosPrestados.Count >= 3;
        }

        public void prestarLibro(Libro libro) {
            librosPrestados.Add(libro);
    }
    }
}
