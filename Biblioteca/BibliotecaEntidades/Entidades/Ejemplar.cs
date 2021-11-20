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
        private int _idlibro;
        private string _observaciones;
        private double _precio;
        private DateTime _fechaAlta;

        public Ejemplar(int id, int idlibro, string observaciones, double precio, DateTime fechaAlta)
        {
            _id = id;
            _idlibro = idlibro;
            _observaciones = observaciones;
            _precio = precio;
            _fechaAlta = fechaAlta;
        }

        public int Id { get => _id; set => _id = value; }
        public int Idlibro { get => _idlibro; set => _idlibro = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    }
}
