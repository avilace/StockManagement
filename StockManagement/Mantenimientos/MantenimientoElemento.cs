using StockManagement.Clases;
using StockManagement.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.AddForms
{
    public partial class MantenimientoElemento : Form
    {
        public MantenimientoElemento()
        {
            InitializeComponent();
        }

        ConexionBD con = new ConexionBD();
        Categoria categoria = new Categoria();
        Producto producto = new Producto();
        Proveedor proveedor = new Proveedor();

        //Metodo de carga del mantenimiento

        private void MantenimientoElemento_Load(object sender, EventArgs e)
        {
            addDGV.DataSource = producto.mostrarProductos();
            delDGV.DataSource = producto.mostrarProductos();
            modDGV.DataSource = producto.mostrarProductos();
            categoria.cargarComboBox(catAdd);
            proveedor.cargarComboBox(provAdd);
            producto.cargarComboBox(modNombreCb);
            producto.cargarComboBox(delNombreCb);
            categoria.cargarComboBox(modCategoriaCB);
            proveedor.cargarComboBox(modProveedorCB);
        }

        //Metodo del boton de add

        private void addButton_Click(object sender, EventArgs e)
        {
            String nombre = nomAdd.Text;
            String desc = descAdd.Text;
            String cat = catAdd.Text;
            String min = minAdd.Text;
            String prov = provAdd.Text;

            String idCat = categoria.getIdFromNombre(cat);
            String idProv = proveedor.getIdFromName(prov);

            producto.addProducto(nombre,desc,idCat,"0",min,idProv);


            addDGV.DataSource = producto.mostrarProductos();
            delDGV.DataSource = producto.mostrarProductos();
            modDGV.DataSource = producto.mostrarProductos();
            categoria.cargarComboBox(modCategoriaCB);
            proveedor.cargarComboBox(modProveedorCB);
            producto.cargarComboBox(modNombreCb);
            producto.cargarComboBox(delNombreCb);

        }

        //Metodo del boton de del

        private void delButton_Click(object sender, EventArgs e)
        {
            String nombre = delNombreCb.Text;
            producto.delProducto(nombre);
            addDGV.DataSource = producto.mostrarProductos();
            delDGV.DataSource = producto.mostrarProductos();
            modDGV.DataSource = producto.mostrarProductos();
            categoria.cargarComboBox(modCategoriaCB);
            proveedor.cargarComboBox(modProveedorCB);
            producto.cargarComboBox(modNombreCb);
            producto.cargarComboBox(delNombreCb);
        }

        //Metodo del boton de carga
        private void cargaCatButton_Click(object sender, EventArgs e)
        {
            try
            {
                String aux = modNombreCb.Text;
                String consulta = "Select idelemento, nombre, descripcion,STR(idcategoria) as idcat, STR(idproveedor) as idprov, STR(cantidadminima) as cmin from Elemento where nombre like @nombre";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta,con.conectarbd);
                comando.Parameters.AddWithValue("nombre", aux);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    modId.Text = dr["idelemento"].ToString();
                    modNombre.Text = dr["nombre"].ToString();
                    descMod.Text = dr["descripcion"].ToString();
                    String cmin = dr["cmin"].ToString().Trim();
                    minMod.Text = cmin;
                    String idcat = dr["idcat"].ToString();
                    String idprov = dr["idprov"].ToString();
                    dr.Close();
                    modCategoriaCB.Text = categoria.getIdFromNombre(idcat);
                    modProveedorCB.Text = proveedor.getNameFromId(idprov);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha eliminado el Producto correctamente." + ex);
            }
            con.cerrar();
        }

        //Metodo del boton de mod
        private void ModCategoriaButton_Click(object sender, EventArgs e)
        {
            try
            {
                String id = modId.Text;
                String nom = modNombre.Text;
                String desc = descMod.Text;
                String cmin = minMod.Text;
                String idcat = categoria.getIdFromNombre(modCategoriaCB.Text);
                String idprov = proveedor.getIdFromName(modProveedorCB.Text);
                producto.modProducto(id, nom, desc, idcat, idprov, cmin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha modificado el Producto correctamente." + ex);
            }
            addDGV.DataSource = producto.mostrarProductos();
            delDGV.DataSource = producto.mostrarProductos();
            modDGV.DataSource = producto.mostrarProductos();
            categoria.cargarComboBox(modCategoriaCB);
            proveedor.cargarComboBox(modProveedorCB);
            producto.cargarComboBox(modNombreCb);
            producto.cargarComboBox(delNombreCb);
        }
    }
}
