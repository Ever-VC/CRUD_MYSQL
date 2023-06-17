using Persistencia.Controladores;
using Persistencia.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class ModeloEmpleado
    {
        public List<Empleado> GetListaEmpleados()
        {
            //Retorna la lista de "Retorno" de la funcion "GetListaEmpleados" en la clase "Empleado_Controlador"
            return Empleado_Controlador.Intancia.GetListaEmpleados();
        }
    }
}
