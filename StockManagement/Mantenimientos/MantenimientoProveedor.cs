using StockManagement.Entidades;
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
    public partial class MantenimientoProveedor : Form
    {
        
        public MantenimientoProveedor()
        {
            InitializeComponent();
        }
        ConexionBD con = new ConexionBD();
        Proveedor proveedor = new Proveedor();


        //Metodo del boton de add

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                String cifnif = cifnifAdd.Text;
                String nombre = nomAdd.Text;
                String cp = cpAdd.Text;
                String poblacion = pobAdd.Text;
                String direccion = dirAdd.Text;
                String tlf = tlfAdd.Text;
                proveedor.addProveedor(cifnif, nombre, cp, poblacion, direccion, tlf);
            }catch(Exception ex)
            {
                MessageBox.Show("No se ha añadido el proveedor " + ex);
            }
            addDGV.DataSource = proveedor.mostrarProveedores();
            delDGV.DataSource = proveedor.mostrarProveedores();
            modDGV.DataSource = proveedor.mostrarProveedores();
            delNombreCb.Items.Clear();
            modNombreCb.Items.Clear();
            proveedor.cargarComboBox(delNombreCb);
            proveedor.cargarComboBox(modNombreCb);
        }

        //Metodo de carga del mantenimiento
        private void MantenimientoProveedor_Load(object sender, EventArgs e)
        {
            addDGV.DataSource = proveedor.mostrarProveedores();
            delDGV.DataSource = proveedor.mostrarProveedores();
            modDGV.DataSource = proveedor.mostrarProveedores();
            proveedor.cargarComboBox(delNombreCb);
            proveedor.cargarComboBox(modNombreCb);
        }

        //Metodo del boton de del

        private void delButton_Click(object sender, EventArgs e)
        {
            String nombre = delNombreCb.Text;
            proveedor.delProveedor(nombre);
            addDGV.DataSource = proveedor.mostrarProveedores();
            delDGV.DataSource = proveedor.mostrarProveedores();
            modDGV.DataSource = proveedor.mostrarProveedores();
            delNombreCb.Items.Clear();
            modNombreCb.Items.Clear();
            proveedor.cargarComboBox(delNombreCb);
            proveedor.cargarComboBox(modNombreCb);
        }

        //Metodo del boton de carga

        private void cargaCatButton_Click(object sender, EventArgs e)
        {
            try
            {
                String aux = modNombreCb.Text;
                String consulta = "Select * from Proveedor where nombre like @nombre";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                comando.Parameters.AddWithValue("nombre",aux);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    modId.Text = dr["idproveedor"].ToString();
                    cifnifMod.Text = dr["cifnif"].ToString();
                    modNombre.Text = dr["nombre"].ToString();
                    cpMod.Text = dr["codigopostal"].ToString();
                    pobMod.Text = dr["poblacion"].ToString();
                    dirMod.Text = dr["direccion"].ToString();
                    tlfMod.Text = dr["tlf"].ToString();
                }
                dr.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("No se ha cargado correctamente " + ex);
            }
        }

        //Metodo del boton de mod

        private void ModCategoriaButton_Click(object sender, EventArgs e)
        {
            try
            {
                String id = modId.Text;
                String cifnif = cifnifMod.Text;
                String nombre = modNombre.Text;
                String cp = cpMod.Text;
                String pob = pobMod.Text;
                String dir = dirMod.Text;
                String tlf = tlfMod.Text;
                proveedor.modProveedor(int.Parse(id), cifnif, nombre, cp, pob, dir, tlf);
                addDGV.DataSource = proveedor.mostrarProveedores();
                delDGV.DataSource = proveedor.mostrarProveedores();
                modDGV.DataSource = proveedor.mostrarProveedores();
                delNombreCb.Items.Clear();
                modNombreCb.Items.Clear();
                proveedor.cargarComboBox(delNombreCb);
                proveedor.cargarComboBox(modNombreCb);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha modificado el Proveedor correctamente" + ex);
            }


        }
    }
}
