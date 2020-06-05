using StockManagement.AddForms;
using StockManagement.Gestion;
using StockManagement.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        // Esta clase simplemente carga los formularios de los distintos botones
        private void CateogriasMainMenu_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenimientoCategoria();
            formulario.Show();
        }

        private void ProductosMainMenu_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenimientoElemento();
            formulario.Show();
        }

        private void ProveedoresMainMenu_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenimientoProveedor();
            formulario.Show();
        }

        private void CompradoresMainMenu_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenimientoComprador();
            formulario.Show();
        }

        private void EntradaMainMenu_Click(object sender, EventArgs e)
        {
            Form formulario = new EntradaForm();
            formulario.Show();
        }

        private void SalidaMainMenu_Click(object sender, EventArgs e)
        {
            Form formulario = new SalidaForm();
            formulario.Show();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new StockActual();
            form.Show();
        }
    }
}
