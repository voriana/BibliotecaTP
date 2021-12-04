using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Entidades
{
    [DataContract]
    public class Libro
    {
        private int _id;
        private string _titulo;
        private string _autor;
        private int _edicion;
        private string _editorial;
        private int _paginas;
        private string _tema;
      

        public Libro(int id, string titulo, string autor, int edicion, string editorial, int paginas, string tema)
        {
            _id = id;
            _titulo = titulo;
            _autor = autor;
            _edicion = edicion;
            _editorial = editorial;
            _paginas = paginas;
            _tema = tema;
           
        }

        public Libro()
        {
        }

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }
        [DataMember(Name = "titulo")]
        public string Titulo { get => _titulo; set => _titulo = value; }
        [DataMember(Name = "Autor")]
        public string Autor { get => _autor; set => _autor = value; }
        [DataMember(Name = "Edicion")]
        public int Edicion { get => _edicion; set => _edicion = value; }
        [DataMember(Name = "Editorial")]
        public string Editorial { get => _editorial; set => _editorial = value; }
        [DataMember(Name = "Paginas")]
        public int Paginas { get => _paginas; set => _paginas = value; }
        [DataMember(Name = "Tema")]
        public string Tema { get => _tema; set => _tema = value; }
     
        public override string ToString()
        {
            return $"Id:{Id}-Autor:{Autor}-Titulo:{Titulo}";
        }
        public string MostrarEnlista
        {
            get { return $"{Id}-{this._titulo}-Autor:{this._autor}"; }
        }

        public String MostrarBusquedaLibro
        {
            get
            {
                return $"{this._id})-Titulo:{this._titulo}-Autor:{this._autor}"; 
            }
        }
        

    }
}
