namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lblRaton = new Label();
            label2 = new Label();
            txtNumeros = new TextBox();
            label3 = new Label();
            txtLetras = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(26, 68);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(161, 35);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(26, 150);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(126, 30);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(26, 208);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(128, 78);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(26, 316);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(128, 86);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(26, 429);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(128, 82);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.FromArgb(128, 255, 128);
            lblRaton.Location = new Point(257, 208);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(473, 303);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "Raton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 26);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 7;
            label2.Text = "Solo números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(403, 26);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(211, 35);
            txtNumeros.TabIndex = 8;
            txtNumeros.KeyPress += txtNumeros_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 90);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 9;
            label3.Text = "Solo letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(403, 87);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(211, 35);
            txtLetras.TabIndex = 10;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 552);
            Controls.Add(txtLetras);
            Controls.Add(label3);
            Controls.Add(txtNumeros);
            Controls.Add(label2);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lblRaton;
        private Label label2;
        private TextBox txtNumeros;
        private Label label3;
        private TextBox txtLetras;
    }
}