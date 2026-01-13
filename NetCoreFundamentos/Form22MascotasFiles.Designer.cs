namespace NetCoreFundamentos
{
    partial class Form22MascotasFiles
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
            btnNuevaMascota = new Button();
            btnReadFile = new Button();
            btnWriteFile = new Button();
            label3 = new Label();
            lstMascotas = new ListBox();
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
            txtNombre.Size = new Size(172, 35);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 123);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(172, 35);
            txtRaza.TabIndex = 3;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(12, 186);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(172, 53);
            btnNuevaMascota.TabIndex = 4;
            btnNuevaMascota.Text = "Nueva mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(12, 245);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(172, 50);
            btnReadFile.TabIndex = 5;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(12, 301);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(172, 49);
            btnWriteFile.TabIndex = 6;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 9);
            label3.Name = "label3";
            label3.Size = new Size(101, 30);
            label3.TabIndex = 7;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(221, 42);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(271, 304);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 378);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Button btnNuevaMascota;
        private Button btnReadFile;
        private Button btnWriteFile;
        private Label label3;
        private ListBox lstMascotas;
    }
}