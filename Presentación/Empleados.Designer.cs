namespace Presentación
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvEmpleados = new DataGridView();
            lblTitulo = new Label();
            pnlDataGrid = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            pnlDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AllowUserToResizeColumns = false;
            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.BackgroundColor = Color.FromArgb(11, 0, 54);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 30, 46);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(11, 30, 46);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(0, 0);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(746, 359);
            dgvEmpleados.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.LightGray;
            lblTitulo.Location = new Point(286, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "LISTA DE EMPLEADOS";
            // 
            // pnlDataGrid
            // 
            pnlDataGrid.Controls.Add(dgvEmpleados);
            pnlDataGrid.Location = new Point(22, 79);
            pnlDataGrid.Name = "pnlDataGrid";
            pnlDataGrid.Size = new Size(746, 359);
            pnlDataGrid.TabIndex = 2;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 0, 54);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDataGrid);
            Controls.Add(lblTitulo);
            Name = "Empleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            pnlDataGrid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Label lblTitulo;
        private Panel pnlDataGrid;
    }
}