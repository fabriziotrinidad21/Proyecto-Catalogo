using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CategoriaDatos
    {

        public List<Categoria> listaCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Lector().Read())
                {
                    Categoria aux = new Categoria();
                    aux.idCategoria = (int)datos.Lector()["Id"];
                    aux.descripcion = (string)datos.Lector()["Descripcion"];
                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;

            }
            catch(Exception)
            {
                throw;

            }

        }
    }
}
