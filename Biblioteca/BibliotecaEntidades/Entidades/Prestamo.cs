using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Entidades
{
    public class Prestamo
    {
        private int _id;
        private int _idcliente;
        private int _idEjemplar;
        private int _plazo;
        private DateTime _fechaPrestamo;
        private DateTime _fechaDevolucionTentativa;
        private DateTime _fechaDevolucionReal;

        public Prestamo(int id, int idcliente, int idEjemplar, int plazo, DateTime fechaPrestamo, DateTime fechaDevolucionTentativa, DateTime fechaDevolucionReal)
        {
            _id = id;
            _idcliente = idcliente;
            _idEjemplar = idEjemplar;
            _plazo = plazo;
            _fechaPrestamo = fechaPrestamo;
            _fechaDevolucionTentativa = fechaDevolucionTentativa;
            _fechaDevolucionReal = fechaDevolucionReal;
        }

        public int Id { get => _id; set => _id = value; }
        public int Idcliente { get => _idcliente; set => _idcliente = value; }
        public int IdEjemplar { get => _idEjemplar; set => _idEjemplar = value; }
        public int Plazo { get => _plazo; set => _plazo = value; }
        public DateTime FechaPrestamo { get => _fechaPrestamo; set => _fechaPrestamo = value; }
        public DateTime FechaDevolucionTentativa { get => _fechaDevolucionTentativa; set => _fechaDevolucionTentativa = value; }
        public DateTime FechaDevolucionReal { get => _fechaDevolucionReal; set => _fechaDevolucionReal = value; }
    }
}
