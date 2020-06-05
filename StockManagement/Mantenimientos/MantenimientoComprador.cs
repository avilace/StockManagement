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
    public partial class MantenimientoComprador : Form
    {
        public MantenimientoComprador()
        {
            InitializeComponent();
        }

        ConexionBD con = new ConexionBD();
        Comprador comprador = new Comprador();

        //Metodo de carga del mantenimiento

        private void MantenimientoComprador_Load(object sender, EventArgs e)
        {
            addDGV.DataSource = comprador.mostrarCompradores();
            delDGV.DataSource = comprador.mostrarCompradores();
            modDGV.DataSource = comprador.mostrarCompradores();
            comprador.cargarComboBox(delNombreCb);
            comprador.cargarComboBox(modNombreCb);
        }

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
                comprador.addComprador(cifnif, nombre, cp, poblacion, direccion, tlf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha añadido el proveedor " + ex);
            }
            addDGV.DataSource = comprador.mostrarCompradores();
            delDGV.DataSource = comprador.mostrarCompradores();
            modDGV.DataSource = comprador.mostrarCompradores();
            delNombreCb.Items.Clear();
            modNombreCb.Items.Clear();
            comprador.cargarComboBox(delNombreCb);
            comprador.cargarComboBox(modNombreCb);
        }

        //Metodo del boton de del

        private void delButton_Click(object sender, EventArgs e)
        {
            String nombre = delNombreCb.Text;
            comprador.delComprador(nombre);
            addDGV.DataSource = comprador.mostrarCompradores();
            delDGV.DataSource = comprador.mostrarCompradores();
            modDGV.DataSource = comprador.mostrarCompradores();
            delNombreCb.Items.Clear();
            modNombreCb.Items.Clear();
            comprador.cargarComboBox(delNombreCb);
            comprador.cargarComboBox(modNombreCb);
        }

        //Metodo del boton de carga

        private void cargaCatButton_Click(object sender, EventArgs e)
        {
            try
            {
                String aux = modNombreCb.Text;
                String consulta = "Select * from Comprador where nombre like '"+aux+"'";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    modId.Text = dr["idcomprador"].ToString();
                    cifnifMod.Text = dr["cifnif"].ToString();
                    modNombre.Text = dr["nombre"].ToString();
                    cpMod.Text = dr["codigopostal"].ToString();
                    pobMod.Text = dr["poblacion"].ToString();
                    dirMod.Text = dr["direccion"].ToString();
                    tlfMod.Text = dr["tlf"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha cargado correctamente " + ex);
            }
            con.cerrar();
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
                comprador.modComprador(int.Parse(id), cifnif, nombre, cp, pob, dir, tlf);
                addDGV.DataSource = comprador.mostrarCompradores();
                delDGV.DataSource = comprador.mostrarCompradores();
                modDGV.DataSource = comprador.mostrarCompradores();
                delNombreCb.Items.Clear();
                modNombreCb.Items.Clear();
                comprador.cargarComboBox(delNombreCb);
                comprador.cargarComboBox(modNombreCb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha modificado el Proveedor correctamente" + ex);
            }
            con.cerrar();
        }
    }
}
