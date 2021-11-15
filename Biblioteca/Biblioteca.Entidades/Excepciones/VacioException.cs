using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.Excepciones
{
    public class VacioException : Exception
    {
        public VacioException(object obj) : base($"Los campos de  {obj.ToString()} son obligatorios ")
        {
        }
    }
}
