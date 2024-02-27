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
            conexion=new SqlConnection("server=.\\SQLEXPRESS;database=DISCOS_DB;integrated security=true");
            comando = new SqlCommand();
        }

        public void establecerconsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
            
        }

        public void establecerlectura()
        {
          comando.Connection= conexion;
          conexion.Open();
          lector = comando.ExecuteReader();   
        }

        public void cerrarconexion()
        {      
                if (lector != null)
                    lector.Close();
                conexion.Close();

        }

        public void ejecutraraccion()
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

        public void SetearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }



    }



}
