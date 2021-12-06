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
        List<Prestamo> _prestamos;

        public OperacionModel()
        {
        }

        public OperacionModel(List<Prestamo> prestamos)
        {
            _prestamos = new List<Prestamo>();
            _prestamos = prestamos;

        }

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

        public int CantidadPrestamos
        {
            get
            {
                if (_prestamos != null)
                {
                    return _prestamos.Count;
                }
                else
                {
                    return 0;
                }
            }
         
        }
    }
}
