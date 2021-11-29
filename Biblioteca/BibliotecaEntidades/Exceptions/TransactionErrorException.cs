using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidades.Modelos;

namespace BibliotecaEntidades.Exceptions
{
    public class TransactionErrorException : Exception
    {
        public TransactionErrorException(TransactionResult result) : base("Error al dar de alta. Detalle: " + result.Error)
        {
        }
    }
}
