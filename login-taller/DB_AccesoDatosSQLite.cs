using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_taller
{
    public class DB_AccesoDatosSQLite
    {
        public SQLiteConnection Conexion;
        public SQLiteCommand Comando;
        public SQLiteDataAdapter DB;
        public DataSet DS = new DataSet();
        public DataTable DT = new DataTable();

        private void conectar()
        {
            Conexion = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }

        private void ejecutarQuery(string unTexto)
        {
            conectar();
            Conexion.Open();
            Comando = Conexion.CreateCommand();
            Comando.CommandText = unTexto;
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
        public static List<Cliente> cargarClientes()
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var salida = cnn.Query<Cliente>("select * from Cliente", new DynamicParameters());
                return salida.ToList();
            }
        }

        public static void guardarClientes(Cliente unCliente)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute("INSERT INTO Cliente (Nombre, Apellido, DNI, Domicilio, Telefono)" +
                    " VALUES (@Nombre, @Apellido, @DNI, @Domicilio, @Telefono)", unCliente);
            }

        }

        private static string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
