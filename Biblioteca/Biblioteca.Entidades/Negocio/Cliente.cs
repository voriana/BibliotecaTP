using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.Negocio
{
    [DataContract]
    public class Cliente : Persona
    {
        private int _id;
        private long _cuit;
        private DateTime _fechaNac;
        private string _email;
        private string _telefono;
        private string _direccion;

        public Cliente(int id, string nombre, string apellido,long cuit, DateTime fechaNac, string email, string telefono, string direccion): base(nombre, apellido)
        {
            _id = id;
            _cuit = cuit;
            _fechaNac = fechaNac;
            _email = email;
            _telefono = telefono;
            _direccion = direccion;
           
        }

        public int Id { get => _id; set => _id = value; }
        
        [DataMember(Name ="Dni")]
        public long Cuit { get => _cuit; set => _cuit = value; }
        
        [DataMember(Name = "FechaNacimiento")]
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        [DataMember(Name = "email")]
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }


        public override string ToString()
        {
            return Mostar();
        }
        //Property mostrar
        private string Mostar()
        {
            return string.Format($"Id:{this._id} - Nombre:{this.Nombre} - Apellido: {this.Apellido} - Cuit: {this.Cuit}");
        }
        
    }
}
