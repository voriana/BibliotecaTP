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
        //private List<Ejemplar> _ejemplaresPorID;


        public EjemplarServicio()
        {
            _ejemplares = new List<Ejemplar>();
            _libros = new List<Libro>();
            _Ejemplarmapper = new EjemplarMapper();
            _libroMapper = new LibroMapper();
            //_ejemplaresPorID = new List<Ejemplar>();
        }
      
 
        public List<Ejemplar> TraerEjemplares()
        {
            _ejemplares= _Ejemplarmapper.GetEjemplares();
            return _ejemplares;
        }

        public List<Ejemplar> TraerEjemplaresConLibros() 
        {

            _ejemplares = _Ejemplarmapper.GetEjemplares();

            _libros = _libroMapper.GetLibros();
           
            foreach( var ejemplar in _ejemplares)
            {
                if (ejemplar.Libros == null)
                {
                    foreach (var libro in _libros)
                    {
                        if (ejemplar.IdLibro == libro.Id)
                        {
                            ejemplar.Libros = libro;
                        }

                    }
                }
            }
            return _ejemplares;
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


        public List<Ejemplar> TraerEjemplaresPorIdLibro(int IdLibro)
        {
            List<Ejemplar> _ejemplaresPorID = new List<Ejemplar>();
            _ejemplares = TraerEjemplaresConLibros();
    
            foreach (Ejemplar e in _ejemplares)
            {
                if (e.IdLibro == IdLibro)
                {
                    _ejemplaresPorID.Add(e);
                }

            }

            return _ejemplaresPorID;
        }

        //Devolver ejemplar
         public Ejemplar DevolverEjemplar(int id)
         {
            _ejemplares = TraerEjemplaresConLibros();
            Ejemplar ejemplar = new Ejemplar();
            foreach(Ejemplar ejem in _ejemplares)
            {
                if (ejem.Id== id)
                {
                    ejemplar = ejem;
                }
            }
            return ejemplar;
         }


    }
}
