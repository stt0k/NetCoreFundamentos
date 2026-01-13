namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            btnLeerClase = new Button();
            btnGuardarClase = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 35);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 127);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(184, 35);
            txtRaza.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 216);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(89, 35);
            txtEdad.TabIndex = 5;
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(281, 27);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(163, 50);
            btnLeerClase.TabIndex = 6;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(281, 98);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(163, 52);
            btnGuardarClase.TabIndex = 7;
            btnGuardarClase.Text = "Guardar clase";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(486, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 265);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(281, 170);
            button1.Name = "button1";
            button1.Size = new Size(163, 43);
            button1.TabIndex = 9;
            button1.Text = "Examinar...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 304);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardarClase);
            Controls.Add(btnLeerClase);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Label label3;
        private TextBox txtEdad;
        private Button btnLeerClase;
        private Button btnGuardarClase;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}