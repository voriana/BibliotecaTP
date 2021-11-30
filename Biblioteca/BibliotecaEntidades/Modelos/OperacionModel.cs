using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidades.Entidades;

namespace BibliotecaEntidades.Modelos
{
    public class OperacionModel
    {
        List<Libro> _libros;

        public OperacionModel(List<Libro> libros)
        {
            _libros = new List<Libro>();
            _libros = libros;
        }

        public int CantidadLibros 
        {
            get
            {
                if (_libros != null)
                {
                    return _libros.Count;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
