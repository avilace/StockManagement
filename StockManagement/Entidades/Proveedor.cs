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
    class Proveedor
    {
        int id { get; set; }
        String cifnif { get; set; }
        String nombre { get; set; }
        String descripcion { get; set; }
        String codigoPostal { get; set; }
        String poblacion { get; set; }
        String direccion { get; set; }
        String tlf { get; set; }

        public Proveedor() { }

        ConexionBD con = new ConexionBD();

        /*Metodo que añade un elemento a la tabla proveedor
         1- Abre la conexion
         2- Ejecutamos una consulta que es un insert.
         3- Cierra la conexion */

        public void addProveedor(String cifnif, String nombre, String cp, String poblacion, String direccion, String tlf)
        {
            if (string.IsNullOrWhiteSpace(cifnif) | string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El campo CifNif o nombre estan vacios");
            }
            else
            {
                try
                {
                    con.abrir();
                    String consulta = "Insert into Proveedor values ('" + cifnif + "' , '" + nombre + "' , '" + cp + "' , '" + poblacion + "' , '" + direccion + "' , '" + tlf + " ')" ;
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El Proveedor: " + nombre + " se ha añadido correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la Consulta"+ ex);
                }
                con.cerrar();               
            }
        
        }

        /*Metodo que elimina un elemento a la tabla proveedor
         1- Abre la conexion
         2- Ejecutamos una consulta que es un delete.
         3- Cierra la conexion */

        public void delProveedor(String nombre)
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
                    String consulta = "Delete from Proveedor where nombre LIKE '" + nombre + "'";
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El Proveedor: " + nombre + " se ha eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la Consulta" + ex);
                }
                con.cerrar();
                
            }
        }

        /*Metodo que modifica un elemento a la tabla proveedor
         1- Abre la conexion
         2- Ejecutamos una consulta que es un update.
         3- Cierra la conexion */
        public void modProveedor(int id, String cifnif, String nombre, String cp , String poblacion, String direccion, String tlf ) {

            try
            {
                con.abrir();
                String identificador = id.ToString();
                String consulta = "Update Proveedor SET cifnif='" + cifnif + "', nombre='" + nombre + "', codigopostal='" + cp + "',poblacion='" + poblacion + "',direccion='" + direccion + "',tlf='" + tlf + "' WHERE idproveedor =" + identificador;
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                comando.ExecuteNonQuery();
                MessageBox.Show("El Proveedor: " + nombre + "se ha modificado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta" + ex);
            }
            con.cerrar();
            
        
        }

        /*Metodo que carga los combobox con el nombre de proveedor
         1- Abre la conexion
         2- Ejecutamos una consulta 
         3- Cierra la conexion */

        public void cargarComboBox(ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                String consulta = "Select nombre from Proveedor order by nombre";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al ejecutar consulta" + Ex);
            }
        }

        /*Metodo que carga todos los datos de la tabla proveedors en un DGV
         1- Abre la conexion
         2- Ejecutamos una el procedure
         3- Cierra la conexion */

        public DataTable mostrarProveedores()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARPROVEEDORES", con.conectarbd);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /*Metodo que devuelve el id de un proveedor a partir de su nombre
         1- Abre la conexion 
         2- Ejecutamos una la consulta
         3- Cierra la conexion */

        public String getIdFromName(String prov)
        {
            String id = "";
            try
            {

                String consulta = "Select idproveedor from proveedor where nombre LIKE '" + prov + "'";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["idproveedor"].ToString();
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
            }
            con.cerrar();
            return id;
        }

        /*Metodo que devuelve el nombre de un proveedor a partir de su id
         1- Abre la conexion 
         2- Ejecutamos una la consulta
         3- Cierra la conexion */

        public String getNameFromId(String id)
        {
            String proveedor = "";
            try
            {
                String consulta = "Select nombre from PRoveedor where idproveedor =" + id;
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    proveedor = dr["nombre"].ToString();
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al sacar el nombre" + Ex);
            }
            con.cerrar();
            return proveedor;
        }

    }
}
