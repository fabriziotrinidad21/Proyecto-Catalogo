using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using Model;
using System.Data.SqlClient;
using System.Data;
namespace Controller
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector()
        {
            return this.lector;
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security= true");
            comando = new SqlCommand();
        }

        public void setearQuery(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        public void setearConParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }

        public void insertarElemento(Articulo aux)

        { AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) VALUES (@cod,@nombre,@descripcion,@idmarca,@idcategoria,@url,@precio)");
               
                datos.setearConParametros("@cod",aux.codigo);
                datos.setearConParametros("@nombre", aux.nombre);
                datos.setearConParametros("@descripcion", aux.descripcion);
                datos.setearConParametros("@idmarca", aux.marca.idMarca);
                datos.setearConParametros("@idcategoria", aux.categoria.idCategoria);
                datos.setearConParametros("@url", aux.imagen);
                datos.setearConParametros("@precio", aux.precio);

                datos.ejecutarAccion();
                
            } 
            catch(Exception)
            {
                throw;
            }

        }

        public void EliminarElemento(Articulo aux)

        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("DELETE from ARTICULOS  WHERE Id=@id");
                datos.setearConParametros("@id", aux.id);
                datos.ejecutarAccion();

            }
            catch (Exception)
            {
                throw;
            }

        }
        public void ModificarElemento(Articulo aux)

        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("UPDATE ARTICULOS SET Codigo=@cod,Nombre=@nombre,Descripcion=@descripcion,IdMarca=@idmarca,IdCategoria=@idcategoria,ImagenUrl=@url,Precio=@precio where Id=@id");
                datos.setearConParametros("@id",aux.id);
                datos.setearConParametros("@cod", aux.codigo);
                datos.setearConParametros("@nombre", aux.nombre);
                datos.setearConParametros("@descripcion", aux.descripcion);
                datos.setearConParametros("@idmarca", aux.marca.idMarca);
                datos.setearConParametros("@idcategoria", aux.categoria.idCategoria);
                datos.setearConParametros("@url", aux.imagen);
                datos.setearConParametros("@precio", aux.precio);

                datos.ejecutarAccion();

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
        }
        public void cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector= comando.ExecuteReader();

            }
            catch (Exception)
            {

            }
        }



    }
}
