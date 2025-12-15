namespace NetCoreFundamentos
{
    partial class Form06ValidarEmail
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
            txtEmail = new TextBox();
            btnValidar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 163);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(568, 35);
            txtEmail.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(144, 237);
            btnValidar.Margin = new Padding(5, 6, 5, 6);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(346, 100);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 76);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 2;
            label1.Text = "Validar Email";
            // 
            // Form06ValidarEmail
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 468);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Controls.Add(txtEmail);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form06ValidarEmail";
            Text = "Form06ValidarEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button btnValidar;
        private Label label1;
    }
}