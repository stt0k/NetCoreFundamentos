namespace NetCoreFundamentos
{
    partial class Form05Char
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
            btnRecorrer = new Button();
            label1 = new Label();
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            label2 = new Label();
            txtPuntuacion = new TextBox();
            label3 = new Label();
            txtSimbolos = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnRecorrer
            // 
            btnRecorrer.Location = new Point(251, 380);
            btnRecorrer.Name = "btnRecorrer";
            btnRecorrer.Size = new Size(168, 42);
            btnRecorrer.TabIndex = 0;
            btnRecorrer.Text = "Run ASCII";
            btnRecorrer.UseVisualStyleBackColor = true;
            btnRecorrer.Click += btnRecorrer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 1;
            label1.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(27, 59);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(282, 108);
            txtLetras.TabIndex = 2;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(348, 59);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(282, 108);
            txtNumeros.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 26);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 3;
            label2.Text = "Números";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(348, 224);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(282, 108);
            txtPuntuacion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 191);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 5;
            label3.Text = "Puntuación";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(27, 224);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(282, 108);
            txtSimbolos.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 191);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 7;
            label4.Text = "Símbolos";
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 481);
            Controls.Add(txtSimbolos);
            Controls.Add(label4);
            Controls.Add(txtPuntuacion);
            Controls.Add(label3);
            Controls.Add(txtNumeros);
            Controls.Add(label2);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Controls.Add(btnRecorrer);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRecorrer;
        private Label label1;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label label2;
        private TextBox txtPuntuacion;
        private Label label3;
        private TextBox txtSimbolos;
        private Label label4;
    }
}