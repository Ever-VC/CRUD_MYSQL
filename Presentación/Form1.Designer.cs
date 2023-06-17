namespace Presentación
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEmpleados = new Button();
            label1 = new Label();
            gpBoxBotones = new GroupBox();
            btnTrabaja = new Button();
            btnCompanias = new Button();
            gpBoxBotones.SuspendLayout();
            SuspendLayout();
            // 
            // btnEmpleados
            // 
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 3, 188);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.LightGray;
            btnEmpleados.Location = new Point(6, 22);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(194, 41);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "EMPLEADOS";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(92, 53);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 1;
            label1.Text = "MENU PRINCIPAL";
            // 
            // gpBoxBotones
            // 
            gpBoxBotones.Controls.Add(btnTrabaja);
            gpBoxBotones.Controls.Add(btnCompanias);
            gpBoxBotones.Controls.Add(btnEmpleados);
            gpBoxBotones.Location = new Point(92, 108);
            gpBoxBotones.Name = "gpBoxBotones";
            gpBoxBotones.Size = new Size(206, 171);
            gpBoxBotones.TabIndex = 2;
            gpBoxBotones.TabStop = false;
            // 
            // btnTrabaja
            // 
            btnTrabaja.Cursor = Cursors.Hand;
            btnTrabaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 3, 188);
            btnTrabaja.FlatStyle = FlatStyle.Flat;
            btnTrabaja.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrabaja.ForeColor = Color.LightGray;
            btnTrabaja.Location = new Point(6, 116);
            btnTrabaja.Name = "btnTrabaja";
            btnTrabaja.Size = new Size(194, 41);
            btnTrabaja.TabIndex = 3;
            btnTrabaja.Text = "TRABAJA";
            btnTrabaja.UseVisualStyleBackColor = true;
            // 
            // btnCompanias
            // 
            btnCompanias.Cursor = Cursors.Hand;
            btnCompanias.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 3, 188);
            btnCompanias.FlatStyle = FlatStyle.Flat;
            btnCompanias.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompanias.ForeColor = Color.LightGray;
            btnCompanias.Location = new Point(6, 69);
            btnCompanias.Name = "btnCompanias";
            btnCompanias.Size = new Size(194, 41);
            btnCompanias.TabIndex = 4;
            btnCompanias.Text = "COMPAÑIAS";
            btnCompanias.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 0, 54);
            ClientSize = new Size(398, 341);
            Controls.Add(gpBoxBotones);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            gpBoxBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpleados;
        private Label label1;
        private GroupBox gpBoxBotones;
        private Button btnTrabaja;
        private Button btnCompanias;
    }
}