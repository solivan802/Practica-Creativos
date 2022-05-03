using System.Data.SqlClient;

namespace restaurante.Models
{
    public class BodegaMetodos : Conexion
    {
        public BodegaMetodos(string servidor,string usuario,string password,string db) : base(servidor, usuario,password,db)
        {

        }

        public List<Bodega> listaBodega()
        {
            List<Bodega> list = new List<Bodega>();
            try
            {
                Conectar();
                string query = "select * from bodega";
                SqlCommand com = new SqlCommand(query, Con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id_producto = reader.GetInt32(0);
                    string nombre_producto = reader.GetString(1);
                    DateTime fecha_ingreso = reader.GetDateTime(2);
                    int cantidad = reader.GetInt32(3);
                    string tipo = reader.GetString(4);

                    list.Add(new Bodega(id_producto, nombre_producto, fecha_ingreso, cantidad, tipo));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Desconnectar();
            }

            return list;
        }
    }
}
