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
    class Entrada
    {

        ConexionBD con = new ConexionBD();
        Producto prod = new Producto();

        public Entrada() { }

        /*Metodo para cargar una nueva entrada
         1- Abre la conexion
         2- Pasa los parametros a la consulta
         3- Cierra la conexion */

        public void addEntrada(String id, String idelemento, String cantidad, String idprov)
        {
            try {
                String consulta = "Insert into Entrada(identrada,idelemento,cantidad,idproveedor) values("+id+","+idelemento+","+cantidad+","+idprov+")";
                con.abrir();
                SqlCommand com = new SqlCommand(consulta, con.conectarbd);
                com.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("No se ha añadido la entrada correctamente"+ ex);
            }
            con.cerrar();
            prod.addCantidad(idelemento, cantidad);
        }

        /*Metodo para cargar las entradas a partir de un producto.
         1- Abre la conexion
         2- Carga los datos al DGV
         3- Cierra la conexion */

        public DataTable mostrarEntradaFilterProd(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String consulta = "Select Entrada.identrada, Entrada.idelemento as Codigo, Elemento.nombre as Nombre, Entrada.cantidad as Cantidad, Entrada.data as Fecha  from Entrada, Elemento where  Entrada.idelemento = Elemento.idelemento and Elemento.nombre like '" + name + "'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, con.conectarbd);
                da.Fill(dt);
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error con la consulta" + ex);
            }
            con.cerrar();
            return dt;
        }

        /*Metodo para cargar las entradas a partir de una categoria.
         1- Abre la conexion
         2- Carga los datos al DGV
         3- Cierra la conexion */

        public DataTable mostrarEntradaFilterCat(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String consulta = "Select Entrada.identrada, Entrada.idelemento as Codigo, Elemento.nombre as Nombre, Entrada.cantidad as Cantidad, Entrada.data as Fecha from Entrada, Elemento , Categoria where  Entrada.idelemento = Elemento.idelemento and Categoria.idcategoria = Elemento.idcategoria and Categoria.nombre like '"+name+"'";
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

        /*Metodo para cargar las entradas a partir de un proveedor.
         1- Abre la conexion
         2- Carga los datos al DGV
         3- Cierra la conexion */

        public DataTable mostrarEntradaFilterProv(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String consulta = "Select Entrada.identrada, Entrada.idelemento as Codigo, Elemento.nombre as Nombre, Entrada.cantidad as Cantidad, Entrada.data as Fecha from Entrada, Elemento, Proveedor where Entrada.idelemento = Elemento.idelemento and Proveedor.idproveedor = Entrada.idproveedor and Proveedor.nombre like '"+name+"'";
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

        /*Metodo para cargar las entradas a partir de un id de entrada.
         1- Abre la conexion
         2- Carga los datos al DGV
         3- Cierra la conexion */
        public DataTable mostrarEntradaFilterIdEntrada(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String consulta = "Select Entrada.identrada, Entrada.idelemento as Codigo, Elemento.nombre as Nombre, Entrada.cantidad as Cantidad, Entrada.data as Fecha from Entrada, Elemento where Entrada.idelemento = Elemento.idelemento and Entrada.identrada ="+name;
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

        /*Metodo para cargar los combobox a partir de los id de entrada.
         1- Abre la conexion
         2- Carga los datos al DGV
         3- Cierra la conexion */

        public void cargarComboBox(ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                String consulta = "Select distinct identrada from Entrada";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["identrada"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al ejecutar consulta" + Ex);
            }
        }
    }
}
