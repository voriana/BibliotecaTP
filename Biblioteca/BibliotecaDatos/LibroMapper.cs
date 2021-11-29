using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidades.Entidades;
using BibliotecaEntidades.Modelos;
using Newtonsoft.Json;

namespace BibliotecaDatos
{
    public class LibroMapper
    {
        public TransactionResult AltaLibro(Libro libro)
        {
            NameValueCollection obj = ReverseMap(libro);
            string json = WebHelper.Post("biblioteca/libros", obj);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Libro libro)
        {
            NameValueCollection coleccion = new NameValueCollection();
            coleccion.Add("id",libro.Id.ToString());
            coleccion.Add("Titulo", libro.Titulo);
            coleccion.Add("Autor", libro.Autor);
            coleccion.Add("Editorial", libro.Editorial);
            coleccion.Add("Edicion", libro.Edicion.ToString());
            coleccion.Add("Paginas", libro.Paginas.ToString());
            return coleccion;
        }

        public List<Libro> GetLibros()
        {
            string json = WebHelper.Get("Biblioteca/Libros");
            List<Libro> _libros = LibroMap(json);
            return _libros;
        }

        private List<Libro> LibroMap(string json)
        {
            List<Libro> lst = JsonConvert.DeserializeObject<List<Libro>>(json);
            return lst;
        }
    }
}
