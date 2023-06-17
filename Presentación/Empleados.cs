using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            ModeloEmpleado empleado = new();//Crea un objeto del modelo de empleados en la capa de Dominio

            dgvEmpleados.DataSource = null;//Limpia la ruta de datos del DatGridView
            dgvEmpleados.DataSource = empleado.GetListaEmpleados();//Le asigna la ruta de datos del DatGridView (La lista de empleados)
        }
    }
}
