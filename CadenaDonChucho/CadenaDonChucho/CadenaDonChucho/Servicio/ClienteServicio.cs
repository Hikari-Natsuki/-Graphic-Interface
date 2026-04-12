using CadenaDonChucho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDonChucho.Servicio
{
    public class ClienteServicio
    {
        List<Cliente> lista_cliente = new List<Cliente>();

        public string registrar_usuario(Cliente cliente)
        {
            lista_cliente.Add(cliente);
            return "Cliente registrado correctamente";
        }
        public Cliente buscar_clientes(int id)
        {
            for (int i = 0; i < lista_cliente.Count; i++)
            {
                if (lista_cliente[i].codigo == id)
                {
                    return lista_cliente[i];
                }
            }
            return null;
        }
    }
}
