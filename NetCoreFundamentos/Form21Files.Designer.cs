namespace NetCoreFundamentos
{
    partial class Form21Files
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
            txtContenidoFile = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnNuevoNombre = new Button();
            btnLeerFile = new Button();
            btnWriteFile = new Button();
            label3 = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // txtContenidoFile
            // 
            txtContenidoFile.Location = new Point(12, 42);
            txtContenidoFile.Multiline = true;
            txtContenidoFile.Name = "txtContenidoFile";
            txtContenidoFile.Size = new Size(293, 188);
            txtContenidoFile.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(351, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 35);
            txtNombre.TabIndex = 3;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(351, 101);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(180, 39);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnLeerFile
            // 
            btnLeerFile.Location = new Point(351, 146);
            btnLeerFile.Name = "btnLeerFile";
            btnLeerFile.Size = new Size(180, 41);
            btnLeerFile.TabIndex = 5;
            btnLeerFile.Text = "Leer file";
            btnLeerFile.UseVisualStyleBackColor = true;
            btnLeerFile.Click += btnLeerFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(351, 193);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(180, 37);
            btnWriteFile.TabIndex = 6;
            btnWriteFile.Text = "Write file";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 9);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(571, 46);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(221, 184);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 269);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(btnWriteFile);
            Controls.Add(btnLeerFile);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtContenidoFile);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenidoFile;
        private Label label2;
        private TextBox txtNombre;
        private Button btnNuevoNombre;
        private Button btnLeerFile;
        private Button btnWriteFile;
        private Label label3;
        private ListBox lstNombres;
    }
}