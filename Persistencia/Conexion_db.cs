using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class Conexion_db
    {
        private readonly string _url;//Almacenará la ruta a la db

        public Conexion_db()
        {
            _url = "Data Source=localhost;port=3306;uid=root;pwd='';database=db_trabajos";//Asigna la ruta de la db
        }

        protected MySqlConnection GetConnection()
        {
            MySqlConnection conn;//Crea un objeto de conexión a la db
            conn = new MySqlConnection( _url );//Le asigna la ruta de la db

            try
            {
                conn.Open();//Abre la conexión a la db
            }
            catch
            {
                //Si existe un problema al abrir la conexión, muestra el mensaje de error.
                MessageBox.Show("Parece que ocurrió un error al conectarnos a la base de datos.", "Error 410", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
    }
}