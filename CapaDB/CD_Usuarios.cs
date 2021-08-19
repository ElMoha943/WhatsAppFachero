using System.Data;
using System.Data.SqlClient;

namespace CapaDB
{
    class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //MUESTRA TODOS LOS USUARIOS
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from usuarios;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //CREA UN USUARIO NUEVO
        public void Insertar(string nombre, string email, string imagen)
        {

            comando.Connection = conexion.AbrirConexion();
            //insert into productos values('coca','1 litro','Cocacola',100,10);
            comando.CommandText = "INSERT INTO usuarios VALUES('" + nombre + "','" + email + "','" + imagen + ")";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITA UN USUARIO
        public void Editar(string nombre, string email, string imagen, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE usuarios SET nombre= '" + nombre + "', email= '" + email + "', imagen= '" + imagen + " WHERE id = " + id + ";";
            comando.ExecuteNonQuery();
        }

        //ELIMINA UN USUARIO
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM usuarios WHERE id=" + id + ";";
            comando.ExecuteNonQuery();
        }

        //BUSCA UN USUARIO EN ESPECIFICO
        public DataTable Buscar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * from usuarios WHERE id=" + id + ";";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
