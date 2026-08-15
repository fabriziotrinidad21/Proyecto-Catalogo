using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class MarcaDatos
    {
        public List<Marca> listaMarcas()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector().Read())
                {
                    Marca aux = new Marca();
                    aux.idMarca = (int)datos.Lector()["Id"];
                    aux.descripcion = (string)datos.Lector()["descripcion"];
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
