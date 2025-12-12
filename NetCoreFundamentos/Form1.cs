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
            txtNombre.Location = new Point(10, 30);
            txtNombre.Text = "Soy un texto nuevo!!";
            txtNombre.Width = 220;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.BackColor = Color.Fuchsia;
            // STRING A PRIMITIVO
            string textoNumero = "89";
            int numero = int.Parse(textoNumero);

            // CASTING
            int mayor = 88;
            short pequeño = (short)mayor;
            string dato = pequeño.ToString();
            dato = btnPulsar.ToString();
        }
    }
}
