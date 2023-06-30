using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace ProyectoUDI
{
    class AccesoBD
    {
        public OleDbConnection conexion;
        public OleDbCommand comando;
        public OleDbDataReader lectura;
        public DataTable tabladatos;
        string cadena_conexion;


        public OleDbDataReader p_Lectura
        {
            set
            { lectura = value; }
            get
            { return lectura; }
        }

        public string p_CadenaConexion
        {
            set
            { cadena_conexion = value; }
            get
            { return cadena_conexion; }
        }

        //--------------------------------------------------------------

        public AccesoBD()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            tabladatos = new DataTable();
            lectura = null;
            cadena_conexion = "";
        }

        public AccesoBD(string s_Conexion)
        {
            conexion = new OleDbConnection(s_Conexion);
            comando = new OleDbCommand();
            tabladatos = new DataTable();
            lectura = null;
            cadena_conexion = s_Conexion;
        }

        public void conectar()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
        }

        public void Actualizar(string consulta)
        {
            conectar();
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            desconectar();
        }

        public DataTable consultarTabla(string tabla)
        {
            DataTable tabladatos = new DataTable();
            conectar();
            comando.CommandText = "select * from " + tabla;
            tabladatos.Load(comando.ExecuteReader());
            desconectar();
            return tabladatos;
        }

        public void leerTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            lectura = comando.ExecuteReader();
        }

        public void consultarDG(string n_tabla)
        {
            conectar();
            comando.CommandText = "select * from " + n_tabla;
            lectura = comando.ExecuteReader();
            tabladatos = new DataTable();
            tabladatos.Load(lectura);
        }
    }
}
