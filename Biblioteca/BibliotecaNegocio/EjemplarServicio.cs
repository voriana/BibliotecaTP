using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDatos;
using BibliotecaEntidades.Entidades;
using BibliotecaEntidades.Exceptions;
using BibliotecaEntidades.Modelos;

namespace BibliotecaNegocio
{
    public class EjemplarServicio
    {
        private List<Ejemplar> _ejemplares;
        private List<Libro> _libros;
        private EjemplarMapper _Ejemplarmapper;
        private LibroMapper _libroMapper;
        private List<Ejemplar> _ejemplaresPorID;


        public EjemplarServicio()
        {
            _ejemplares = new List<Ejemplar>();
            _libros = new List<Libro>();
            _Ejemplarmapper = new EjemplarMapper();
            _libroMapper = new LibroMapper();
            _ejemplaresPorID = new List<Ejemplar>();
        }
        public List<Ejemplar> TraerEjemplares()
        {
            _ejemplares= _Ejemplarmapper.GetEjemplares();
            return _ejemplares;
        }

        public List<Ejemplar> TraerLibrosEjemplares() 
        {
            _ejemplares = _Ejemplarmapper.GetEjemplares();
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

        private List<Libro> TraerLibros()
        {
            _libros = _libroMapper.GetLibros();
            return _libros;
        }

        public TransactionResult AltaEjemplar(Ejemplar _ejemplarNuevo)
        {

            TransactionResult _resultado = _Ejemplarmapper.Insertar(_ejemplarNuevo);
            if (!_resultado.IsOk)
            {

                throw new TransactionErrorException (_resultado);
            }

            return _resultado;
        }

        public int GenerarIDEjemplar()
        {
            int _prefijo = 0;
            int _idEjemplar = 0;
            Random random = new Random();
            int ultimos3dígitos = random.Next(100, 999);
            _idEjemplar = _prefijo + ultimos3dígitos;
            return _idEjemplar;


        }

        public List<Ejemplar> TraerEjemplaresPorIdLibro(int IdLibro)
        {
            _ejemplares = TraerEjemplares();
    
            foreach (Ejemplar e in _ejemplares)
            {
                if (e.IdLibro == IdLibro)
                {
                    _ejemplaresPorID.Add(e);
                }


             }

            return _ejemplaresPorID;
        }



    }
}
