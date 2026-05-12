using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimasioMDI.Repositorio
{
    public class ClienteRepository
    {
        //Cadena de conexión a la base de datos, obtenida del archivo de configuración App.config
        private string connection = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
 
        // Insertar Clientes;
        public void InsertarCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarClientes", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", cliente.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                        cmd.Parameters.AddWithValue("@Edad", cliente.Edad);

                        try
                        {
                            // Abrir la conexión a la base de datos
                            conn.Open();
                            // Ejecutar el comando SQL para insertar el cliente
                            cmd.ExecuteNonQuery();

                            // Mostrar un mensaje de éxito al usuario
                            MessageBox.Show("Cliente Insertado Correctamente", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            // Mostrar un mensaje de error al usuario en caso de que ocurra una excepción
                            MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            } catch (Exception ex) 
            { 
                MessageBox.Show("Error al Insertar Cliente: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Buscar Clientes;
        public Cliente BuscarCliente(int id)
        {
            Cliente cliente = null;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {


                    using (SqlCommand cmd = new SqlCommand("sp_BuscarClientes", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", id);

                        try
                        {
                            // Abrir la conexión a la base de datos
                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    cliente = new Cliente
                                    {
                                        Identificacion = reader.GetInt32(0),
                                        Nombre = reader.GetString(1),
                                        Apellido = reader.GetString(2),
                                        Edad = reader.GetInt32(3)
                                    };
                                } else
                                {
                                    MessageBox.Show("Cliente no encontrado", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                        }
                        catch (SqlException ex)
                        {
                            // Mostrar un mensaje de error al usuario en caso de que ocurra una excepción
                            MessageBox.Show("Error al buscar Cliente: " + ex.Message, "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return cliente;
                    }
                }
                catch (SqlException ex)
                {
                    // Mostrar un mensaje de error al usuario en caso de que ocurra una excepción
                    MessageBox.Show("Error al buscar Cliente: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        // Filtrar Clientes
        public DataTable Filtrar(string texto)
        {
            DataTable tableCliente = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_FiltrarCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Texto", texto);


                        // Abrir la conexión a la base de datos
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            tableCliente.Load(reader);
                        }


                    }
                    return tableCliente;
                }
            }
            catch (SqlException ex)
            {
                // Mostrar un mensaje de error al usuario en caso de que ocurra una excepción
                MessageBox.Show("Error al filtrar Cliente: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            } 
        }
        // Listar clientes
        public DataTable ListarClientes()
        {
            DataTable tableCliente = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerClientes", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            tableCliente.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tableCliente;
        }

        // Actualizar Clientes;
        public void ActualizarCliente(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarClientes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", cliente.Identificacion);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@Edad", cliente.Edad);

                    try
                    {
                        // Abrir la conexión a la base de datos
                        conn.Open();
                        // Ejecutar el comando SQL para insertar el cliente
                        cmd.ExecuteNonQuery();

                        // Mostrar un mensaje de éxito al usuario
                        MessageBox.Show("Cliente actualizado Correctamente", "Información",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        // Mostrar un mensaje de error al usuario en caso de que ocurra una excepción
                        MessageBox.Show("Error al actualizar Cliente: " + ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Eliminar Clientes;
        public void EliminarCliente(int id)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("sp_EliminarClientes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    try
                    {
                        // Abrir la conexión a la base de datos
                        conn.Open();
                        // Ejecutar el comando SQL para insertar el cliente
                        cmd.ExecuteNonQuery();

                        // Mostrar un mensaje de éxito al usuario
                        MessageBox.Show("Cliente eliminado Correctamente", "Información",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        // Mostrar un mensaje de error al usuario en caso de que ocurra una excepción
                        MessageBox.Show("Error al eliminar Cliente: " + ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Método para la estadistica de clientes por edad
        public DataTable EstadisticaCliente()
        {
            DataTable tableCliente = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("sp_EstadisticaClientes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        // Abrir la conexión a la base de datos
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            tableCliente.Load(reader);
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Mostrar un mensaje de error al usuario en caso de que ocurra una excepción
                        MessageBox.Show("Error al buscar Cliente: " + ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return tableCliente;
            }
        }
    }
}
