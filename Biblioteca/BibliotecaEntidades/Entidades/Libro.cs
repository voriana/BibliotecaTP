﻿using System;
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
        private int _idEjemplar;

        public Libro(int id, string titulo, string autor, int edicion, string editorial, int paginas, string tema, int idEjemplar)
        {
            _id = id;
            _titulo = titulo;
            _autor = autor;
            _edicion = edicion;
            _editorial = editorial;
            _paginas = paginas;
            _tema = tema;
            _idEjemplar = idEjemplar;
        }

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }
        [DataMember(Name = "titulo")]
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int Edicion { get => _edicion; set => _edicion = value; }
        public string Editorial { get => _editorial; set => _editorial = value; }
        public int Paginas { get => _paginas; set => _paginas = value; }
        public string Tema { get => _tema; set => _tema = value; }
        public int IdEjemplar { get => _idEjemplar; set => _idEjemplar = value; }

        public override string ToString()
        {
            return $"Id:{Id}-Autor:{Autor}-Titulo:{Titulo}-Tema:{Tema}";
        }
        public string MostrarEnlista
        {
            get { return $"Titulo:{Titulo}-Autor:{Autor}"; }
        }

        
    }
}
