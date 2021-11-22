using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Entidades
{
    public class Ejemplar
    {
        private int _id;
        private Libro _libro; //agregacion
        private string _observaciones;
        private double _precio;
        private DateTime _fechaAlta;

        public Ejemplar(int id, Libro libro, string observaciones, double precio, DateTime fechaAlta)
        {
            _id = id;
            _libro = libro;
            _observaciones = observaciones;
            _precio = precio;
            _fechaAlta = fechaAlta;
        }

        public int Id { get => _id; set => _id = value; }
        public Libro Libro { get => _libro; set => _libro = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public override string ToString()
        {
            return $"Id Ejemplar{Id}-Libro titulo:{Libro.Titulo}-Autor: {Libro.Autor}-Precio Ejemplar:{Precio}";
        }

        public string MostrarEnCombo
        {
            get { return $"ejemplar del libro{Libro.Titulo}- fecha Alta:{FechaAlta}-Precio:{Precio}"; }
        }
    }
}
