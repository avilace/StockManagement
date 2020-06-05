using StockManagement.Clases;
using StockManagement.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Gestion
{
    public partial class StockActual : Form
    {
        public StockActual()
        {
            InitializeComponent();
        }
        Categoria categoria = new Categoria();
        Proveedor proveedor = new Proveedor();
        Producto producto = new Producto();

        private void StockActual_Load(object sender, EventArgs e)
        {
            categoria.cargarComboBox(CxCatCB);
            proveedor.cargarComboBox(CxProvCB);
        }

        private void CxProvBT_Click(object sender, EventArgs e)
        {
            DGVCxP.DataSource = producto.mostrarProductosFilterProv(CxProvCB.Text);
        }

        private void CxCatBT_Click(object sender, EventArgs e)
        {
            DGVCxCat.DataSource = producto.mostrarProductosFilterCat(CxCatCB.Text);
        }
    }
}
