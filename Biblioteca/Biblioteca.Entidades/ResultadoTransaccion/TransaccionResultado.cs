using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.ResultadoTransaccion
{
    [DataContract]
    public class TransaccionResultado
    {
        private bool _isOk;
        private string _error;
        private int _id;

        [DataMember]
        public bool IsOk { get => _isOk; set => _isOk = value; }
        [DataMember]
        public string Error { get => _error; set => _error = value; }
        [DataMember]
        public int Id { get => _id; set => _id = value; }
    }
}
