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
            _clientes = _clienteMapper.GetClientes();
            return _clientes;
        }

        public TransactionResult AltaCliente(Cliente cliente)
        {
            bool flag = false;
            flag = ClienteYaRegistrado(cliente.Dni);
            if (flag == true)
            {
                throw new ClienteRegistradoException();
            }
            TransactionResult _resultado = _clienteMapper.Insertar(cliente);
            if (flag == false && !_resultado.IsOk)
            {
                
            throw new Exception("error en el alta" + _resultado.Error);
            }
            
            
            return _resultado;

        }
        public int GenerarIDCliente()
        {
            int _prefijo =1;
            int _idCliente = 0;
            Random random = new Random();
            int ultimos3dígitos = random.Next(100, 999);
            _idCliente = _prefijo + ultimos3dígitos;
            return _idCliente;


        }

        public bool ClienteYaRegistrado(int dni)
        {
            List<Cliente> _clientes = _clienteMapper.GetClientes();
            bool _clienteRegistrado = false;
            foreach (Cliente c in _clientes)
            {
                if (c.Dni == dni)
                {
                    _clienteRegistrado = true;
                }
            }

            return _clienteRegistrado;
                
            
        }

        public Cliente TraerClientePorID(int id)
        {

            List<Cliente> _clientes = new List<Cliente>();
            _clientes = _clienteMapper.GetClientes();
            Cliente _cliente = new Cliente();

            foreach (Cliente c in _clientes)
            {
                if (c.Id == id)
                {
                    _cliente = c;
                
                }
            
            }

            return _cliente; 
        }


    }
}
