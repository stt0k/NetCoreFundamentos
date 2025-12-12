namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            txtColor1 = new TextBox();
            label2 = new Label();
            txtColor2 = new TextBox();
            label3 = new Label();
            txtColor3 = new TextBox();
            btnColor = new Button();
            label4 = new Label();
            txtPosicionX = new TextBox();
            label5 = new Label();
            txtPosicionY = new TextBox();
            btnPosicion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 50);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Color 1";
            // 
            // txtColor1
            // 
            txtColor1.Location = new Point(117, 68);
            txtColor1.MaxLength = 255;
            txtColor1.Name = "txtColor1";
            txtColor1.Size = new Size(100, 23);
            txtColor1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 109);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Color 2";
            // 
            // txtColor2
            // 
            txtColor2.Location = new Point(117, 127);
            txtColor2.Name = "txtColor2";
            txtColor2.Size = new Size(100, 23);
            txtColor2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 173);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Color 3";
            // 
            // txtColor3
            // 
            txtColor3.Location = new Point(117, 191);
            txtColor3.Name = "txtColor3";
            txtColor3.Size = new Size(100, 23);
            txtColor3.TabIndex = 5;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(117, 238);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(100, 36);
            btnColor.TabIndex = 6;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 50);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Posicion X";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(398, 68);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 109);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "Posicion Y ";
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(398, 127);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 10;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(398, 173);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(75, 23);
            btnPosicion.TabIndex = 11;
            btnPosicion.Text = "Posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPosicion);
            Controls.Add(txtPosicionY);
            Controls.Add(label5);
            Controls.Add(txtPosicionX);
            Controls.Add(label4);
            Controls.Add(btnColor);
            Controls.Add(txtColor3);
            Controls.Add(label3);
            Controls.Add(txtColor2);
            Controls.Add(label2);
            Controls.Add(txtColor1);
            Controls.Add(label1);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtColor1;
        private Label label2;
        private TextBox txtColor2;
        private Label label3;
        private TextBox txtColor3;
        private Button btnColor;
        private Label label4;
        private TextBox txtPosicionX;
        private Label label5;
        private TextBox txtPosicionY;
        private Button btnPosicion;
    }
}