namespace Presentación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados frmEmpleados = new();//Crea un objeto del formulario de empleados
            frmEmpleados.ShowDialog();//Muestra el formulario de empleados
        }
    }
}