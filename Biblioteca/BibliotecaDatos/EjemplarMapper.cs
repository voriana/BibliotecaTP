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
    public class EjemplarMapper
    {
        public List<Ejemplar> GetEjemplares()
        {
            string json = WebHelper.Get("Biblioteca/Ejemplares");
            List<Ejemplar> lst = EjemplarMap(json);
            return lst;
        }

        private List<Ejemplar> EjemplarMap(string json)
        {
            List<Ejemplar> ejemplares = JsonConvert.DeserializeObject<List<Ejemplar>>(json);
            return ejemplares;
        }

        public TransactionResult Insertar(Ejemplar ejemplar)
        {
            NameValueCollection n = new NameValueCollection();
            n = ReverseMap(ejemplar);
            string json = WebHelper.Post("Biblioteca/Ejemplares", n);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Ejemplar ejemplar)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", ejemplar.Id.ToString());
            n.Add("Observaciones", ejemplar.Observaciones);
            n.Add("Precio", ejemplar.Precio.ToString("0.00"));
            n.Add("idLibro", ejemplar.IdLibro.ToString());
            n.Add("Usuario", "889350");

            return n;

        }

    }
}
