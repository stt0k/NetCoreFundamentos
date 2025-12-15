namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFecha = new TextBox();
            chkFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            btnIncremento = new Button();
            label2 = new Label();
            txtIncremento = new TextBox();
            label3 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(21, 52);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(448, 35);
            txtFecha.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(21, 114);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(189, 34);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(21, 154);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(71, 34);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(21, 194);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(90, 34);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(21, 234);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(78, 34);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(264, 246);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(141, 41);
            btnIncremento.TabIndex = 6;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 198);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 7;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(353, 195);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 35);
            txtIncremento.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 331);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 9;
            label3.Text = "Fecha final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(21, 364);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(448, 35);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 425);
            Controls.Add(txtFechaFinal);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(btnIncremento);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(chkFormato);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private CheckBox chkFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private Button btnIncremento;
        private Label label2;
        private TextBox txtIncremento;
        private Label label3;
        private TextBox txtFechaFinal;
    }
}