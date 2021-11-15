using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos.Helpers;
using Biblioteca.Entidades.Negocio;
using Newtonsoft.Json;

namespace Biblioteca.Datos.Clientes
{
    public class ClienteMapper
    {
        
        public List<Cliente> _clientes;

        public  List<Cliente> TraerClientes()
        {
            string jsonDevuelto = WebHelper.Get("Cliente");
            _clientes = MapperLista(jsonDevuelto); //Mapperlista deserializa
            return _clientes;
        }

        private List<Cliente> MapperLista(string jsonDevuelto)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(jsonDevuelto);
            return lst;
        }

    }
}
