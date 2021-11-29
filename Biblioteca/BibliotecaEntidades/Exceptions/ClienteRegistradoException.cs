using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Exceptions
{
    public class ClienteRegistradoException : Exception
    {
        public ClienteRegistradoException() : base("El cliente ya esta Registado")
        {

        }
    }
}
