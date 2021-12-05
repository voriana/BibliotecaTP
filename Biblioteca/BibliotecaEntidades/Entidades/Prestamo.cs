using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Entidades
{
    [DataContract]
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

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Ejemplar Ejemplar { get => _ejemplar; set => _ejemplar = value; }

        [DataMember(Name = "Plazo")]
        public int Plazo { get => _plazo; set => _plazo = value; }
        [DataMember(Name = "fechaPrestamo")]
        public DateTime FechaPrestamo { get => _fechaPrestamo; set => _fechaPrestamo = value; }
        [DataMember(Name = "fechaDevolucionTentativa")]
        public DateTime FechaDevolucionTentativa { get => _fechaDevolucionTentativa; set => _fechaDevolucionTentativa = value; }
        
        [DataMember(Name = "fechaDevolucionReal")]
        public DateTime FechaDevolucionReal { get => _fechaDevolucionReal; set => _fechaDevolucionReal = value; }
        
        [DataMember(Name = "Abierto")]
        public bool Activo { get => _activo; set => _activo = value; }

        [DataMember(Name = "idCliente")]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember(Name = "idEjemplar")]
        public int IdEjemplar { get => _idEjemplar; set => _idEjemplar = value; }

        public string ActivoString
        {
            get
            {
                string estado = "";
                if (Activo.Equals(false))
                {
                    estado = "Cerrado";
                }
                else
                {
                    estado = "Abierto";
                }

                return estado;
            }
        }



        public string MostrarEnListaPrestamos
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
                return $"{this.Id}){this.Cliente.Nombre} {this.Cliente.Apellido}- {this.Ejemplar.Libros.Titulo} (${this.Ejemplar.Precio}-ARGS) Cantidad:{this.Plazo}dias -{this.ActivoString}";
            }
        }

        public string MostrarComboListarPrestamos
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
                return $"{this.Cliente.Nombre} {this.Cliente.Apellido}";
            }
        }

       
        
    }
    
}
