using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPO1_Biblioteca
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;
        public bool prestado { get; set;}

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.prestado = false;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public string getAutor()
        {
            return autor;
        }

        public string getEditorial()
        {
            return editorial;
        }

        public override string ToString()
        {
            string info = $"Titulo: {this.getTitulo()}, Autor: {this.getAutor()}, Editorial: {this.getEditorial()}, Prestado: {(this.prestado? "PRESTADO":"DISPONIBLE")}";

            return info;
        }
    }
}
