using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Entidades
{
    class Comprador
    {
        int id { get; set; }
        String cifnif { get; set; }
        String nombre { get; set; }
        String descripcion { get; set; }
        String codigoPostal { get; set; }
        String poblacion { get; set; }
        String direccion { get; set; }
        String tlf { get; set; }

        public Comprador() {

        }
        ConexionBD con = new ConexionBD();

        /*Metodo para añadir un comprador en la tabla comprador. Pasos:
         1- Abrir Conexión.
         2- Agregamos las variables a la consulta.
         3- Efectua cambios en la Base de datos*/

        public void addComprador(String cifnif, String nombre, String cp, String poblacion, String direccion,String tlf) 
        {
            if(string.IsNullOrWhiteSpace(cifnif) | string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El campo CifNif o nombre estan vacios");
            }
            else
            {
                try
                {
                    con.abrir();
                    String consulta = "Insert into Comprador values ('" + cifnif + "','" + nombre + "','" + cp + "','" + poblacion + "','" + direccion + "','" + tlf + "')";
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El Comprador: " + nombre + " se ha añadido correctamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la Consulta" + ex);
                }
                con.cerrar();
                
            }
        }

        /*Metodo para eliminar un elemento en la tabla comprador. Pasos:
         1- Abrir Conexión.
         2- Agregamos las variables a la consulta.
         3- Efectua cambios en la Base de datos*/

        public void delComprador(String nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("La cadena nombre esta vacia, Assignele un nombre por favor");
            }
            else
            {
                try
                {
                    con.abrir();
                    String consulta = "Delete from Comprador where nombre LIKE '" + nombre + "'";
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El Comprador: " + nombre + " se ha eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la Consulta" + ex);
                }
                con.cerrar();

            }

        }

        /*Metodo para modificar un elemento en la tabla comprador. Pasos:
         1- Abrir Conexión.
         2- Agregamos las variables a la consulta.
         3- Efectua cambios en la Base de datos*/

        public void modComprador(int id, String cifnif, String nombre, String cp, String poblacion, String direccion, String tlf)
        {
            try
            {
                con.abrir();
                String identificador = id.ToString();
                String consulta = "Update Comprador SET cifnif='" + cifnif + "', nombre='" + nombre + "', codigopostal='" + cp + "',poblacion='" + poblacion + "',direccion='" + direccion + "',tlf='" + tlf + "' WHERE idcomprador =" + identificador;
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                comando.ExecuteNonQuery();
                MessageBox.Show("El Comprador: " + nombre + "se ha modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta" + ex);
            }
            con.cerrar();
        }

        /*Metodo para cargar un combobox con los nombres de compradores. Pasos:
         1- Abrir Conexión.
         2- Agregamos los nombres de compradores en el CB mientras el dataread lea los combobox.
         3- Cierra la conexion */

        public void cargarComboBox(ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                String consulta = "Select nombre from Comprador order by nombre";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al ejecutar consulta" + Ex);
            }
            con.cerrar();
        }

        /*Metodo para mostrar todos los compradores. Pasos:
        1- Abrir Conexión.
        2- Ejecuta el procedure que selecciona todos los datos de la tabla compradores.
        3- Finalmente los muestra en el DGV */

        public DataTable mostrarCompradores()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARCOMPRADORES", con.conectarbd);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
             con.cerrar();
            return dt;
        }

        /*Metodo para obtener el id de un comprador a partir de un nombre de comprador. Pasos:
        1- Abrir Conexión.
        2- Ejecuta la consulta
        3- El proceso devuelve el id del comprador */

        public String getIdFromName(String comp)
        {
            String id = "";
            try
            {

                String consulta = "Select idcomprador from comprador where nombre LIKE '" + comp + "'";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["idcomprador"].ToString();
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
            }
            con.cerrar();
            return id;
        }
    }
}
