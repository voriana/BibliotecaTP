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
        private int _idCliente;
        private int _idEjemplar;
        private int _plazo;
        private DateTime _fechaPrestamo;
        private DateTime _fechaDevolucionTentativa;
        private DateTime _fechaDevolucionReal;
        private bool _activo;
        private Cliente _cliente;
        private Ejemplar _ejemplar;

        public Prestamo()
        {
        }

        public Prestamo(int id,int cliente, int ejemplar, int plazo, DateTime fechaPrestamo, DateTime fechaDevolucionReal, bool activo)
        {
            _id = id;
            _idCliente = cliente;
            _idEjemplar = ejemplar;
            _plazo = plazo;
            _fechaPrestamo = fechaPrestamo;
            _fechaDevolucionReal = fechaDevolucionReal;
            _activo = activo;
           
        }

        public int Id { get => _id; set => _id = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Ejemplar Ejemplar { get => _ejemplar; set => _ejemplar = value; }
        public int Plazo { get => _plazo; set => _plazo = value; }
        public DateTime FechaPrestamo { get => _fechaPrestamo; set => _fechaPrestamo = value; }

        public DateTime FechaDevolucionReal { get => _fechaDevolucionReal; set => _fechaDevolucionReal = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEjemplar { get => _idEjemplar; set => _idEjemplar = value; }
        //autocalculada
        public DateTime FechaDevolucionTentativa
        {
            get
            {
                return _fechaDevolucionTentativa = (FechaPrestamo.AddDays(Plazo));
            }
        }



        public string MostrarEnLista
        {
            get
            {
                if (this.Ejemplar == null)
                {
                  
                    this.Ejemplar = new Ejemplar();
                    {
                        this.Ejemplar.Libros = new Libro();
                    }
                }
                return $"{this.Id}-{this.Cliente.Apellido} {this.Cliente.Nombre}-{this.Ejemplar.MostrarEnCombo}-ARGS: {this.Ejemplar.Precio}";
            }
        }
    }
    
}
