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
        private List<Cliente> _clientes;

        public PrestamoServicio()
        {
            _prestamoMapper = new PrestamoMapper();
            _ejemplarServicio = new EjemplarServicio();
            _clienteServicio = new ClienteServicio();
            _prestamos = new List<Prestamo>();
            _ejemplares = new List<Ejemplar>();
            _clientes = new List<Cliente>();





        }
        public TransactionResult EnviarPrestamo(int idCliente, int idEjemplar, bool activo,int plazo,DateTime fechaPres, DateTime fecTentativa, DateTime fechaReal)
        {
           
            //validaciones de negocio
            if (plazo > 15)
            {
                throw new Exception("el plazo max de prestamo son 15 dias");
            }
            Prestamo prestamo = new Prestamo(0,idCliente,idEjemplar,plazo,fechaPres,fechaReal,activo);
            prestamo.FechaDevolucionTentativa = fecTentativa;
            


            TransactionResult result = _prestamoMapper.AltaPrestamo(prestamo);
            return result;
        }
    

        public List<Prestamo> TraerPrestamos()
        {
            _prestamos = _prestamoMapper.GetPrestamos();
            _ejemplares = _ejemplarServicio.TraerEjemplaresConLibros();
         
            foreach (Prestamo prestamo in _prestamos)
            {
               prestamo.Cliente = _clienteServicio.TraerClientePorID(prestamo.IdCliente);
                foreach(Ejemplar ejemplar in _ejemplares)
                {
                    if (prestamo.IdEjemplar == ejemplar.Id)
                    {
                        prestamo.Ejemplar = ejemplar;
                    }
                }
            }
            return _prestamos;
        }

        public List<Prestamo> TraerPrestamosConEjemplares()
        {
            _prestamos=_prestamoMapper.GetPrestamos();
            _clientes = _clienteServicio.TraerClientes();
            _ejemplares= _ejemplarServicio.TraerEjemplaresConLibros();

            foreach(Prestamo pres in _prestamos)
            {
                foreach(Cliente cliente in _clientes)
                {
                    if (pres.IdCliente == cliente.Id)
                    {
                        pres.Cliente = cliente;
                    }
                }
                foreach(Ejemplar ejemplar in _ejemplares)
                {
                    if (pres.IdEjemplar == ejemplar.Id)
                    {
                        pres.Ejemplar = ejemplar;
                    }
                }
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
