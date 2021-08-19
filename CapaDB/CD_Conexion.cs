using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDB
{
    public class CD_Conexion
    {
        //private SqlConnection Conexion = new SqlConnection("Server=(local);Database=base1;Uid=edgardo;Pwd=chile971;");
        private SqlConnection Conexion = new SqlConnection("Data Source=localhost;Initial Catalog=whatsapp;Integrated Security=True;Pooling=False");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
