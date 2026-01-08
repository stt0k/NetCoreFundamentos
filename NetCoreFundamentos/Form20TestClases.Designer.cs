namespace NetCoreFundamentos
{
    partial class Form20TestClases
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
            label1 = new Label();
            lstClases = new ListBox();
            btnPersona = new Button();
            btnEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(12, 66);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(635, 244);
            lstClases.TabIndex = 1;
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(12, 339);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(160, 42);
            btnPersona.TabIndex = 2;
            btnPersona.Text = "Crear Persona";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(202, 339);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(167, 42);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 442);
            Controls.Add(btnEmpleado);
            Controls.Add(btnPersona);
            Controls.Add(lstClases);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstClases;
        private Button btnPersona;
        private Button btnEmpleado;
    }
}