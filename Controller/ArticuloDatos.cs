using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ArticuloDatos
    {

        public List<Articulo> listaArticulos()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();
            try
            {
                datos.setearQuery("select A.Id,Codigo,Nombre, A.Descripcion, IdMarca,IdCategoria,ImagenUrl,Precio, M.Descripcion as marca, C.Descripcion as categoria from ARTICULOS A, MARCAS M , CATEGORIAS C where a.IdCategoria=C.Id and a.IdMarca=M.Id");
                datos.ejecutarLectura();
                while (datos.Lector().Read())
                {
                    Articulo aux = new Articulo();
                    aux.precio = (decimal)datos.Lector()["Precio"];
                    aux.descripcion = (string)datos.Lector()["Descripcion"];
                    aux.nombre = (string)datos.Lector()["Nombre"];
                    aux.imagen = (string)datos.Lector()["ImagenUrl"];
                    aux.codigo = (string)datos.Lector()["Codigo"];
                    aux.id = (int)datos.Lector()["Id"];
                    aux.categoria = new Categoria();
                    aux.categoria.idCategoria = (int)datos.Lector()["idCategoria"];
                    aux.categoria.descripcion = (string)datos.Lector()["categoria"];
                    aux.marca = new Marca();
                    aux.marca.idMarca = (int)datos.Lector()["idMarca"];
                    aux.marca.descripcion = (string)datos.Lector()["marca"];
                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
