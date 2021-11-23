using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Entidades
{
    [DataContract]
    public class Persona
    {
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _mail;
        public Persona()
        {
        }

        public Persona(int dni, string nombre, string apellido, string direccion, string telefono, string mail)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _mail = mail;
        }

        [DataMember(Name = "DNI")]
        public int Dni { get => _dni; set => _dni = value; }
        [DataMember(Name = "nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember(Name = "apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }
        [DataMember(Name = "Direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }
        [DataMember(Name = "Telefono")]
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Mail { get => _mail; set => _mail = value; }

        public string DatosPersonales()
        {
            return string.Format($"Dni:{this.Dni} - Nombre:{this.Nombre} - Apellido{this.Apellido}");
        }
          
        public string DatosContacto()
        {
            return $"Mail{this.Mail}- Telefono {this.Telefono}- Direccion {this.Direccion}";
        }
        public override string ToString()
        {
            return DatosPersonales()+ DatosContacto();
        }

    }
}
