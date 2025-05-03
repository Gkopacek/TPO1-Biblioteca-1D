using System;

namespace TPO1_Biblioteca
{ 
    internal class Lector
    {
        private string nombre;
        private string dni;

        List<Libro> librosPrestados { get; set; }

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            librosPrestados = new List<Libro>();
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getDni()
        {
            return this.dni;
        }

        public void setDni(string dni)
        {
            this.dni = dni;
        }


        public bool TieneTresLibros()
        {
            return librosPrestados.Count >= 3;
        }
    }   
}

