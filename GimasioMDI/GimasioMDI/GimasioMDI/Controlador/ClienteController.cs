using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GimasioMDI.Repositorio;

namespace GimasioMDI.Controlador
{
    public class ClienteController
    {
        ClienteRepository cliRep = new ClienteRepository();

        // Insertar
        public void InsertarCliente(Cliente cliente)
        {
            cliRep.InsertarCliente(cliente);
        }

        // Buscar
        public Cliente BuscarCliente(int identificacion)
        {
            return cliRep.BuscarCliente(identificacion);
        }

        // Listar
        public DataTable ListarClientes()
        {
            return cliRep.ListarClientes();
        }

        // Filtrar
        public DataTable FiltrarCliente(string texto)
        {
            return cliRep.Filtrar(texto);
        }

        // Eliminar
        public void EliminarCliente(int identificacion)
        {
            cliRep.EliminarCliente(identificacion);
        }

        // Actualizar
        public void ActualizarCliente(Cliente cliente)
        {
            cliRep.ActualizarCliente(cliente);
        }

        // Estadística
        public DataTable EstadisticaCliente()
        {
            return cliRep.EstadisticaCliente();
        }
    }
}
