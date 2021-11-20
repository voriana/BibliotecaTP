using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidades.Entidades;
using BibliotecaEntidades.Modelos;
using Newtonsoft.Json;




namespace BibliotecaDatos
{
    public class PrestamoMapper
    {
        

        public PrestamoMapper()
        {
            
        }

        public List<Cliente> getClientes()
        {
            string json = WebHelper.Get("cliente");
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
