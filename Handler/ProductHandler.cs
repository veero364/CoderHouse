using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Entrega.Handler
{
    public static class ProductHandler
    {
        //Conector
        internal static string _Cnn = "Data Source =.\\SQLEXPRESS;AttachDbFilename=C:\\BASE_DE_DATOS\\SistemaGestion_.mdf;Integrated Security = True; Connect Timeout = 30";

        public static List<Producto> ObtenerProductos(string Descripcion)
        {
            List<Producto> ListProductos = new List<Producto>();

            //Conexión a DB
            using (SqlConnection conx = new SqlConnection(_Cnn))
            {
                //Comando a ejecutar
                //using (SqlCommand comando = new SqlCommand("SELECT * FROM Producto WHERE Producto.IdUsuario = Id;", conx))
                using (SqlCommand comando = new SqlCommand("SELECT * FROM Producto; ", conx))
                {

                    //Abrimos conexión
                    conx.Open();
                    //Creo DataReader y ejecuto para recuperar datos
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)//corrobora haya filas
                    {
                        while (reader.Read())//lee por fila
                        {

                            Producto productoLista = new Producto();

                            productoLista.IdProducto = reader.GetInt64(0);
                            productoLista.Descripcion = reader.GetString(1);
                            productoLista.Costo = reader.GetDecimal(2);
                            productoLista.PrecioVenta = reader.GetDecimal(3);
                            productoLista.Stock = reader.GetInt32(4);
                            productoLista.IdUsuario = reader.GetInt64(5);
                            comando.Parameters.AddWithValue("IdUsuario", Descripcion);
                            Console.WriteLine(@Descripcion);
                            Console.WriteLine(productoLista);
                            ListProductos.Add(productoLista);

                            Console.WriteLine("ListaProductos", reader.HasRows);
                        }

                        Debug.WriteLine("aqui", ListProductos);

                    }
                    conx.Close();
                    Debug.WriteLine("aqui2", ListProductos);
                    return ListProductos;


                }

            }
        }

    }
}
