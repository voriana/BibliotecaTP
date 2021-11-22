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
        private EjemplarMapper _mapper;

        public EjemplarServicio()
        {
            _ejemplares = new List<Ejemplar>();
            _mapper = new EjemplarMapper();
        }
        public List<Ejemplar> TraerEjemplares()
        {
            return _mapper.GetEjemplares();
        }
    }
}
