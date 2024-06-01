using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoADatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoADatos()
        {
            try
            {
                conexion = new SqlConnection("server=.\\SQLEXPRESS;database=CATALOGO_WEB_DB;integrated security=true");
                //conexion = new SqlConnection("workstation id=CATALOGO_WEB_DB_ALECITO.mssql.somee.com;packet size=4096;user id=Alecito_SQLLogin_1;pwd=ttey8ptyla;data source=CATALOGO_WEB_DB_ALECITO.mssql.somee.com;persist security info=False;initial catalog=CATALOGO_WEB_DB_ALECITO;TrustServerCertificate=True");
                comando = new SqlCommand();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void establecerConsulta(string consulta)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void establecerlectura()
        {
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarconexion()
        {
            try
            {
                if (Lector != null)
                    Lector.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutaraccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearparametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public int ejecutarAccionScalar()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                return int.Parse(comando.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
