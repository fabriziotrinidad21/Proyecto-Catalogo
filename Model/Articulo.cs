using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public decimal precio { get; set; }
        public Categoria categoria { get; set; }
        public Marca marca { get; set; }

    }
}
