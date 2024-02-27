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
            conexion=new SqlConnection("server=.\\SQLEXPRESS;database=CATALOGO_DB;integrated security=true");
            comando = new SqlCommand();
        }

        public void establecerConsulta(string consulta)
        {
            comando.CommandType=System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void establecerlectura()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
        }

        public void cerrarconexion()
        {
            if (Lector != null) 
                Lector.Close();
            conexion.Close();
        }

        public void ejecutaraccion()
        {   comando.Connection = conexion;
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

        public void setearparametros(string nombre,object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }
    }
}
