using StockManagement.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Mantenimientos
{
    public partial class MantenimientoCategoria : Form
    {
        public MantenimientoCategoria()
        {
            InitializeComponent();
        }
        ConexionBD con = new ConexionBD();
        Categoria categoria = new Categoria();
        
        //Metodo de carga del mantenimiento

        private void MantenimientoCategoria_Load(object sender, EventArgs e)
        {
            delDGV.DataSource = categoria.mostrarCategorias();
            addDGV.DataSource = categoria.mostrarCategorias();
            modDGV.DataSource = categoria.mostrarCategorias();
            categoria.cargarComboBox(delNombreCb);
            categoria.cargarComboBox(modNombreCb);
        }

        // Metodo del boton add

        private void addButton_Click(object sender, EventArgs e)
        {
            String nombre = addNombre.Text;
            String descripcion = addDesc.Text;
            categoria.addCategoria(nombre, descripcion);
            delDGV.DataSource = categoria.mostrarCategorias();
            addDGV.DataSource = categoria.mostrarCategorias();
            modDGV.DataSource = categoria.mostrarCategorias();
            delNombreCb.Items.Clear();
            modNombreCb.Items.Clear();
            categoria.cargarComboBox(delNombreCb);
            categoria.cargarComboBox(modNombreCb);
            addNombre.Clear();
            addDesc.Clear();
        }

        // Metodo del boton del

        private void delButton_Click(object sender, EventArgs e)
        {
            String nombre = delNombreCb.Text;
            categoria.delCategoria(nombre);
            delDGV.DataSource = categoria.mostrarCategorias();
            addDGV.DataSource = categoria.mostrarCategorias();
            modDGV.DataSource = categoria.mostrarCategorias();
            delNombreCb.Items.Clear();
            modNombreCb.Items.Clear();
            categoria.cargarComboBox(delNombreCb);
            categoria.cargarComboBox(modNombreCb);
        }

        //Metodo del boton mod

        private void modButton_Click(object sender, EventArgs e)
        {    
            try {

                String id = modId.Text;
                String nombre = modNombre.Text;
                String descripcion = modDesc.Text;
                categoria.modCategoria(int.Parse(id), nombre, descripcion);
                delDGV.DataSource = categoria.mostrarCategorias();
                addDGV.DataSource = categoria.mostrarCategorias();
                modDGV.DataSource = categoria.mostrarCategorias();
                delNombreCb.Items.Clear();
                modNombreCb.Items.Clear();
                categoria.cargarComboBox(delNombreCb);
                categoria.cargarComboBox(modNombreCb);
            }
            catch(Exception ex) {
                MessageBox.Show("No se ha modificado la Categoria correctamente." + ex);
            }
        }

        //Metodo del boton de carga

        private void carButton_Click(object sender, EventArgs e)
        {
            try
            {
                String aux = modNombreCb.Text;
                String consulta = "Select * from Categoria where nombre like @nombre";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                comando.Parameters.AddWithValue("nombre", aux);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    modId.Text = dr["idcategoria"].ToString();
                    modNombre.Text = dr["nombre"].ToString();
                    modDesc.Text = dr["descripcion"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha cargado la Categoria correctamente." + ex);
            }
        }
    }
}
