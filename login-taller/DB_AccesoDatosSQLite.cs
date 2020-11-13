﻿using Dapper;
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

        public static void guardarCliente(Cliente unCliente)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute("INSERT INTO Cliente (Nombre, Apellido, DNI, Domicilio, Telefono)" +
                    " VALUES (@Nombre, @Apellido, @DNI, @Domicilio, @Telefono)", unCliente);
            }
        }

        public static void modificarCliente(Cliente unCliente)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute("UPDATE Cliente" +
                    " SET Nombre = @Nombre" +
                    ", Apellido = @Apellido" + 
                    ", DNI= @DNI" +
                    ", Domicilio= @Domicilio" +
                    ", Telefono= @Telefono" +
                    " WHERE Numero = @Numero",unCliente);
            }
        }

        public static Cliente devolverCliente(int numeroCliente)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var salida = cnn.Query<Cliente>("select * from Cliente", new DynamicParameters());
                List<Cliente> listaClientes = salida.ToList();
                return listaClientes.Where(x => x.Numero == numeroCliente).First();
            }
        }

        public static List<Proveedor> cargarProveedores()
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var salida = cnn.Query<Proveedor>("select * from Proveedor", new DynamicParameters());
                return salida.ToList();
            }
        }

        public static void guardarProveedor(Proveedor unProveedor)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute("INSERT INTO Proveedor (Numero, CUIT, RazonSocial, Telefono, Domicilio, CodigoPostal, Email)" +
                    " VALUES (@Numero, @CUIT, @RazonSocial, @Telefono, @Domicilio, @CodigoPostal, @Email)", unProveedor);
            }
        }
        public static void modificarProveedor(Proveedor unProveedor)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute("UPDATE Proveedor" +
                    " SET CUIT = @CUIT" +
                    ", RazonSocial = @RazonSocial" +
                    ", Telefono = @Telefono" +
                    ", Domicilio= @Domicilio" +
                    ", CodigoPostal = @CodigoPostal" +
                    ", Email = @Email" +
                    " WHERE Numero = @Numero", unProveedor);
            }
        }
        public static Proveedor devolverProveedor(int numeroProveedor)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var salida = cnn.Query<Proveedor>("select * from Proveedor", new DynamicParameters());
                List<Proveedor> listaProveedores = salida.ToList();
                return listaProveedores.Where(x => x.Numero == numeroProveedor).First();
            }
        }
        private static string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
