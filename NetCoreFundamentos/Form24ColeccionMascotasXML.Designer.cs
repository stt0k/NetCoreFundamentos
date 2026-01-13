namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
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
            btnGuardarClase = new Button();
            btnLeerMascotas = new Button();
            txtEdad = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnNuevaMascota = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(563, 113);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(163, 82);
            btnGuardarClase.TabIndex = 14;
            btnGuardarClase.Text = "Guardar mascotas";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(563, 51);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(163, 50);
            btnLeerMascotas.TabIndex = 13;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(10, 225);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(89, 35);
            txtEdad.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 192);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 11;
            label3.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(10, 136);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(184, 35);
            txtRaza.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(10, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 35);
            txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 15;
            label2.Text = "Raza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 18);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 16;
            label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(262, 51);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(285, 274);
            lstMascotas.TabIndex = 17;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(12, 286);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(214, 39);
            btnNuevaMascota.TabIndex = 18;
            btnNuevaMascota.Text = "Nueva mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(741, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(563, 213);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(163, 47);
            btnExaminar.TabIndex = 20;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 347);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaMascota);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnGuardarClase);
            Controls.Add(btnLeerMascotas);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarClase;
        private Button btnLeerMascotas;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnNuevaMascota;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}