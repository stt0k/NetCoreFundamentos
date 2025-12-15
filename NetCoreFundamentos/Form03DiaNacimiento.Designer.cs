namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            label4 = new Label();
            btnMostrar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(44, 30);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 91);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 154);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(95, 31);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 35);
            txtDia.TabIndex = 3;
            txtDia.Text = "15";
            // 
            // txtMes
            // 
            txtMes.Location = new Point(95, 91);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 35);
            txtMes.TabIndex = 4;
            txtMes.Text = "12";
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(95, 151);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 35);
            txtAnyo.TabIndex = 5;
            txtAnyo.Text = "2025";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(21, 297);
            label4.Name = "label4";
            label4.Size = new Size(199, 30);
            label4.TabIndex = 6;
            label4.Text = "Dia de la semana es";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(95, 218);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(152, 43);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar día";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(216, 297);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 30);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "LUNES";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 352);
            Controls.Add(lblResultado);
            Controls.Add(btnMostrar);
            Controls.Add(label4);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
        private Label label4;
        private Button btnMostrar;
        private Label lblResultado;
    }
}