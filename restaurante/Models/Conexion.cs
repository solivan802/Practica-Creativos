using System;
using System.Data;
using System.Data.SqlClient;

namespace restaurante.Models
{

    public class Conexion
    {
        private SqlConnection _Con;
        private string _cadenaConexion;

        public Conexion(string servidor, string usuario, string password, string db)
        {
            _cadenaConexion = $"Data source={servidor};Initial catalog={db};user={usuario};password={password};";
        }

        public SqlConnection Con { get => _Con; set => _Con = value; }

        public void Conectar ()
        {
            _Con = new SqlConnection(_cadenaConexion);
            _Con.Open();
        }
        
        public void Desconnectar()
        {
            _Con.Close();  
        }
        

    }
}
