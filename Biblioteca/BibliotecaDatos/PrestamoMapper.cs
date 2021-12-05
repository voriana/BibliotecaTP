using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private List<Prestamo> _prestamos;
        private List<Cliente> _clientes;
        private List<Ejemplar> _ejemplar;
        private ClienteMapper _clienteMapper;
        private EjemplarMapper _ejemplarMapper;
        public PrestamoMapper()
        {
            _prestamos = new List<Prestamo>();
            _clientes = new List<Cliente>();
            _ejemplar = new List<Ejemplar>();
            _clienteMapper = new ClienteMapper();
            _ejemplarMapper = new EjemplarMapper();
        }
        public TransactionResult AltaPrestamo(Prestamo prestamo)
        {
            NameValueCollection obj = new NameValueCollection();
            obj = ReverseMap(prestamo);
            string json = WebHelper.Post("Biblioteca/Prestamos", obj);
            TransactionResult result=JsonConvert.DeserializeObject<TransactionResult>(json);
            return result;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", 0.ToString());
            n.Add("idCliente", prestamo.IdCliente.ToString());
            n.Add("idEjemplar", prestamo.IdEjemplar.ToString());
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("Abierto", prestamo.Activo.ToString());
            n.Add("FechaPrestamo", prestamo.FechaPrestamo.ToString("yyyy-MM-dd"));
            n.Add("FechaDevolucionTentativa", prestamo.FechaDevolucionTentativa.ToString("yyyy-MM-dd"));
            n.Add("FechaDevolucionReal", prestamo.FechaDevolucionReal.ToString("yyyy-MM-dd"));
            return n;

        }
        public List<Prestamo> GetPrestamos()
        {
            string json = WebHelper.Get("Biblioteca/Prestamos");
            _prestamos = PresMap(json);
            return _prestamos;
        }

        private List<Prestamo> PresMap(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }

    }
}
