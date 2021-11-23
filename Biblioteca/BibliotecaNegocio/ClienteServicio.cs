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
    public class ClienteServicio
    {
        private ClienteMapper _clienteMapper;
        private List<Cliente> _clientes;

        public ClienteServicio()
        {
            _clienteMapper = new ClienteMapper();
            _clientes = new List<Cliente>();
        }

        public List<Cliente> TraerClientes()
        {
            return _clienteMapper.GetClientes();
        }
    }
}
