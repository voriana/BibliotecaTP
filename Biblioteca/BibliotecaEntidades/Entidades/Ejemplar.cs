using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Entidades
{
    [DataContract]
    public class Ejemplar
    {
        private int _idEjemplar;
        private Libro _idLibro; //agregacion
        private string _observaciones;
        private double _precio;
        private DateTime _fechaAlta;

        public Ejemplar(int id, Libro libro, string observaciones, double precio, DateTime fechaAlta)
        {
            _idEjemplar = id;
            _idLibro = libro;
            _observaciones = observaciones;
            _precio = precio;
            _fechaAlta = fechaAlta;
        }

        [DataMember(Name ="id")]
        public int Id { get => _idEjemplar; set => _idEjemplar = value; }

        public Libro Libros { get => _idLibro; set => _idLibro = value; }

        [DataMember(Name = "observaciones")]
        public string Observaciones { get => _observaciones; set => _observaciones = value; }

        [DataMember(Name = "precio")]
        public double Precio { get => _precio; set => _precio = value; }
        [DataMember(Name = "fechaalta")]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public override string ToString()
        {
            return $"Id Ejemplar{Id}-Precio Ejemplar:{Precio}";
        }

        public string MostrarEnCombo
        {
            get { return $"{Id}- {Libros.Titulo}"; }
        }
    }
}
