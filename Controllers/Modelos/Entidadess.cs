using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Entrega
{

    #region ClassUser
    public class Usuarios
    {
        //Atributos

        private long _Id;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private string _Pasword;
        private string _Mail;

        //Propiedades (se hacen validaciones suponiendo que posteriormente se conectara a una BD)

        public long Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string Pasword { get => _Pasword; set => _Pasword = value; }
        public string Mail { get => _Mail; set => _Mail = value; }



        //Constructores
        /*   public Usuarios(long id, string nombre, string apellido, string nombreUsuario, string pasword, string mail)
               {
                   _Id = id;
                   _Nombre = nombre;
                   _Apellido = apellido;
                   _NombreUsuario = nombreUsuario;
                   _Pasword = pasword;
                   _Mail = mail;
               }
           */

    }


    #endregion

    #region ClassProduct
    public class Producto
    {
        //Atributos

        private long _IdProducto;
        private string _Descripcion;
        private decimal _Costo;
        private decimal _PrecioVenta;
        private int _Stock;
        private long _IdUsuario;

        //Propiedades

        public long IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
        public decimal PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public long IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }


        //Constructor
        /*  public Producto (long idProducto, string descripcion, decimal costo, decimal precioVenta, int stock, long idUsuario)
          {
              _IdProducto = idProducto;
              _Descripcion = descripcion;
              _Costo = costo;
              _PrecioVenta = precioVenta;
              _Stock = stock;
              _IdUsuario = idUsuario;
          }*/


        #endregion
    }

    #region ClassProductSold
    public class ProductoVendido
    {
        //Atributos

        private long _Id;
        private long _IdProductoVendido;
        private int _Stock;
        private long _IdVenta;

        //Porpiedades
        public long Id { get => _Id; set => _Id = value; }
        public long IdProductoVendido { get => _IdProductoVendido; set => _IdProductoVendido = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public long IdVenta { get => _IdVenta; set => _IdVenta = value; }


        /*  //Constructor
          public ProductoVendido(long id, long idProductoVendido, int stock, long idVenta)
          {
              _Id = id;
              _IdProductoVendido = idProductoVendido;
              _Stock = stock;
              _IdVenta = idVenta;
          }*/



        #endregion
    }

    #region ClassSale
    public class Venta
    {
        //Atributos

        private long _Id;
        private string _Comentarios;
        //  private int _IdUsuario;


        //Propiedades
        public long Id { get => _Id; set => _Id = value; }
        public string Comentarios { get => _Comentarios; set => _Comentarios = value; }
        // public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }


        /*      //Constructor
              public Venta(long id, string comentarios)//, int idUsuario)
              {
                  _Id = id;
                  _Comentarios = comentarios;
                //  _IdUsuario = idUsuario;
              }*/
        #endregion
    }


}
