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
        private Libro _libro; //agregacion
        private string _observaciones;
        private double _precio;
        private DateTime _fechaAlta;
        private int _idLibro;
        
        public Ejemplar(int id, string observaciones, double precio, DateTime fechaAlta, int idLibro)
        {
            _idEjemplar = id;
            _libro= new Libro();
            _observaciones = observaciones;
            _precio = precio;
            _fechaAlta = fechaAlta;
            _idLibro = idLibro;

        }

        public Ejemplar()
        {
        }

        [DataMember(Name = "id")]
        public int Id { get => _idEjemplar; set => _idEjemplar = value; }
        [DataMember(Name = "idLibro")]
        public int IdLibro { get => _idLibro; set => _idLibro = value; }

        [DataMember(Name = "observaciones")]
        public string Observaciones { get => _observaciones; set => _observaciones = value; }

        [DataMember(Name = "precio")]
        public double Precio { get => _precio; set => _precio = value; }
        [DataMember(Name = "fechaalta")]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public Libro Libros { get => _libro; set => _libro = value; }

            
        public override string ToString()
        {
            return $"Id Ejemplar{Id}-Precio Ejemplar:{Precio}";
        }

        public string MostrarEnCombo
        {
            get =>
                 $"{Id.ToString()}) ${Precio.ToString("0.00")}ARS -Autor: {this.Libros.Autor}";

        }
        public string MostrarEnComboEjemplar
        {
            get =>
                 $"{Id.ToString()}) ${Precio.ToString("0.00")}ARS -Titulo: {this.Libros.Titulo}";

        }





    }
}
