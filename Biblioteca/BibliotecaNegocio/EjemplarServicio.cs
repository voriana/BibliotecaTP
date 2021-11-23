using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDatos;
using BibliotecaEntidades.Entidades;

namespace BibliotecaNegocio
{
    public class EjemplarServicio
    {
        private List<Ejemplar> _ejemplares;
        private List<Libro> _libros;
        private EjemplarMapper _mapper;
        private LibroMapper _libroMapper;
        

        public EjemplarServicio()
        {
            _ejemplares = new List<Ejemplar>();
            _libros = new List<Libro>();
            _mapper = new EjemplarMapper();
            _libroMapper = new LibroMapper();
        }
        public List<Ejemplar> TraerEjemplares()
        {
            _ejemplares= _mapper.GetEjemplares();
            return _ejemplares;
        }

        public List<Ejemplar> TraerLibrosEjemplares() 
        {
            _ejemplares = _mapper.GetEjemplares();
            _libros = _libroMapper.GetLibros();
           
            foreach( var ejemplar in _ejemplares)
            {
               foreach(var libro in _libros)
                {
                    if (ejemplar.Libros is null)
                    {
                        ejemplar.Libros = libro;
                    }
                   
               }
            }
            return _ejemplares;
        }
    }
}
