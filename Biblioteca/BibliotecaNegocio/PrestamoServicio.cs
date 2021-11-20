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
    public class PrestamoServicio
    {
        private PrestamoMapper _prestamoMapper;
        private List<Cliente> _clientes;

        public PrestamoServicio()
        {
            _prestamoMapper = new PrestamoMapper();
            _clientes = new List<Cliente>();
        }

        public List<Cliente> TraerClientes()
        {
            return _prestamoMapper.getClientes();
        }
    }
}
