using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.Negocio
{
    [DataContract]
    public abstract class Persona
    {
        protected  string _nombre;
        protected  string _apellido;

        public Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        [DataMember(Name ="apellido")]
        public  string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember(Name = "nombre")]
        public  string Nombre { get => _nombre; set => _nombre = value; }
    }
}
