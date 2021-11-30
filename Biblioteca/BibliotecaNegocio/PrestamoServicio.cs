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
    public class PrestamoServicio
    {
        private PrestamoMapper _prestamoMapper;
        private EjemplarServicio _ejemplarServicio;
        private ClienteServicio _clienteServicio;
        private List<Prestamo> _prestamos;
        private List<Ejemplar> _ejemplares;

        public PrestamoServicio()
        {
            _prestamoMapper = new PrestamoMapper();
            _ejemplarServicio = new EjemplarServicio();
            _clienteServicio = new ClienteServicio();
            _prestamos = new List<Prestamo>();
            _ejemplares = new List<Ejemplar>();


        }
        public TransactionResult EnviarPrestamo(int idCliente, int idEjemplar, bool activo,int plazo,DateTime fechaPres)
        {
            Prestamo prestamo = new Prestamo();
            //validaciones de negocio
            if (plazo > 30)
            {
                throw new Exception("el plazo max de prestamo son 15 dias");
            }
            prestamo.Id=0;
            prestamo.IdCliente = idCliente;
            prestamo.IdEjemplar = idEjemplar;
            prestamo.Ejemplar = _ejemplarServicio.DevolverEjemplar(idEjemplar);
            prestamo.Cliente = _clienteServicio.TraerClientePorID(idCliente);
            prestamo.Activo = activo;
            prestamo.Plazo = plazo;
            prestamo.FechaPrestamo = fechaPres;

            TransactionResult result = _prestamoMapper.AltaPrestamo(prestamo);
            return result;
        }
        public List<Prestamo> TraerPrestamos()
        {
            _prestamos = _prestamoMapper.GetPrestamos();
            

            foreach (Prestamo prestamo in _prestamos)
            {
                prestamo.Ejemplar = _ejemplarServicio.DevolverEjemplar(prestamo.IdEjemplar);
                prestamo.Cliente = _clienteServicio.TraerClientePorID(prestamo.IdCliente);
            }
           
            return _prestamos;
        }
        public Prestamo DevolverPrestamo(int id)
        {
            Prestamo prestamo = new Prestamo();
            foreach( Prestamo pres in _prestamos)
            {
                if (pres.Id ==id)
                {
                    prestamo = pres;
                }

            }
            return prestamo;
        }
        
    }
}
