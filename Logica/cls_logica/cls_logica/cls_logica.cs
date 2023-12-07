using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace cls_logica
{
    public class logica
    {
        SqlConnection con = new SqlConnection(@"Data Source=230556L90168233\SQLEXPRESS02;Initial Catalog=prueba_Clientes;Integrated Security=True");

        //conexion cl = new conexion();

        #region ObtenerClientes
        public DataSet obtenerClientes()
        {
            string sql = string.Empty;
            bool res = false;
            DataSet consulta = new DataSet();
            try
            {
                sql = string.Format("EXEC obtenerClientes");
                consulta = EjecutarConsulta(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
            return consulta;
        }
        #endregion

        #region AgregarCliente
        public bool AgregarCliente(int codigo, string nombre, string calle, string colonia, string numExt, string numInt, string rfc, string codigoPostal, string fecha, string poblacion, int limite_Credito)
        {

            string sql = string.Empty;
            bool res = false;
            try
            {
                sql = string.Format("EXEC agregarCliente '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, {11}", codigo, nombre, rfc, calle, numExt, numInt, colonia, poblacion, codigoPostal, fecha, limite_Credito, 1);
                EjecutarConsulta(sql);
                res = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }
        #endregion

        #region ModificarCliente
        //Modifcar Ciente
        public bool ModificarCliente(int codigo, string nombre, string calle, string colonia, string numExt, string numInt, string rfc, string codigoPostal, string poblacion, double limite_Credito)
        {

            string sql = string.Empty;
            bool res = false;

            try
            {
                sql = string.Format("EXEC proc_modificarClientes {0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}", codigo, nombre, rfc, calle, numExt, numInt, colonia, poblacion, codigoPostal, limite_Credito);
                EjecutarConsulta(sql);
                Console.WriteLine("Se ejecuto la consula");
                res = true;

            }
            catch (Exception)
            {

                throw;
            }

            return res;
        }
        #endregion

        #region EliminarCliente
        public bool eliminarCliente(int codigo) 
        {
            string sql = string.Empty;
            bool res = false;

            try
            {
                sql = string.Format("EXEC proc_eliminarCliente {0}", codigo);
                EjecutarConsulta(sql);
                Console.WriteLine("Se ejecuto la consula");
                res = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }
        #endregion

        #region testConnection
        public SqlConnection TestConnection()
        {

            try
            {
                con.Open();
                Console.WriteLine("Conexion Creada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conection failed: \n" + ex.Message);
            }
            return con;
        }
        #endregion

        #region ejecutarConsulta
        public DataSet EjecutarConsulta(string consulta)
        {
            DataSet dts = new DataSet();
            try
            {
                SqlDataAdapter datos;

                SqlCommand respuesta = new SqlCommand();
                con = TestConnection();


                respuesta = new SqlCommand(consulta, con);
                respuesta.CommandType = CommandType.Text;
                respuesta.CommandTimeout = 0;

                datos = new SqlDataAdapter(respuesta);
                datos.Fill(dts);

                con.Close();

                return dts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region UltimoCodigoRegistro
        public DataSet ultimoCodigo()
        {
            string sql = string.Empty;
            bool res = false;
            DataSet consulta = new DataSet();
            try
            {
                sql = string.Format("SELECT TOP 1 * FROM Clientes ORDER BY codigo DESC");
                consulta = EjecutarConsulta(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
            return consulta;
        }
        #endregion

        #region buscarCliente
        public DataSet BuscarCliente(int codigo)
        {
            DataSet consulta = new DataSet();
            string sql = string.Empty;
            bool res = false;

            try
            {
                sql = string.Format("SELECT * FROM Clientes WHERE codigo = {0}", codigo);
                consulta = EjecutarConsulta(sql);
                res = true;
            }
            catch (Exception e)
            {
                throw;
            }
            return consulta;
        }
        #endregion
    }
}
