using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Exceptions
{
    public class ErrorAlta:Exception
    {
        public ErrorAlta() : base("Error En el alta")
        {

        }
    }
}
