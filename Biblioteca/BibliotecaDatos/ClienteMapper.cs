using BibliotecaEntidades.Entidades;
using BibliotecaEntidades.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaDatos
{
    public class ClienteMapper
    {
        public ClienteMapper()
        {

        }

        public List<Cliente> GetClientes()
        {
            string json = WebHelper.Get("cliente/890175");
            List<Cliente> listaObtenida = MapList(json);
            return listaObtenida;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> _clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return _clientes;
        }
    }
}
