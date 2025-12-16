namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            btnNuevo = new Button();
            txtElemento = new TextBox();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lstTienda = new ListBox();
            lstAlmacen = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 1;
            label2.Text = "Tienda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 29);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 2;
            label3.Text = "Almacén";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(22, 132);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 43);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(22, 62);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(124, 35);
            txtElemento.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(22, 181);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 43);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(22, 230);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(124, 43);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(169, 62);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(189, 214);
            lstTienda.TabIndex = 7;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(475, 62);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(196, 214);
            lstAlmacen.TabIndex = 8;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeleccion.Location = new Point(377, 93);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(91, 43);
            btnSeleccion.TabIndex = 9;
            btnSeleccion.Text = "Selección";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTodos.Location = new Point(377, 164);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(91, 43);
            btnTodos.TabIndex = 10;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSubir
            // 
            btnSubir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubir.Location = new Point(677, 93);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(91, 43);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBajar.Location = new Point(677, 164);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(91, 43);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 388);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(lstAlmacen);
            Controls.Add(lstTienda);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(txtElemento);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnNuevo;
        private TextBox txtElemento;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private ListBox lstTienda;
        private ListBox lstAlmacen;
        private Button btnSeleccion;
        private Button btnTodos;
        private Button btnSubir;
        private Button btnBajar;
    }
}