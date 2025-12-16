namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            label3 = new Label();
            txtSumaPares = new TextBox();
            label4 = new Label();
            txtSumaImpares = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(25, 64);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(228, 274);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(366, 43);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(128, 53);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar números";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(366, 127);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(128, 55);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 206);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 4;
            label2.Text = "Suma:";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(366, 239);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(148, 35);
            txtSuma.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 288);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 6;
            label3.Text = "Pares:";
            // 
            // txtSumaPares
            // 
            txtSumaPares.Location = new Point(366, 321);
            txtSumaPares.Name = "txtSumaPares";
            txtSumaPares.Size = new Size(148, 35);
            txtSumaPares.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 369);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 8;
            label4.Text = "Impares:";
            // 
            // txtSumaImpares
            // 
            txtSumaImpares.Location = new Point(366, 402);
            txtSumaImpares.Name = "txtSumaImpares";
            txtSumaImpares.Size = new Size(148, 35);
            txtSumaImpares.TabIndex = 9;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 467);
            Controls.Add(txtSumaImpares);
            Controls.Add(label4);
            Controls.Add(txtSumaPares);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrar;
        private Label label2;
        private TextBox txtSuma;
        private Label label3;
        private TextBox txtSumaPares;
        private Label label4;
        private TextBox txtSumaImpares;
    }
}