namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            txtNumeros = new TextBox();
            button1 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(31, 67);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(273, 35);
            txtNumeros.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(31, 121);
            button1.Name = "button1";
            button1.Size = new Size(273, 47);
            button1.TabIndex = 2;
            button1.Text = "Sumar números";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.Blue;
            lblResultado.Location = new Point(31, 198);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(104, 30);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 278);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button button1;
        private Label lblResultado;
    }
}