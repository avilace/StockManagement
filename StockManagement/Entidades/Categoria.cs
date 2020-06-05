using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Clases
{
    class Categoria
    {
        int id { get; set; }
        String nombre { get; set; }
        String descripcion { get; set; }

        public Categoria()
        {

        }

        ConexionBD con = new ConexionBD();

        /*Metodo para añadir un elemento en la tabla categoria. Pasos:
         1- Abrir Conexión.
         2- Agregamos las variables a la consulta.
         3- Efectua cambios en la Base de datos*/
        public void addCategoria(String nombre, String descripcion)
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
                    String consulta = "Insert into Categoria values ('" + nombre + "' , '" + descripcion + "' )";
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar Consulta" + ex);
                }
                con.cerrar();
                MessageBox.Show("La Categoria: " + nombre + " se ha añadido correctamente");
            }
        }

        /*Metodo para eliminar un elemento en la tabla categoria. Pasos:
         1- Abrir Conexión.
         2- Agregamos las variables a la consulta.
         3- Efectua cambios en la Base de datos*/

        public void delCategoria(String nombre)
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
                    String consulta = "Delete from Categoria Where nombre LIKE '" + nombre + "'";
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al ejecutar Consulta" + Ex);
                }
                con.cerrar();
                MessageBox.Show("La Categoria: " + nombre + " se ha eliminado correctamente");
            }


        }

        /*Metodo para modificar un elemento en la tabla categoria. Pasos:
         1- Abrir Conexión.
         2- Agregamos las variables a la consulta.
         3- Efectua cambios en la Base de datos*/

        public void modCategoria(int id,String nombre, String descripcion)
        {
                        
                try
                {
                    con.abrir();
                    String identificador = id.ToString();
                    String consulta = "Update Categoria SET nombre='" + nombre + "', descripcion='" + descripcion + "' Where idcategoria=" + identificador;
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al ejecutar Consulta" + ex);
                }
                con.cerrar();
                MessageBox.Show("La Categoria: " + nombre + "se ha modificado correctamente");
            
        }

        /*Metodo para cargar los combobox con el nombre de las categorias. Pasos:
         1- Abrir Conexión.
         2- Ejecutamos la consulta seleccionando el nombre.
         3- Añade items al combobox mientras lea categorias.*/

        public void cargarComboBox(ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                String consulta = "Select nombre from Categoria order by nombre";
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
        }

        /*Metodo para mostrar la información en Data Grid View. Pasos:
         1- Abrir Conexión.
         2- Ejecutamos la consulta en este caso un procedure de SQLSERVER.
         3- Añadira toda la información al DGV.*/

        public DataTable mostrarCategorias()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARCATEGORIAS", con.conectarbd);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /*Metodo que devuelve el id de la categoria a partir de un nombre de categoria. Pasos:
         1- Abrir Conexión.
         2- Ejecutamos la consulta.
         3- Nos devuelve el id de la categoria.*/

        public String getIdFromNombre(String nombre)
        {
            String id = "";
            try
            {

                String consulta = "Select idcategoria from categoria where nombre LIKE '" + nombre + "'";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["idcategoria"].ToString();
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se ha podido sacar el ID de la Categoria" + Ex);
            }
            con.cerrar();
            return id;
        }

        /*Metodo que devuelve el nombre de la categoria a partir de un id de categoria. Pasos:
         1- Abrir Conexión.
         2- Ejecutamos la consulta.
         3- Nos devuelve el nombre de la categoria.*/

        public String getNamefromId(String id)
        {
            String categoria = "";
            try
            {
                String consulta = "Select nombre from Categoria where idcategoria =" + id;
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    categoria = dr["nombre"].ToString();
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al sacar el nombre" + Ex);
            }
            con.cerrar();
            return categoria;
        }

    }
}
