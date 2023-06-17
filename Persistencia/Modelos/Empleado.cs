using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelos
{
	//Modelo de la tabla empleados, con sus respectivos campos
    public class Empleado
    {
        public Empleado() { }

		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string calle;

		public string Calle
		{
			get { return calle; }
			set { calle = value; }
		}

		private string ciudad;

		public string Ciudad
		{
			get { return ciudad; }
			set { ciudad = value; }
		}

	}
}
