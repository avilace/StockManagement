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
    class Salida
    {

        ConexionBD con = new ConexionBD();
        Producto prod = new Producto();

        public Salida() { }

        /*Metodo que añade una salida a la tabla salidas
         1- Abre la conexion 
         2- Ejecutamos una la consulta
         3- Cierra la conexion */

        public void addSalida(String id, String idelemento, String cantidad, String idcomp)
        {
            try
            {
                String consulta = "Insert into Salida(idsalida,idelemento,cantidad,idcomprador) values(" + id + "," + idelemento + "," + cantidad + "," + idcomp + ")";
                con.abrir();
                SqlCommand com = new SqlCommand(consulta, con.conectarbd);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha añadido la entrada correctamente" + ex);
            }
            con.cerrar();
            prod.delCantidad(idelemento, cantidad);
        }

        /*Metodo que muestra las salidas filtradas por producto
         1- Abre la conexion 
         2- Ejecutamos una la consulta
         3- Cierra la conexion */

        public DataTable mostrarSalidaFilterProd(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String consulta = "Select Salida.idsalida, Salida.idelemento as Codigo, Elemento.nombre as Nombre, Salida.cantidad as Cantidad, Salida.data as Fecha  from Salida, Elemento where  Salida.idelemento = Elemento.idelemento and Elemento.nombre like '" + name + "'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, con.conectarbd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con la consulta" + ex);
            }
            con.cerrar();
            return dt;
        }

        /*Metodo que muestra las salidas filtradas por categoria
         1- Abre la conexion 
         2- Ejecutamos una la consulta
         3- Cierra la conexion */

        public DataTable mostrarSalidaFilterCat(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String consulta = "Select Salida.idsalida, Salida.idelemento as Codigo, Elemento.nombre as Nombre, Salida.cantidad as Cantidad, Salida.data as Fecha from Salida, Elemento , Categoria where  Salida.idelemento = Elemento.idelemento and Categoria.idcategoria = Elemento.idcategoria and Categoria.nombre like '" + name + "'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, con.conectarbd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con la consulta" + ex);
            }
            con.cerrar();
            return dt;
        }

        /*Metodo que muestra las salidas filtradas por porveedor
         1- Abre la conexion 
         2- Ejecutamos una la consulta
         3- Cierra la conexion */
        public DataTable mostrarSalidaFilterProv(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String consulta = "Select Salida.identrada, Salida.idelemento as Codigo, Elemento.nombre as Nombre, Salida.cantidad as Cantidad, Salida.data as Fecha from Salida, Elemento, Comprador where Salida.idelemento = Elemento.idelemento and comprador.idcomprador = Salida.idcomprador and comprador.nombre like '" + name + "'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, con.conectarbd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con la consulta" + ex);
            }
            con.cerrar();
            return dt;
        }

        /*Metodo que muestra las salidas filtradas por id de salida
         1- Abre la conexion 
         2- Ejecutamos una la consulta
         3- Cierra la conexion */

        public DataTable mostrarSalidaFilterIdSalida(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String consulta = "Select Salida.identrada, Salida.idelemento as Codigo, Elemento.nombre as Nombre, Salida.cantidad as Cantidad, Salida.data as Fecha from Salida, Elemento where Salida.idelemento = Elemento.idelemento and Salida.identrada =" + name;
                SqlDataAdapter da = new SqlDataAdapter(consulta, con.conectarbd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con la consulta" + ex);
            }
            con.cerrar();
            return dt;
        }

        /*Metodo que carga los distintos de id de salida que existen en la tabla idsalida
         1- Abre la conexion 
         2- Ejecutamos una la consulta
         3- Cierra la conexion */

        public void cargarComboBox(ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                String consulta = "Select distinct idsalida from Salida";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["idsalida"].ToString());
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al ejecutar consulta" + Ex);
            }
        }

    }
}
