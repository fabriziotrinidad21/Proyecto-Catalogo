using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace ProyectoCatalogo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void mostrarImagen(string url)
        {
            try
            {
                picBoxImagen.Load(url);
            }
            catch (Exception)
            {
                picBoxImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBMlmZMyak30Jn6GOX4jFDAyu90OLghCqL23-lwES2yA&s=10");
            }
        }

        private void cargar()
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloDatos datos = new ArticuloDatos();
            lista = datos.listaArticulos();
            dgvArticulos.DataSource = lista;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            mostrarImagen(lista[0].imagen);
        }

        public void Inicio_Load(object sender, EventArgs e)
        {
            cargar();
          

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            mostrarImagen(seleccionado.imagen);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vtnDatos agregar = new vtnDatos();
            agregar.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   Articulo aux = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            vtnDatos modificar = new vtnDatos(aux);
            modificar.ShowDialog();
            cargar();
        }
    }
}
