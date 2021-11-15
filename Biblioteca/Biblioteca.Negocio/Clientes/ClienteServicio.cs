using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos.Clientes;
using Biblioteca.Entidades.Negocio;

namespace Biblioteca.Negocio.Clientes

{
    public class ClienteServicio
    {
        private ClienteMapper _clienteMapper;

        public ClienteServicio()
        {
            _clienteMapper = new ClienteMapper();
        }

        public List<Cliente> PedirClientes()
        {
            return _clienteMapper.TraerClientes();
        }
    }
}
