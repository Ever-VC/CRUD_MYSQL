using Persistencia.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Persistencia.Controladores
{
    public class Empleado_Controlador : Conexion_db
    {
        //Aplicando patrón de diseño Singleton
        private static Empleado_Controlador _instancia = null;

        public static Empleado_Controlador Intancia => _instancia ??= new();

        public List<Empleado> GetListaEmpleados()
        {
            List<Empleado> lstEmpleados = new();

            //El bloque using permite ejecutar un bloque de código y al terminer la ejecución, cierra todas las instancias automáticamente.
            using MySqlConnection conn = GetConnection();//Almacena en un objeto MySqlConnection la conexión que se retorna de la clase Conexion_db
            string consulta = "SELECT * FROM `tbl_empleados`";//Almacena la consulta a ejecutar

            //Crea un MySqlCommand y se le indica la consulta a ejecutar y la conexión a la db en que se va a ejecutar
            MySqlCommand cmd = new(consulta, conn)
            {
                CommandType = System.Data.CommandType.Text //Indica el tipo de comando
            };
            using MySqlDataReader datReader = cmd.ExecuteReader();//Almacena en un MySqlDataReader todos los daros que se retornan al ejecutar el comando
            
            while (datReader.Read())//Mientras hayan registros que se puedan leer se ejecutará el while
            {
                //Agrega a la lista un nuevo empleado, al cual se le asignan directamente los valores de los atributos
                lstEmpleados.Add(new Empleado()
                {
                    //Busca en un campo específico de la tabla y retorna su valor y se asigna al atributo respectivo
                    Id = int.Parse(datReader["id_empleado"].ToString()),
                    Nombre = datReader["nombre_empleado"].ToString(),
                    Calle = datReader["calle_empleado"].ToString(),
                    Ciudad = datReader["ciudad_empleado"].ToString()
                });
            }

            return lstEmpleados;//Retorna la lista de empleados
        }
    }
}
