using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidades.Entidades;
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
    }
}
