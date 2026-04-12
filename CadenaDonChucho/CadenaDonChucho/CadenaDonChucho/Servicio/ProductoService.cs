using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadenaDonChucho.Modelo;

namespace CadenaDonChucho.Servicio
{
    public class ProductoService
    {
        List<Producto> lista_producto = new List<Producto>();

        public ProductoService() { }

        public string registrar_producto(Producto producto)
        {
            lista_producto.Add(producto);
            return "Producto registrado correctamente";
        }
        public Producto buscar_producto(int id)
        {
            for (int i = 0; i < lista_producto.Count; i++)
            {
                if (lista_producto[i].codigo == id)
                {
                    return lista_producto[i];
                }
            }
            return null;
        }
        public string actualizar_producto(Producto producto)
        {
            for (int i = 0; i < lista_producto.Count; i++)
            {
                if (lista_producto[i].codigo == producto.codigo)
                {
                    lista_producto[i] = producto;
                    return "Producto actualizado correctamente";
                }
            }
            return null;
        }
    }
}
