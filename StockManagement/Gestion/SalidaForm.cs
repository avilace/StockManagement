using StockManagement.Clases;
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

namespace StockManagement.Gestion
{
    public partial class SalidaForm : Form
    {
        public SalidaForm()
        {
            InitializeComponent();
        }

        DataTable dt;
        ConexionBD con = new ConexionBD();
        Salida salida = new Salida();
        Comprador comprador = new Comprador();
        Producto producto = new Producto();
        Categoria categoria = new Categoria();

        // Metodo que carga los combobox del formulario

        private void SalidaForm_Load(object sender, EventArgs e)
        {
            comprador.cargarComboBox(addCompradorCB);
            producto.cargarComboBox(CxProdCB);
            categoria.cargarComboBox(CxCatCB);
            comprador.cargarComboBox(CxProveedorCB);
            salida.cargarComboBox(IdEntradaCB);
            producto.cargarComboBox(addProdCB);

            addDGV.DataSource = crearDTLimpia();
            this.obtenerIDSalida();
        }

        //Metodo que crear una tabla vacia con las siguientes columnas

        public DataTable crearDTLimpia()
        {
            dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Categoria");
            return dt;
        }

        //Proceso que nos devuelve el id de la siguiente entrada

        private void obtenerIDSalida()
        {
            try
            {
                con.abrir();
                String consulta = "Select idsalida from Salida order by idSalida DESC";
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    String identrada = dr["idsalida"].ToString();
                    int aux = int.Parse(identrada) + 1;
                    addCodEntrada.Text = aux.ToString();
                }
                else
                {
                    addCodEntrada.Text = "1";
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Consulta Error " + ex);
            }
            con.cerrar();
        }

        //Boton que ejecuta la creacion de un producto segun los campos que le asignamos, ademas añade una nueva entrada.

        private void addProdBT_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            row["Codigo"] = producto.getIdFromName(addProdCB.Text);
            row["Producto"] = addProdCB.Text;
            row["Descripcion"] = producto.getDescfromName(addProdCB.Text);
            row["Cantidad"] = this.textBoxCant.Text;
            row["Categoria"] = categoria.getNamefromId(producto.getIdCatfromName(addProdCB.Text));

            dt.Rows.Add(row);
            int cantidad_actual = int.Parse(LBCmax.Text);
            int cantidad_requerida = int.Parse(textBoxCant.Text);
            int cantidad_minima = int.Parse(producto.getCantMinActualFromName(addProdCB.Text));
            int cantidad_restante = cantidad_actual - cantidad_requerida;
            if (cantidad_actual>=cantidad_requerida) {
                salida.addSalida(addCodEntrada.Text, producto.getIdFromName(addProdCB.Text), this.textBoxCant.Text, comprador.getIdFromName(addCompradorCB.Text));
            }
            else
            {
                MessageBox.Show("No se puede ejecutar la compra de este producto, no hay suficientes unidades del producto: "+ addProdCB.Text);
            }

            if(cantidad_minima >= cantidad_restante)
            {
                MessageBox.Show("El producto: "+addProdCB.Text+" necesita reponerse");
            }
            salida.cargarComboBox(IdEntradaCB);
        }

        //Carga el DGV filtrado por producto


        private void CargarCxProd_Click(object sender, EventArgs e)
        {
            cxProd.DataSource = salida.mostrarSalidaFilterCat(CxProdCB.Text);
        }
        //Boton para obtener un nuevo id de entrada

        private void FinBT_Click(object sender, EventArgs e)
        {
            this.obtenerIDSalida();
            dt.Rows.Clear();
        }

        //Carga el DGV filtrado por categoria


        private void button1_Click(object sender, EventArgs e)
        {
            CxCat.DataSource = salida.mostrarSalidaFilterCat(CxProdCB.Text);
        }

        //Carga el DGV filtrado por proveedor


        private void CxProvBT_Click(object sender, EventArgs e)
        {
            CxProv.DataSource = salida.mostrarSalidaFilterProv(CxProveedorCB.Text);
        }

        //Carga el DGV filtrado por salida


        private void CxID_Click(object sender, EventArgs e)
        {
            CxIDDGV.DataSource = salida.mostrarSalidaFilterIdSalida(IdEntradaCB.Text);
        }

        //Cambia el label de cantidad maxima dependiendo dependiondo del item seleccionado en el CB


        private void addProdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBCmax.Text = producto.getCantActualFromName(addProdCB.Text);
        }
    }
}
