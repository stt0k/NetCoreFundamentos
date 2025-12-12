namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Location = new Point(10, 30);
            this.txtNombre.Text = "Soy un texto nuevo!!";
            this.txtNombre.Width = 220;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.txtNombre.BackColor = Color.Fuchsia;
        }
    }
}
