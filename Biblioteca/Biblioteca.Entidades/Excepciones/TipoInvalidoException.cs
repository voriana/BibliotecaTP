using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.Excepciones
{
    public class TipoInvalidoException : Exception
    {
        public TipoInvalidoException(string message) : base(message)
        {
        }
    }
}
