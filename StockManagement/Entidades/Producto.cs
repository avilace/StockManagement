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
    /*Clase per a l'entitat producte*/
    class Producto
    {
        int id { get; set; }
        String nombre { get; set; }
        String descripcion { get; set; }
        int idcategoria { get; set; }
        int cantidad { get; set; }
        int cantidadminima { get; set; }
        int idproveedor { get; set; }
        /*Constructor per fer referencia a els altres metodes en altres entitats.*/
        public Producto()
        {
        }

        ConexionBD con = new ConexionBD();

        /*Metode per afegir un nou registre a la taula */
        /*Metodo para añadir un nuevo producto a la tabla producto.
         1- Abre la conexion
         2- Carga un nuevo producto a la tabla producto
         3- Cierra la conexion */

        public void addProducto(String nombre, String descripcion, String idcategoria, String cantidad, String cantidadminima, String idproveedor)
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
                    String consulta = "Insert into Elemento values ('" + nombre + "','" + descripcion + "'," + idcategoria + "," + cantidad +","+ cantidadminima +"," + idproveedor + ")";
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la Consulta" + ex);
                }
                con.cerrar();
                MessageBox.Show("El Producto: " + nombre + " se ha añadido correctamente");
            }
        }

        /*Metodo para eliminar un  producto a la tabla producto.
         1- Abre la conexion
         2- Elimina un elemento de la tabla producto
         3- Cierra la conexion */

        public void delProducto(String nombre)
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
                    String consulta = "Delete from Elemento where nombre LIKE '" + nombre + "'";
                    SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la Consulta" + ex);
                }
                con.cerrar();
                MessageBox.Show("El Producto: " + nombre + " se ha eliminado correctamente");
            }
        }

        /*Metodo para modificar un  producto a la tabla producto.
         1- Abre la conexion
         2- Carga los datos al DGV
         3- Cierra la conexion */

        public void modProducto(String id, String nombre, String desc, String idcat, String idprov, String cmin)
        {
            try {
                con.abrir();
                String consulta = "Update Elemento SET nombre='"+nombre +"', descripcion= '"+desc+"', idcategoria="+idcat+",cantidadminima="+cmin+",idproveedor="+idprov+" where idelemento="+id;
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                comando.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar la Consulta" + ex);
            }
            con.cerrar();
            MessageBox.Show("El Producto: " + nombre + " se ha modificado correctamente");
        }

        /*Metodo para sumar una cantidad al campo cantidad a un producto especifico
         1- Abre la conexion
         2- Carga los datos a variables enteras
         3- Realizamos los calculos necesarios y los devolvemos a la base de datos
         4- Cierra la conexion */

        public void addCantidad(String id, String cantidad)
        {
            try
            {
                con.abrir();
                String consulta = "Select cantidad from elemento where idelemento=" + id;
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    int cantidadactual = int.Parse(dr["cantidad"].ToString());
                    int cantidadaux = int.Parse(cantidad) + cantidadactual;
                    String cantidadnueva = cantidadaux.ToString();
                    consulta = "Update Elemento SET cantidad="+ cantidadnueva + "where idelemento="+ id;
                }
                dr.Close();
                SqlCommand cm = new SqlCommand(consulta, con.conectarbd);
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la Consulta" + ex);
            }
            con.cerrar();
            MessageBox.Show("El Producto: " + nombre + " se ha modificado correctamente");
        }

        /*Metodo para restar una cantidad al campo cantidad a un producto especifico
         1- Abre la conexion
         2- Carga los datos a variables enteras
         3- Realizamos los calculos necesarios y los devolvemos a la base de datos
         4- Cierra la conexion */

        public void delCantidad(String id, String cantidad)
        {
            try
            {
                con.abrir();
                String consulta = "Select cantidad from elemento where idelemento=" + id;
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    int cantidadactual = int.Parse(dr["cantidad"].ToString());
                    int cantidadaux = cantidadactual - int.Parse(cantidad);
                    String cantidadnueva = cantidadaux.ToString();
                    consulta = "Update Elemento SET cantidad=" + cantidadnueva + "where idelemento=" + id;
                }
                dr.Close();
                SqlCommand cm = new SqlCommand(consulta, con.conectarbd);
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la Consulta" + ex);
            }
            con.cerrar();
            MessageBox.Show("El Producto: " + nombre + " se ha modificado correctamente");
        }

        /*Metodo para cargar los nombres de los productos a un combobox
         1- Abre la conexion
         2- Selecionamos los nombres y los añadimos al combobox
         3- Cierra la conexion */

        public void cargarComboBox(ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                String consulta = "Select nombre from Elemento order by nombre";
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

        /*Metodo para cargar los nombres de los productos a un combobox pero esta vez filtrado por el id de proveedor
         1- Abre la conexion
         2- Selecionamos los nombres y los añadimos al combobox
         3- Cierra la conexion */

        public void cargarComboBoxFilterProv(ComboBox cb, String idprov)
        {
            try
            {
                cb.Items.Clear();
                String consulta = "Select nombre from elemento where idproveedor=" + idprov + " order by nombre";
                con.abrir();
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            con.cerrar();
        }

        /*Metodo para mostrar todos los campos de la tabla productos
         1- Abre la conexion
         2- Ejecutamos el procedure para mostrar todos los campos de la tabla productos
         3- Cierra la conexion */
        public DataTable mostrarProductos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARPRODUCTOS", con.conectarbd);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /*Metodo para mostrar campos de diferentes tablas
         1- Abre la conexion
         2- Ejecutamos una consulta que se filtra por proveedor
         3- Cierra la conexion */

        public DataTable mostrarProductosFilterProv(String prov)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Elemento, Proveedor where Elemento.idproveedor=Proveedor.idproveedor and Proveedor.nombre like '"+prov+"'", con.conectarbd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /*Metodo para mostrar campos de diferentes tablas
         1- Abre la conexion
         2- Ejecutamos una consulta que se filtra por categoria
         3- Cierra la conexion */

        public DataTable mostrarProductosFilterCat(String cat)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Elemento, Categoria where Elemento.idcategoria=Categoria.idcategoria and Categoria.nombre like '" + cat + "'", con.conectarbd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /*Metodo que devuelve el id de un producto
         1- Abre la conexion
         2- Ejecutamos una consulta que se filtra por el nombre 
         3- Cierra la conexion */
        public String getIdFromName(String name)
        {
            String id = "";
            try
            {
                con.abrir();
                String consulta = "Select idelemento from elemento where nombre like '" + name + "'";
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["idelemento"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID del Producto" + ex);
            }
            con.cerrar();
            return id;
        }

        /*Metodo que devuelve el la descripcion de un producto
         1- Abre la conexion
         2- Ejecutamos una consulta que se filtra por el nombre 
         3- Cierra la conexion */

        public String getDescfromName(String name)
        {
            String desc = "";
            try
            {
                con.abrir();
                String consulta = "Select descripcion from elemento where nombre like '" + name + "'";
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    desc = dr["descripcion"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener desc del Producto" + ex);
            }
            con.cerrar();
            return desc;
        }

        /*Metodo que devuelve el idcat de un producto
         1- Abre la conexion
         2- Ejecutamos una consulta que se filtra por el nombre 
         3- Cierra la conexion */

        public String getIdCatfromName(String name)
        {
            String idcat = "";
            try
            {
                con.abrir();
                String consulta = "Select idcategoria from elemento where nombre like '" + name + "'";
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    idcat = dr["idcategoria"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener desc del Producto" + ex);
            }
            con.cerrar();
            return idcat;
        }

        /*Metodo que devuelve el cantidad de un producto
         1- Abre la conexion
         2- Ejecutamos una consulta que se filtra por el nombre 
         3- Cierra la conexion */

        public String getCantActualFromName(String name)
        {
            String cantidad = "";
            try {
                con.abrir();
                String consulta = "Select cantidad from elemento where nombre like '" + name + "'";
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    cantidad = dr["cantidad"].ToString();
                }
                dr.Close();
            }
            catch(Exception Ex)
            {
            }
            con.cerrar();
            return cantidad;
        }

        /*Metodo que devuelve el cantidad minima de un producto
         1- Abre la conexion
         2- Ejecutamos una consulta que se filtra por el nombre 
         3- Cierra la conexion */
        public String getCantMinActualFromName(String name)
        {
            String cantidad = "";
            try
            {
                con.abrir();
                String consulta = "Select cantidadminima from elemento where nombre like '" + name + "'";
                SqlCommand comando = new SqlCommand(consulta, con.conectarbd);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    cantidad = dr["cantidadminima"].ToString();
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
            }
            con.cerrar();
            return cantidad;
        }
    }
}
