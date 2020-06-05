using StockManagement.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockManagement
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        ConexionBD con = new ConexionBD();

        // Metodo para iniciar Sesion comprueba la contraseña y el usuario en la tabla usuarios
        public void iniciarSesion(String usuario, String contrasena)
        {
            try {
                con.abrir();
                String consulta = "Select Nombre from usuarios WHERE usuario = @usuario and password = @password";
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                comando.Parameters.AddWithValue("usuario", usuario);
                comando.Parameters.AddWithValue("password", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1) {
                    this.Hide();
                    new MainMenu().Show();
                } 
                else 
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta."); 
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.cerrar();
            }
        }

        // Ejecuta el metodo iniciar sesion

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            iniciarSesion(this.textBoxUser.Text, this.maskedTextBoxPassword.Text);
        }



        private void maskedTextBoxPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
