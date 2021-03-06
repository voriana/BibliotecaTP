using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDatos;
using BibliotecaEntidades.Entidades;
using BibliotecaEntidades.Modelos;

namespace BibliotecaNegocio
{
    public class LibroServicio
    {
        private LibroMapper _libroMapper;

        public LibroServicio()
        {
            _libroMapper = new LibroMapper();
        }

        public TransactionResult AgregarLibro( string autor, string titulo, string tema, string editorial, int edicion, int pags)
        {
            int id = 0;
            //validaciones de negocio
            //anio actual
            int anio = DateTime.Now.Year;
            if (edicion > anio)
            {
                throw new Exception("El anio de edicion no puede ser mayor al actual");
            }
            if (pags <= 0)
            {
                throw new Exception("Un libro debe contener al menos una pagina");
            }

            Libro libro = new Libro(id, titulo, autor, edicion, editorial, pags, tema);
            TransactionResult resultado = _libroMapper.AltaLibro(libro);
            return resultado;

        }

        public List<Libro> TraerLibros()
        {
             return _libroMapper.GetLibros();
        }


        public Libro TraerLibroPorId(int id)
        {

            List<Libro> _libros = _libroMapper.GetLibros();
            Libro _libro = new Libro();

            foreach (Libro l in _libros)
            {
                if (l.Id == id)
                {
                    _libro = l;
                }    
            
            }

            return _libro;

        
        }
        public int GenerarIdLibro()
        {
            int IdLibro;
            Random n = new Random();
            IdLibro = n.Next(100, 200);
            return IdLibro;
        }
    }
}
