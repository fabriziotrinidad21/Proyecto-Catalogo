using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatalogo
{
    public partial class vtnDatos : Form
    {
        private Articulo articulo;

        public vtnDatos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modicar Articulo";
            txtCodigo.Text = articulo.codigo;
            txtDescripcion.Text = articulo.descripcion;
            txtImagen.Text = articulo.imagen;
            txtNombre.Text = articulo.nombre;
            txtPrecio.Text = articulo.precio.ToString();
            cboCategoria.SelectedItem = articulo.categoria.descripcion;
            cboMarca.SelectedItem = articulo.marca.descripcion;

        }
        public vtnDatos()
        {
            InitializeComponent();
            articulo = null;
            Text = "Cargar nuevo articulo";
        }
        public void mostrarImagen(string url)
        {
            try
            {
                pboImagen.Load(url);
            }
            catch (Exception)
            {
                pboImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBMlmZMyak30Jn6GOX4jFDAyu90OLghCqL23-lwES2yA&s=10");
            }
        }
        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
            mostrarImagen(txtImagen.Text);
            
        }

        private void vtnDatos_Load(object sender, EventArgs e)
        {
            MarcaDatos marca = new MarcaDatos();
            CategoriaDatos categoria = new CategoriaDatos();
            cboMarca.DataSource = marca.listaMarcas();
            cboCategoria.DataSource = categoria.listaCategorias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.imagen = txtImagen.Text;
                articulo.descripcion = txtDescripcion.Text;
                decimal precioAux;
                if (!decimal.TryParse(txtPrecio.Text, out precioAux))
                {
                    MessageBox.Show("El precio ingresado no es válido");
                    return;
                }
                articulo.precio = precioAux;
                articulo.categoria = (Categoria)cboCategoria.SelectedValue;
                articulo.marca = (Marca)cboMarca.SelectedValue;
                articulo.nombre = txtNombre.Text;
                articulo.codigo = txtCodigo.Text;

                if (articulo.id == 0)
                {
                    datos.insertarElemento(articulo);
                    MessageBox.Show("Agregado correctamente");
                }
                else
                {
                    datos.ModificarElemento(articulo);
                    MessageBox.Show("Modificado correctamente");
                }
                
                
                Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
