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
           
            string json = WebHelper.Get("cliente");
            List<Cliente> listaObtenida = MapList(json);
            return listaObtenida;
        }

        private List<Cliente> MapList(string json)
        {
           
            List<Cliente> _clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return _clientes;
        }

        public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente); //serializacion -> json

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

   
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente", cliente.Id.ToString());
            n.Add("Usuario", cliente.Usuario);
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Telefono", cliente.Telefono);
            n.Add("Email", cliente.Mail);
            n.Add("DNI", cliente.Dni.ToString());
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("FechaNacimiento", cliente.FechaAlta.ToString("yyyy-MM-dd"));
            return n;

        }
    }
}
