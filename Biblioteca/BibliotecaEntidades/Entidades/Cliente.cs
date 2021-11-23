using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Entidades
{
    [DataContract]
    public class Cliente: Persona
    {
        private int _id;
        private DateTime _fechaAlta;
        private bool _activo;
         
      

        public Cliente(int id, DateTime fAlta, bool activo,int dni, string nombre, string apellido, string direccion, string telefono, string mail): base(dni, nombre, apellido, direccion, telefono,mail)
        {
            _id = id;
            _fechaAlta = fAlta;
            _activo = activo;

        }
        [DataMember(Name ="Id")]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Name = "fechaAlta")]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
       
        [DataMember(Name = "activo")]
        public bool Activo { get => _activo; set => _activo = value; }

        public override string ToString()
        {
            return $"Id:{Id} - { base.DatosPersonales()}";
        }

        public string MostrarCombo
        {
            get { return $"{this.Nombre} {this.Apellido}"; }
        }
       
    }
}
