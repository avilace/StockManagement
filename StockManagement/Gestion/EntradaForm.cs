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
    public partial class EntradaForm : Form
    {
        DataTable dt;
        ConexionBD con = new ConexionBD();
        Entrada entrada = new Entrada();
        Proveedor proveedor = new Proveedor();
        Producto producto = new Producto();
        Categoria categoria = new Categoria();


        public EntradaForm()
        {
            InitializeComponent();
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

        //Metodo creado para modificar el combobox de productos cada vez que cambiamos el proveedor

        private void addProveedorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idprov = proveedor.getIdFromName(addProveedorCB.Text);
            producto.cargarComboBoxFilterProv(addProdCB,idprov);
            addProdCB.SelectedIndex = 0;
        }

        //Metodo que se carga al inicio del formulario que carga los combobox y la talba de entrada
        private void EntradaForm_Load(object sender, EventArgs e)
        {
            proveedor.cargarComboBox(addProveedorCB);
            producto.cargarComboBox(CxProdCB);
            categoria.cargarComboBox(CxCatCB);
            proveedor.cargarComboBox(CxProveedorCB);
            entrada.cargarComboBox(IdEntradaCB);

            addDGV.DataSource = crearDTLimpia();
            this.obtenerIDEntrada();
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

          entrada.addEntrada(addCodEntrada.Text, producto.getIdFromName(addProdCB.Text), this.textBoxCant.Text, proveedor.getIdFromName(addProveedorCB.Text));
          entrada.cargarComboBox(IdEntradaCB);
        }

        //Proceso que nos devuelve el id de la siguiente entrada

        private void obtenerIDEntrada()
        {
            try {
                con.abrir();
                String consulta = "Select identrada from entrada order by identrada DESC";
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read()) {
                    String identrada = dr["identrada"].ToString();
                    int aux = int.Parse(identrada) + 1;
                    addCodEntrada.Text = aux.ToString();
                } else
                {
                    addCodEntrada.Text = "1";
                }
                dr.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Consulta Error "+ ex);
            }
            con.cerrar();
        }
        //Boton para obtener un nuevo id de entrada
        private void FinBT_Click(object sender, EventArgs e)
        {
            this.obtenerIDEntrada();
            dt.Rows.Clear();
        }

        //Carga el DGV filtrado por producto
        private void CargarCxProd_Click(object sender, EventArgs e)
        {
            cxProd.DataSource = entrada.mostrarEntradaFilterProd(CxProdCB.Text); 
        }

        //Carga el DGV filtrado por proveedor

        private void CxProvBT_Click(object sender, EventArgs e)
        {
            CxProv.DataSource = entrada.mostrarEntradaFilterProv(CxProveedorCB.Text);
        }

        //Carga el DGV filtrado por id entrada

        private void CxID_Click(object sender, EventArgs e)
        {
            CxIDDGV.DataSource = entrada.mostrarEntradaFilterIdEntrada(IdEntradaCB.Text);
        }

        //Carga el DGV filtrado por categoria

        private void button1_Click(object sender, EventArgs e)
        {
            CxCat.DataSource = entrada.mostrarEntradaFilterCat(CxCatCB.Text);
        }
    }
}
