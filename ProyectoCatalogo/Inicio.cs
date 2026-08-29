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
        private List<Articulo> lista;
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
               // picBoxImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSBTO8WZ84puTB_Az1s5EU5E9gm5EBkVyc_4o14bnL9onTQHaUACAE63RA&s=10");
            }
        }

        public void omitirColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            
            

        }
        private void cargar()
        {
            lista = new List<Articulo>();
            ArticuloDatos datos = new ArticuloDatos();
            lista = datos.listaArticulos();
            dgvArticulos.DataSource = lista;
            omitirColumnas();
            mostrarImagen(lista[0].imagen);
        }

        public void Inicio_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Marca");


        }

        public void cargarDetalle(Articulo aux)
        {
            lblNombreDetalle.Text = "Nombre: "+ aux.nombre;
            lblPrecioDetalle.Text = "Precio: $" + aux.precio.ToString();
            lblDescripDetalle.Text = "Descripcion: " + aux.descripcion;
            lblMarcaDetalle.Text = "Marca: " + aux.marca.descripcion;
            lblCategoriaDetalle.Text = "Categoria: " + aux.categoria.descripcion;
            lblCodigoDetalle.Text = "Codigo: " + aux.codigo;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            mostrarImagen(seleccionado.imagen);
            cargarDetalle(seleccionado);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo aux =(Articulo) dgvArticulos.CurrentRow.DataBoundItem;
            AccesoDatos datos = new AccesoDatos();
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el articulo seleccionado?", "ALERTA",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (resultado== DialogResult.Yes)
            {
                datos.EliminarElemento(aux);
                cargar();
            }
            
              
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltroRapido.Text;
            List<Articulo> filtrada = new List<Articulo>();
            if (filtro=="")
            {
                filtrada=lista;
            }
            else
            {
                filtrada = lista.FindAll(x => x.nombre.ToLower().Contains(filtro.ToLower()));
            }
            dgvArticulos.DataSource = filtrada;
            omitirColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion== "Marca")
            {
                MarcaDatos marca = new MarcaDatos();
                
                cboCriterio.DataSource = marca.listaMarcas();
                
            }
            else
            {
                CategoriaDatos categoria = new CategoriaDatos();
                
                cboCriterio.DataSource = categoria.listaCategorias();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloDatos articulo = new ArticuloDatos();
            List<Articulo> lista = new List<Articulo>();
            lista = articulo.listaArticulos();
            string filtrarPor = cboCampo.SelectedItem.ToString();
            string tipo = cboCriterio.SelectedItem.ToString();
            AccesoDatos datos = new AccesoDatos();
            dgvArticulos.DataSource = datos.Filtrar(lista,filtrarPor, tipo);
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
